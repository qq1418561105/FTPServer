using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Net;
using System.IO;
using System.Threading;
using System.Net.Sockets;

namespace FTPCloudDisk
{
    delegate void Dele_FindNone(bool tf);

    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            ThreadStart FLoginEnabled = new ThreadStart(OtherThread);
            Thread LoginEnabled = new Thread(FLoginEnabled);
            LoginEnabled.IsBackground = true;
            LoginEnabled.Start();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            this.LabelUser.BackColor = Color.FromArgb(100, 255, 255, 255);
            this.LabelPassword.BackColor = Color.FromArgb(100, 255, 255, 255);
            this.LabelPassword2.BackColor = Color.FromArgb(100, 255, 255, 255);
            this.UserName.BackColor = Color.FromArgb(255, 255, 255, 255);
            this.Password.BackColor = Color.FromArgb(255, 255, 255, 255);
            this.Password2.BackColor = Color.FromArgb(255, 255, 255, 255);
        }

        private void OtherThread()
        {
            try
            {
                while (true)
                {
                    if (UserName.Text.ToString() == "" | Password.Text.ToString() == "" | Password2.Text.ToString() == "")
                    {
                        if (this.Submit.Enabled == true)
                        {
                            Delegate_FindNone(false);
                        }
                    }
                    else
                    {
                        if (this.Submit.Enabled == false)
                        {
                            Delegate_FindNone(true);
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void Delegate_FindNone(bool tf)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new Dele_FindNone(Delegate_FindNone), tf);
            }
            else
            {
                try
                {
                    if (tf)
                    {
                        this.Submit.Enabled = true;
                    }
                    else
                    {
                        this.Submit.Enabled = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

    }
}
