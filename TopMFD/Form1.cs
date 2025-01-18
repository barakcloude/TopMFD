using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace TopMFD
{
    public partial class Form1 : Form
    {
        // Import Windows API functions
        [DllImport("user32.dll", EntryPoint = "SetWindowLong")]
        private static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        [DllImport("user32.dll", EntryPoint = "GetWindowLong")]
        private static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll", EntryPoint = "SetWindowPos")]
        private static extern bool SetWindowPos(IntPtr hWnd, int hWndInsertAfter, int x, int y, int cx, int cy, uint uFlags);

        // Constants for window styles and positioning
        private const int GWL_STYLE = -16;
        private const int WS_BORDER = 0x00800000;
        private const int WS_CAPTION = 0x00C00000;
        private const int HWND_TOPMOST = -1;
        private const int SWP_NOMOVE = 0x0002;
        private const int SWP_NOSIZE = 0x0001;

        // Customizable window position (change these values to adjust position)
        private int customX = 350;  // Change this for custom horizontal position
        private int customY = 400;  // Change this for custom vertical position
        private int windowWidth = 400;  // Window width
        private int windowHeight = 400; // Window height

        private UdpManager udpManager;

        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;
            this.BackColor = Color.Black;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Get the handle for this form
            IntPtr hWnd = this.Handle;

            // Remove border and caption
            int style = GetWindowLong(hWnd, GWL_STYLE);
            SetWindowLong(hWnd, GWL_STYLE, style & ~WS_BORDER & ~WS_CAPTION);

            // Use custom position for window
            MoveWindowToCustomPosition();

            // Set the window to always be on top
            SetAlwaysOnTop(hWnd, true);

            // הגדרות UDP
            udpManager = new UdpManager();

            // התחלת ההאזנה לשם השחקן
            udpManager.ListenForPlayerName(playerName =>
            {
                this.Invoke((Action)(() =>
                {
                    // עדכון השם בתצוגה
                    namevalue.Text = playerName;
                }));
            });

            // התחל האזנה להודעות מ-DCS
            udpManager.ListenFromDCS(OnMessageReceived);
        }

        private void OnMessageReceived(string message)
        {
            // עדכן את הממשק עם ההודעה
            this.Invoke((Action)(() =>
            {
                MessageBox.Show("Received from DCS: " + message);
            }));
        }

        private void MoveWindowToCustomPosition()
        {
            // Move the window to the new position (customX, customY)
            SetWindowPos(this.Handle, 0, customX, customY, windowWidth, windowHeight, 0);
        }

        private void SetAlwaysOnTop(IntPtr hWnd, bool onTop)
        {
            if (onTop)
            {
                SetWindowPos(hWnd, HWND_TOPMOST, 0, 0, 0, 0, SWP_NOMOVE | SWP_NOSIZE);
            }
            else
            {
                SetWindowPos(hWnd, 0, 0, 0, 0, 0, SWP_NOMOVE | SWP_NOSIZE);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the current window
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (udpManager != null)
            {
                string message = "1"; // לדוגמה, הודעת "1" ל-DCS
                udpManager.SendToDCS(message);
                MessageBox.Show("Sent to DCS: " + message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Empty method, you can handle other clicks if necessary
        }
    }
}
