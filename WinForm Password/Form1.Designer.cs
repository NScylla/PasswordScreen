namespace WinForm_Password
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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnYenile = new System.Windows.Forms.Button();
            this.txtBoxPassword2 = new System.Windows.Forms.TextBox();
            this.lblSifre = new System.Windows.Forms.Label();
            this.txtBoxPassword3 = new System.Windows.Forms.TextBox();
            this.lblAltyazi = new System.Windows.Forms.Label();
            this.txtBoxPassword4 = new System.Windows.Forms.TextBox();
            this.lblTimer = new System.Windows.Forms.Label();
            this.txtBoxPassword5 = new System.Windows.Forms.TextBox();
            this.txtBoxPassword1 = new System.Windows.Forms.TextBox();
            this.txtBoxPassword6 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTamam = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.linkHelp = new System.Windows.Forms.LinkLabel();
            this.picHelp = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHelp)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(599, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 26);
            this.label2.TabIndex = 22;
            this.label2.Text = "saniye kalmıştır.";
            // 
            // lblHeader
            // 
            this.lblHeader.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(139, 94);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(534, 29);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Lütfen Cep Telefonunuza Gelen Şifreyi Giriniz.";
            // 
            // btnYenile
            // 
            this.btnYenile.BackColor = System.Drawing.Color.DarkBlue;
            this.btnYenile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYenile.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnYenile.Location = new System.Drawing.Point(404, 302);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(319, 31);
            this.btnYenile.TabIndex = 9;
            this.btnYenile.Text = "ŞİFREYİ TEKRAR GÖNDER";
            this.btnYenile.UseVisualStyleBackColor = false;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // txtBoxPassword2
            // 
            this.txtBoxPassword2.Location = new System.Drawing.Point(378, 169);
            this.txtBoxPassword2.MaxLength = 1;
            this.txtBoxPassword2.Name = "txtBoxPassword2";
            this.txtBoxPassword2.PasswordChar = '*';
            this.txtBoxPassword2.Size = new System.Drawing.Size(35, 22);
            this.txtBoxPassword2.TabIndex = 2;
            this.txtBoxPassword2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxPassword1_KeyPress);
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSifre.Location = new System.Drawing.Point(156, 163);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(134, 29);
            this.lblSifre.TabIndex = 0;
            this.lblSifre.Text = "SMS Şifre:";
            // 
            // txtBoxPassword3
            // 
            this.txtBoxPassword3.Location = new System.Drawing.Point(443, 169);
            this.txtBoxPassword3.MaxLength = 1;
            this.txtBoxPassword3.Name = "txtBoxPassword3";
            this.txtBoxPassword3.PasswordChar = '*';
            this.txtBoxPassword3.Size = new System.Drawing.Size(35, 22);
            this.txtBoxPassword3.TabIndex = 3;
            this.txtBoxPassword3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxPassword1_KeyPress);
            // 
            // lblAltyazi
            // 
            this.lblAltyazi.AutoSize = true;
            this.lblAltyazi.BackColor = System.Drawing.Color.Transparent;
            this.lblAltyazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltyazi.Location = new System.Drawing.Point(85, 232);
            this.lblAltyazi.Name = "lblAltyazi";
            this.lblAltyazi.Size = new System.Drawing.Size(393, 26);
            this.lblAltyazi.TabIndex = 20;
            this.lblAltyazi.Text = "Şifrenizin kullanım süresinin kalmasına ";
            // 
            // txtBoxPassword4
            // 
            this.txtBoxPassword4.Location = new System.Drawing.Point(508, 169);
            this.txtBoxPassword4.MaxLength = 1;
            this.txtBoxPassword4.Name = "txtBoxPassword4";
            this.txtBoxPassword4.PasswordChar = '*';
            this.txtBoxPassword4.Size = new System.Drawing.Size(35, 22);
            this.txtBoxPassword4.TabIndex = 4;
            this.txtBoxPassword4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxPassword1_KeyPress);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.BackColor = System.Drawing.Color.Transparent;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(524, 232);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(126, 26);
            this.lblTimer.TabIndex = 21;
            this.lblTimer.Text = "                   ";
            // 
            // txtBoxPassword5
            // 
            this.txtBoxPassword5.Location = new System.Drawing.Point(573, 169);
            this.txtBoxPassword5.MaxLength = 1;
            this.txtBoxPassword5.Name = "txtBoxPassword5";
            this.txtBoxPassword5.PasswordChar = '*';
            this.txtBoxPassword5.Size = new System.Drawing.Size(35, 22);
            this.txtBoxPassword5.TabIndex = 5;
            this.txtBoxPassword5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxPassword1_KeyPress);
            // 
            // txtBoxPassword1
            // 
            this.txtBoxPassword1.Location = new System.Drawing.Point(313, 169);
            this.txtBoxPassword1.MaxLength = 1;
            this.txtBoxPassword1.Name = "txtBoxPassword1";
            this.txtBoxPassword1.PasswordChar = '*';
            this.txtBoxPassword1.Size = new System.Drawing.Size(35, 22);
            this.txtBoxPassword1.TabIndex = 1;
            this.txtBoxPassword1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxPassword1_KeyPress);
            // 
            // txtBoxPassword6
            // 
            this.txtBoxPassword6.Location = new System.Drawing.Point(638, 169);
            this.txtBoxPassword6.MaxLength = 1;
            this.txtBoxPassword6.Name = "txtBoxPassword6";
            this.txtBoxPassword6.PasswordChar = '*';
            this.txtBoxPassword6.Size = new System.Drawing.Size(35, 22);
            this.txtBoxPassword6.TabIndex = 6;
            this.txtBoxPassword6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxPassword1_KeyPress);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblHeader);
            this.panel1.Controls.Add(this.btnYenile);
            this.panel1.Controls.Add(this.txtBoxPassword2);
            this.panel1.Controls.Add(this.lblSifre);
            this.panel1.Controls.Add(this.txtBoxPassword3);
            this.panel1.Controls.Add(this.lblAltyazi);
            this.panel1.Controls.Add(this.txtBoxPassword4);
            this.panel1.Controls.Add(this.lblTimer);
            this.panel1.Controls.Add(this.txtBoxPassword5);
            this.panel1.Controls.Add(this.txtBoxPassword1);
            this.panel1.Controls.Add(this.txtBoxPassword6);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(838, 381);
            this.panel1.TabIndex = 24;
            // 
            // btnTamam
            // 
            this.btnTamam.BackColor = System.Drawing.Color.Green;
            this.btnTamam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTamam.Location = new System.Drawing.Point(590, 405);
            this.btnTamam.Name = "btnTamam";
            this.btnTamam.Size = new System.Drawing.Size(88, 33);
            this.btnTamam.TabIndex = 7;
            this.btnTamam.Text = "TAMAM";
            this.btnTamam.UseVisualStyleBackColor = false;
            this.btnTamam.Click += new System.EventHandler(this.btnTamam_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.BackColor = System.Drawing.Color.Red;
            this.btnIptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIptal.Location = new System.Drawing.Point(430, 405);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(88, 33);
            this.btnIptal.TabIndex = 8;
            this.btnIptal.Text = "İPTAL";
            this.btnIptal.UseVisualStyleBackColor = false;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // linkHelp
            // 
            this.linkHelp.AutoSize = true;
            this.linkHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkHelp.Location = new System.Drawing.Point(141, 411);
            this.linkHelp.Name = "linkHelp";
            this.linkHelp.Size = new System.Drawing.Size(73, 20);
            this.linkHelp.TabIndex = 10;
            this.linkHelp.TabStop = true;
            this.linkHelp.Text = "YARDIM";
            this.linkHelp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkHelp_LinkClicked);
            // 
            // picHelp
            // 
            this.picHelp.ErrorImage = global::WinForm_Password.Properties.Resources.question_mark_1;
            this.picHelp.Image = global::WinForm_Password.Properties.Resources.question_mark_1;
            this.picHelp.InitialImage = global::WinForm_Password.Properties.Resources.question_mark_1;
            this.picHelp.Location = new System.Drawing.Point(96, 405);
            this.picHelp.Name = "picHelp";
            this.picHelp.Size = new System.Drawing.Size(39, 33);
            this.picHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHelp.TabIndex = 28;
            this.picHelp.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 476);
            this.Controls.Add(this.picHelp);
            this.Controls.Add(this.linkHelp);
            this.Controls.Add(this.btnTamam);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHelp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.TextBox txtBoxPassword2;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.TextBox txtBoxPassword3;
        private System.Windows.Forms.Label lblAltyazi;
        private System.Windows.Forms.TextBox txtBoxPassword4;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.TextBox txtBoxPassword5;
        private System.Windows.Forms.TextBox txtBoxPassword1;
        private System.Windows.Forms.TextBox txtBoxPassword6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTamam;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.LinkLabel linkHelp;
        private System.Windows.Forms.PictureBox picHelp;
        private System.Windows.Forms.Timer timer1;
    }
}

