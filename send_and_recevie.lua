local socket = require('socket')

local trx = socket.udp()
local ip = "192.168.1.202"
local portTrx = 10600
trx:setpeername(ip, portTrx)
trx:settimeout(1)
--reveive
local res = socket.udp()
local portRes = 10200
res:setsockname('*', portRes)
res:settimeout(0.01) 

local MyHook = {}

function MyHook:onMissionLoadEnd()
    log.info("Mission Loaded: Sending initial data.")
    socket.try(trx:send("Mission started!"))
    
    local playerID = 1 
    local name = net.get_player_info(playerID, 'name')
    socket.try(trx:send("PlayerName:" ..name))
end

function MyHook:onSimulationFrame()
    local receiveValue, receive_error = res:receive()

    if receive_error and receive_error ~= 'timeout' then
        log.error('Error receiving UDP data: ' .. tostring(receive_error))
        return
        
    end

    if receiveValue then
        log.info('Received data: ' .. receiveValue)
       
        if receiveValue == "1" or receiveValue == 1 then
            DCS.setPause(true)
        elseif receiveValue == "0" or receiveValue == 0 then
            DCS.setPause(false)
        end

      
        socket.try(trx:send("Received: " .. tostring(receiveValue)))
        
        log.info('Sent acknowledgment for received data.')
    else
        log.info('No data received this frame.')
    end
end

DCS.setUserCallbacks(MyHook)
