using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace UIControl
{
    public partial class Form1 : Form
    {

        string[] Ports = SerialPort.GetPortNames();


        public Form1()
        {
            InitializeComponent();
            InitStates();
        }

        private void InitStates()
        {
            bunifuMetroTextbox4.Enabled = false;
            bunifuMetroTextbox5.Enabled = false;
            ConnectedImage.Visible = false;
            ConnectedLabel.Visible = false;
            string[] Ports = SerialPort.GetPortNames();
            PortNameBox.Items.AddRange(Ports);
            BaudrateBox.Text = "115200";
            CloseSPBt.Enabled = false;
        }

        private void minbt_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void maxbt_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Maximized;
        }

        private void closebt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OpenSPBt_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = PortNameBox.Text;
                serialPort1.BaudRate = Convert.ToInt32(BaudrateBox.Text);
                serialPort1.ReadBufferSize = 100000;
                serialPort1.Open();
                CloseSPBt.Enabled = true;
                OpenSPBt.Enabled = false;
                ConnectedImage.Visible = true;
                ConnectedLabel.Visible = true;
                DisconnectedImage.Visible = false;
                DisconnectedLabel.Visible = false;
                PortNameBox.Enabled = false;
                BaudrateBox.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CloseSPBt_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Close();
                CloseSPBt.Enabled = false;
                OpenSPBt.Enabled = true;
                ConnectedImage.Visible = false;
                ConnectedLabel.Visible = false;
                DisconnectedImage.Visible = true;
                DisconnectedLabel.Visible = true;
                PortNameBox.Enabled = true;
                BaudrateBox.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TopPanel_DoubleClick(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Maximized;
        }

        private void btLeft1_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                serialPort1.Write("110");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btLeft1_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                serialPort1.Write("100");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btRight1_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                serialPort1.Write("111");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btRight1_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                serialPort1.Write("101");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btLeft2_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                serialPort1.Write("210");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btLeft2_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                serialPort1.Write("200");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btRight2_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                serialPort1.Write("211");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btRight2_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                serialPort1.Write("201");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btLeft3_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                serialPort1.Write("310");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btLeft3_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                serialPort1.Write("300");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btRight3_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                serialPort1.Write("311");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btRight3_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                serialPort1.Write("301");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btLeft4_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                serialPort1.Write("410");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btLeft4_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                serialPort1.Write("400");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btRight4_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                serialPort1.Write("411");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btRight4_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                serialPort1.Write("410");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
