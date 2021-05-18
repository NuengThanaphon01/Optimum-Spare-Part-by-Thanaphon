using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace TESTFORM
{
    public partial class Credit : Form
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        int x;

        public Credit()
        {
            InitializeComponent();
            player.URL = "Unity - Loop.mp3";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            player.controls.stop();
            this.Close();
        }

        private void Credit_Load(object sender, EventArgs e)
        {
            timer1.Start();
            player.settings.setMode("Loop", true);
            player.controls.play();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            x = 28;

            if(lblMoving.Left>=x)
            {
                lblMoving.Left = -568 ;
                //lblME.Text = lblMoving.Right.ToString();
            }
            else
            {
                lblMoving.Left = lblMoving.Left + 4;
                //lblME.Text = lblMoving.Left.ToString();
            }

            if (lblMoving.Left > -500)
            {
                lblMoving.ForeColor = Color.Red;
                lblME.ForeColor = Color.Blue;
            }
            if (lblMoving.Left > -400)
            {
                lblMoving.ForeColor = Color.Blue;
                lblME.ForeColor = Color.Lime;
            }
            if (lblMoving.Left > -300)
            {
                lblMoving.ForeColor = Color.Lime;
                lblME.ForeColor = Color.Gray;
            }
            if (lblMoving.Left > -200)
            {
                lblMoving.ForeColor = Color.Gray;
                lblME.ForeColor = Color.Cyan;
            }
            if (lblMoving.Left > -100)
            {
                lblMoving.ForeColor = Color.Cyan;
                lblME.ForeColor = Color.LightSeaGreen;
            }
            if (lblMoving.Left > 0)
            {
                lblMoving.ForeColor = Color.LightSeaGreen;
                lblME.ForeColor = Color.Red;
            }


        }

        private void btnMute_Click(object sender, EventArgs e)
        {
            if(btnMute.Text == "STOP MUSIC")
            {
                player.controls.stop();
                btnMute.Text = "PLAY MUSIC ";
            }
            else
            {
                player.controls.play();
                btnMute.Text = "STOP MUSIC";
            }
        }
    }
}
