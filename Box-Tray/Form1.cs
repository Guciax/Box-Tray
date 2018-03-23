using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Box_Tray
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            KListener.KeyUp += new RawKeyEventHandler(KListener_KeyDown);

        }
        Panel resultPanel = new Panel();
        Label resultMessage = new Label();
        KeyboardListener KListener = new KeyboardListener();

        void KListener_KeyDown(object sender, RawKeyEventArgs args)
        {
            if (resultPanel.Visible)
            {
                textBoxTray.Text = "";
                textBoxBox.Text = "";
                this.ActiveControl = textBoxTray;
                resultPanel.Visible = false;
            }
            else
            {
                if (args.Key == System.Windows.Input.Key.Return)
                {
                    labelKodTray.Text = "Kod tray:" + Environment.NewLine + textBoxTray.Text;
                    labelKodBox.Text = "Kod karton:" + Environment.NewLine + textBoxBox.Text;
                    CheckCodes();

                    if (textBoxBox.Focused)
                    {
                        textBoxTray.Focus();
                    }
                    else
                    {
                        textBoxBox.Focus();
                    }

                    DisplayLabelImage();
                    if (textBoxTray.Focused)
                    {
                        textBoxTray.BackColor = Color.Yellow;
                        textBoxBox.BackColor = Color.White;
                    }
                    else
                    {
                        textBoxTray.BackColor = Color.White;
                        textBoxBox.BackColor = Color.Yellow;
                    }
                    labelKodTray.Text = "Kod tray:" ;
                    labelKodBox.Text = "Kod karton:" ;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            resultPanel.Parent = this;
            resultPanel.BringToFront();
            resultPanel.Location = new Point(0, 0);
            //resultPanel.Size = new Size(this.ClientSize.Width, this.ClientSize.Height - 10);
            resultPanel.Visible = false;

            resultMessage.Parent = resultPanel;
            resultMessage.AutoSize = false;
            resultMessage.TextAlign = ContentAlignment.MiddleCenter;
            resultMessage.ForeColor = Color.White;
            resultMessage.Font = new Font("Arial", 76, FontStyle.Bold);

            

            Label spaceLabel = new Label();
            spaceLabel.Parent = resultPanel;
            spaceLabel.AutoSize = false;
            spaceLabel.Dock = DockStyle.Bottom;
            spaceLabel.TextAlign = ContentAlignment.TopCenter;
            spaceLabel.BringToFront();
            spaceLabel.Text = "Naciśnij SPACJĘ";
            spaceLabel.Font = new Font("Arial", 24);
            spaceLabel.Size = new Size(250, 45);
            resultMessage.Dock = DockStyle.Fill;

            CheckLayout();


        }
        private void DisplayLabelImage()
        {
            if (textBoxTray.Focused)
            {
                pictureBoxTray.Image = Box_Tray.Properties.Resources.box;
                pictureBoxBox.Image = null;
            }
            else
            {
                pictureBoxBox.Image = Box_Tray.Properties.Resources.tray2;
                pictureBoxTray.Image = null;
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            DisplayLabelImage();
            if (textBoxTray.Focused)
            {
                textBoxTray.BackColor = Color.Yellow;
                textBoxBox.BackColor = Color.White;
            }
            else
            {
                textBoxTray.BackColor = Color.White;
                textBoxBox.BackColor = Color.Yellow;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            DisplayLabelImage();
            if (textBoxTray.Focused)
            {
                textBoxTray.BackColor = Color.Yellow;
                textBoxBox.BackColor = Color.White;
            }
            else
            {
                textBoxTray.BackColor = Color.White;
                textBoxBox.BackColor = Color.Yellow;
            }
        }

        private void textBoxTray_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Return & !resultPanel.Visible)
            //{
            //    labelKodTray.Text = "Kod tray:" + Environment.NewLine + textBoxTray.Text;
            //    CheckCodes();
            //    textBoxBox.Focus();
            //}
        }

        private void textBoxBox_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Return & !resultPanel.Visible)
            //{
            //    labelKodBox.Text = "Kod tray:" + Environment.NewLine + textBoxBox.Text;
            //    CheckCodes();
            //    textBoxTray.Focus();
            //}
        }
        private void CheckCodes()
        {
            if (textBoxBox.Text.Trim().Length > 0 & textBoxTray.Text.Trim().Length > 0) 
            {
                string boxCode = textBoxBox.Text.Substring(1, textBoxBox.Text.Length - 1);
                string trayCode = textBoxTray.Text.Substring(1, textBoxTray.Text.Length - 1);

                if (boxCode==trayCode)
                {
                    ShowResult("OK", Color.Lime);
                }
                else
                {
                    string error = "BŁĄD!" + Environment.NewLine + "Tray: " + textBoxTray.Text + Environment.NewLine + "Karton: " + textBoxBox.Text;
                    ShowResult(error, Color.Red);
                }
            }
        }

        private void ShowResult(string result, Color clr)
        {
            resultMessage.Text = result;
            resultPanel.BackColor = clr;
            resultPanel.Visible = true;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void textBoxBox_Validated(object sender, EventArgs e)
        {

        }

        private void textBoxTray_Validating(object sender, CancelEventArgs e)
        {

        }

        private void textBoxBox_Validating(object sender, CancelEventArgs e)
        {

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            CheckLayout();
        }

        private void CheckLayout()
        {
            resultPanel.Size = this.ClientSize;
            panel1.Height = this.ClientSize.Height / 2;
            pictureBoxTray.Height = panel1.Height - (labelKodTray.Location.Y + 15);
            pictureBoxBox.Height = panel2.Height - (labelKodBox.Location.Y + 15);
            pictureBoxTray.Width = panel1.Width;
            pictureBoxBox.Width = panel2.Width;
            pictureBoxTray.Location = new Point(0, labelKodTray.Location.Y + 15);
            pictureBoxBox.Location = new Point(0, labelKodBox.Location.Y + 15);
        }

        private void pictureBoxTray_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
