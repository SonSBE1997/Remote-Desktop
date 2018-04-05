using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teamviewer
{
    public partial class frmViewScreen : Form
    {
        NetworkStream ns;
        int pbWidth, pbHeight;
        Thread showScreen;
        int resolutionRemoteX, resolutionRemoteY;

        public frmViewScreen(ref NetworkStream net, String resolution)
        {
            InitializeComponent();
            this.ns = net;
            string[] arr = resolution.Split(':');
            resolutionRemoteX = Int32.Parse(arr[1]);
            resolutionRemoteY = Int32.Parse(arr[2]);
        }


        private void frmViewScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void frmViewScreen_Resize(object sender, EventArgs e)
        {
            pbWidth = pbViewScreen.Width;
            pbHeight = pbViewScreen.Height;
        }


        private void frmViewScreen_Load(object sender, EventArgs e)
        {
            pbWidth = pbViewScreen.Width;
            pbHeight = pbViewScreen.Height;
            showScreen = new Thread(ShowScreen);
            showScreen.IsBackground = true;
            showScreen.Start();
        }

        private void ShowScreen()
        {
            try
            {
                while (true)
                {
                    BinaryFormatter bFormat = new BinaryFormatter();
                    Bitmap bmp = bFormat.Deserialize(ns) as Bitmap;
                    Bitmap resized = new Bitmap(bmp);
                    pbViewScreen.BackgroundImage = (Image)resized;
                }
            }
            catch
            {
            }
            this.Close();
        }


        ////////////////////////////////////// HANDLE_Mouse_Event//////////////////////////////////////////////////
        private void pbViewScreen_MouseClick(object sender, MouseEventArgs e)
        {
            sendMessage($":mouse_click");
        }

        private void pbViewScreen_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            sendMessage($":mouse_dbclick");
        }

        private void pbViewScreen_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                sendMessage($":mouse_leftdown");
            }
            else if (e.Button == MouseButtons.Right)
            {
                sendMessage($":mouse_rightdown");
            }
            if (e.Button == MouseButtons.Middle)
            {
                sendMessage($":mouse_middledown");
            }
        }

        private void pbViewScreen_MouseMove(object sender, MouseEventArgs e)
        {
            int x = (int)((float)e.X / pbWidth * resolutionRemoteX);
            int y = (int)((float)e.Y / pbHeight * resolutionRemoteY);
            sendMessage($":mouse_move:{x}:{y}");
        }

        private void pbViewScreen_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                sendMessage($":mouse_leftup");
            }
            else if (e.Button == MouseButtons.Right)
            {
                sendMessage($":mouse_rightup");
            }
            if (e.Button == MouseButtons.Middle)
            {
                sendMessage($":mouse_middleup");
            }
        }

        ///////////////////////////// Key Event
        private void frmViewScreen_KeyUp(object sender, KeyEventArgs e)
        {
            sendMessage($":key_up:" + ((byte)e.KeyCode).ToString());
        }


        private void frmViewScreen_KeyDown(object sender, KeyEventArgs e)
        {
            sendMessage($":key_down:" + ((byte)e.KeyCode).ToString());
        }
        //////////////////////////////
        private void sendMessage(string message)
        {
            try
            {
                ns.Write(Encoding.ASCII.GetBytes(message), 0, message.Length);
                ns.Flush();
            }
            catch { }
        }
    }
}
