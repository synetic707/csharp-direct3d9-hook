using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyHook;
using System.Diagnostics;
using System.Threading;

namespace HelloDXOverlay
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            //TODO: implement a better solution for cross thread calls
            _Interface.onHookstatusChange += _Interface_onHookstatusChange;
            _Interface.onMessage += _Interface_onMessage;
        }

        void _Interface_onHookstatusChange(HookInterface.Hookstatus status)
        {
            if (status == HookInterface.Hookstatus.Hooked) {
                groupBox1.Enabled = true;
                groupBox2.Enabled = true;
            }
        }

        private string ChannelName;
        private HookInterface _Interface = new HookInterface();

        public void _Interface_onMessage(string text)
        {
            lb_log.Items.Add(text);
        }

        private void btn_att_Click(object sender, EventArgs e)
        {
            new Thread(() => {
                string _process = tb_game.Text;
                _Interface.OverlayText = tb_textoverlay.Text;
                _Interface.Colour = pictureBox1.BackColor;
                _Interface.OverlaySize = Convert.ToInt32(tb_size.Text);
                try {
                    Process p = Process.GetProcessesByName(_process)[0];
                    RemoteHooking.IpcCreateServer<HookInterface>(ref ChannelName, System.Runtime.Remoting.WellKnownObjectMode.SingleCall, _Interface);
                    RemoteHooking.Inject(p.Id, "overlay.dll", "overlay.dll", ChannelName);
                } catch (Exception ex) {
                    MessageBox.Show("ERROR: " + ex.Message + "\r\n" + ex.StackTrace);
                }

                
            }).Start();


        }

        private void btn_browse_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                tb_color.Text = colorDialog1.Color.A + ":" + colorDialog1.Color.G + ":" + colorDialog1.Color.B;
                pictureBox1.BackColor = colorDialog1.Color;
            }
            
        }

        private void btn_startoverlay_Click(object sender, EventArgs e)
        {
            _Interface.OverlayText = tb_textoverlay.Text;
            _Interface.Colour = pictureBox1.BackColor;
            _Interface.OverlaySize = Convert.ToInt32(tb_size.Text);
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.FromArgb(251, 184, 41);
        }
    }
}
