using System;
using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UITesting;
using System.Threading;
using System.Runtime.InteropServices;
using System.Windows.Input;
using System.Threading.Tasks;

namespace OSRS_Dharok_Bot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            r = new Random();
            
            
        }
        
        bool ding = true;
        Random r;
        double timeleft;
        private async void btn_alch_Click(object sender, EventArgs e)
        {
            ding = true;
            await alch();

        }

        [DllImport("user32.dll")]
        static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

        // constants for the mouse_input() API function
        private const int MOUSEEVENTF_MOVE = 0x0001;
        private const int MOUSEEVENTF_LEFTDOWN = 0x0002;
        private const int MOUSEEVENTF_LEFTUP = 0x0004;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x0008;
        private const int MOUSEEVENTF_RIGHTUP = 0x0010;
        private const int MOUSEEVENTF_MIDDLEDOWN = 0x0020;
        private const int MOUSEEVENTF_MIDDLEUP = 0x0040;
        private const int MOUSEEVENTF_ABSOLUTE = 0x8000;


        // simulates movement of the mouse.  parameters specify changes
        // in relative position.  positive values indicate movement
        // right or down
        public static void Move(int xDelta, int yDelta)
        {
            mouse_event(MOUSEEVENTF_MOVE, xDelta, yDelta, 0, 0);
        }


        // simulates movement of the mouse.  parameters specify an
        // absolute location, with the top left corner being the
        // origin
        public static void MoveTo(int x, int y)
        {
            mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_MOVE, x, y, 0, 0);
        }


        // simulates a click-and-release action of the left mouse
        // button at its current position
        public static void LeftClick()
        {
            mouse_event(MOUSEEVENTF_LEFTDOWN, Control.MousePosition.X, Control.MousePosition.Y, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, Control.MousePosition.X, Control.MousePosition.Y, 0, 0);
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            ding = false;
            
        }
        private void OnKeyDownHandler(object sender, KeyEventArgs e)
        {
            
        }

        private async void btn_nmz_Click(object sender, EventArgs e)
        {
            
            ding = true;
            
            await nmz();


        }
        private async Task nmz()
        {
            ding = false;
            
            ding = true;
            timer1.Interval = 1000;
            int klik = 0;
            while (ding)
            {
                timer1.Start();
                timeleft = r.Next(1000, 50000);
                await Task.Delay(Convert.ToInt32(timeleft));

                
                LeftClick();
                lb_clicked.Text = (klik = klik + 1).ToString();
                timeleft = r.Next(100, 599);
                await Task.Delay(Convert.ToInt32(timeleft));
                Console.WriteLine(timeleft.ToString());
                LeftClick();
                timer1.Stop();
            }
        }
        private async Task alch()
        {
            ding = false;
            await Task.Delay(5);
            ding = true;
            Random r = new Random();
            while (ding)
            {
                int random = r.Next(100, 1000);
                
                lb_timer.Text = random.ToString();
                await Task.Delay(random);
                
                Console.WriteLine(random);
                LeftClick();
                
            }
        }

        private async void btn_guth_Click(object sender, EventArgs e)
        {
            
            await nmz_guth();
        }
        private async Task nmz_guth()
        {
            ding = false;
            await Task.Delay(5);
            ding = true;
            Random r = new Random();
            timer1.Interval = 1000;
            int klik = 0;
            while (ding)
            {
                timer1.Start();
                timeleft = r.Next(1000, 900000);
                await Task.Delay(Convert.ToInt32(timeleft));

                LeftClick();
                Console.WriteLine("clicked!");
                lb_clicked.Text = (klik = klik + 1).ToString();
                timer1.Stop();

            }
            
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeleft > 0)
            {
                lb_timer.Text = Math.Round(timeleft / 1000).ToString();
                timeleft = timeleft - 1000;
            }
        }
    }
}
