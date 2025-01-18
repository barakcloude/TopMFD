using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace TopMFD
{
    internal class UdpManager
    {
        private string dcsIp = "192.168.1.202"; // כתובת ה-IP של DCS
        private int dcsSendPort = 10200;       // פורט לשליחת נתונים ל-DCS
        private int localReceivePort = 10600;  // פורט לקליטת נתונים מ-DCS

        private UdpClient udpClient;

        public UdpManager()
        {
            udpClient = new UdpClient(localReceivePort); // מאזין לפורט
        }

        public void SendToDCS(string message)
        {
            using (UdpClient client = new UdpClient())
            {
                client.Connect(dcsIp, dcsSendPort);
                byte[] data = Encoding.UTF8.GetBytes(message);
                client.Send(data, data.Length);
            }
        }

        public void ListenFromDCS(Action<string> callback)
        {
            Task.Run(() =>
            {
                IPEndPoint remoteEP = new IPEndPoint(IPAddress.Any, localReceivePort);
                while (true)
                {
                    try
                    {
                        byte[] receivedData = udpClient.Receive(ref remoteEP);
                        string message = Encoding.UTF8.GetString(receivedData);
                        callback?.Invoke(message); // קרא לפונקציה שהוזנה עם ההודעה
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error receiving UDP data: {ex.Message}");
                    }
                }
            });
        }

        // המתודה החדשה לחיפוש שם השחקן מתוך ההודעה
        public void ListenForPlayerName(Action<string> onPlayerNameReceived)
        {
            ListenFromDCS(message =>
            {
                // נניח שההודעה מכילה "PlayerName: <name>"
                if (message.StartsWith("PlayerName:"))
                {
                    string playerName = message.Substring("PlayerName:".Length);
                    onPlayerNameReceived?.Invoke(playerName);
                }
            });
        }
    }
}
