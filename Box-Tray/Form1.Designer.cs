namespace Box_Tray
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxTray = new System.Windows.Forms.PictureBox();
            this.labelKodTray = new System.Windows.Forms.Label();
            this.textBoxTray = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelKodBox = new System.Windows.Forms.Label();
            this.textBoxBox = new System.Windows.Forms.TextBox();
            this.pictureBoxBox = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTray)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.pictureBoxTray);
            this.panel1.Controls.Add(this.labelKodTray);
            this.panel1.Controls.Add(this.textBoxTray);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(939, 227);
            this.panel1.TabIndex = 0;
            // 
            // pictureBoxTray
            // 
            this.pictureBoxTray.Location = new System.Drawing.Point(12, 80);
            this.pictureBoxTray.Name = "pictureBoxTray";
            this.pictureBoxTray.Size = new System.Drawing.Size(915, 144);
            this.pictureBoxTray.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxTray.TabIndex = 2;
            this.pictureBoxTray.TabStop = false;
            this.pictureBoxTray.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxTray_Paint);
            // 
            // labelKodTray
            // 
            this.labelKodTray.AutoSize = true;
            this.labelKodTray.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelKodTray.Location = new System.Drawing.Point(8, 47);
            this.labelKodTray.Name = "labelKodTray";
            this.labelKodTray.Size = new System.Drawing.Size(160, 20);
            this.labelKodTray.TabIndex = 1;
            this.labelKodTray.Text = "Tacka - kod kreskowy";
            // 
            // textBoxTray
            // 
            this.textBoxTray.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxTray.Location = new System.Drawing.Point(12, 12);
            this.textBoxTray.Name = "textBoxTray";
            this.textBoxTray.Size = new System.Drawing.Size(289, 32);
            this.textBoxTray.TabIndex = 0;
            this.textBoxTray.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBoxTray.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxTray_KeyDown);
            this.textBoxTray.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxTray_Validating);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Controls.Add(this.labelKodBox);
            this.panel2.Controls.Add(this.textBoxBox);
            this.panel2.Controls.Add(this.pictureBoxBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 227);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(939, 464);
            this.panel2.TabIndex = 1;
            // 
            // labelKodBox
            // 
            this.labelKodBox.AutoSize = true;
            this.labelKodBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelKodBox.Location = new System.Drawing.Point(8, 52);
            this.labelKodBox.Name = "labelKodBox";
            this.labelKodBox.Size = new System.Drawing.Size(164, 20);
            this.labelKodBox.TabIndex = 5;
            this.labelKodBox.Text = "Karton - kod kreskowy";
            // 
            // textBoxBox
            // 
            this.textBoxBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxBox.Location = new System.Drawing.Point(12, 17);
            this.textBoxBox.Name = "textBoxBox";
            this.textBoxBox.Size = new System.Drawing.Size(289, 32);
            this.textBoxBox.TabIndex = 4;
            this.textBoxBox.Enter += new System.EventHandler(this.textBox2_Enter);
            this.textBoxBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxBox_KeyDown);
            this.textBoxBox.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxBox_Validating);
            this.textBoxBox.Validated += new System.EventHandler(this.textBoxBox_Validated);
            // 
            // pictureBoxBox
            // 
            this.pictureBoxBox.Location = new System.Drawing.Point(12, 86);
            this.pictureBoxBox.Name = "pictureBoxBox";
            this.pictureBoxBox.Size = new System.Drawing.Size(859, 246);
            this.pictureBoxBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBox.TabIndex = 3;
            this.pictureBoxBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 691);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTray)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelKodTray;
        private System.Windows.Forms.TextBox textBoxTray;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBoxTray;
        private System.Windows.Forms.PictureBox pictureBoxBox;
        private System.Windows.Forms.Label labelKodBox;
        private System.Windows.Forms.TextBox textBoxBox;
    }
}

