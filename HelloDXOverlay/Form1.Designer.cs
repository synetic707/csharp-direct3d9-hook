namespace HelloDXOverlay
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
            if (disposing && (components != null)) {
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_game = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lb_ = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_browse = new System.Windows.Forms.Button();
            this.btn_startoverlay = new System.Windows.Forms.Button();
            this.tb_color = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_textoverlay = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lb_log = new System.Windows.Forms.ListBox();
            this.btn_att = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_size = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Process name:";
            // 
            // tb_game
            // 
            this.tb_game.Location = new System.Drawing.Point(92, 11);
            this.tb_game.Name = "tb_game";
            this.tb_game.Size = new System.Drawing.Size(100, 20);
            this.tb_game.TabIndex = 1;
            this.tb_game.Text = "Terraria";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(138, 99);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // lb_
            // 
            this.lb_.AutoSize = true;
            this.lb_.Location = new System.Drawing.Point(30, 106);
            this.lb_.Name = "lb_";
            this.lb_.Size = new System.Drawing.Size(35, 13);
            this.lb_.TabIndex = 5;
            this.lb_.Text = "label2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_size);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btn_browse);
            this.groupBox1.Controls.Add(this.btn_startoverlay);
            this.groupBox1.Controls.Add(this.tb_color);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_textoverlay);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 160);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Overlay";
            // 
            // btn_browse
            // 
            this.btn_browse.Location = new System.Drawing.Point(205, 44);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(89, 23);
            this.btn_browse.TabIndex = 5;
            this.btn_browse.Text = "Browse Color";
            this.btn_browse.UseVisualStyleBackColor = true;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // btn_startoverlay
            // 
            this.btn_startoverlay.Location = new System.Drawing.Point(113, 106);
            this.btn_startoverlay.Name = "btn_startoverlay";
            this.btn_startoverlay.Size = new System.Drawing.Size(136, 29);
            this.btn_startoverlay.TabIndex = 4;
            this.btn_startoverlay.Text = "Change Text";
            this.btn_startoverlay.UseVisualStyleBackColor = true;
            this.btn_startoverlay.Click += new System.EventHandler(this.btn_startoverlay_Click);
            // 
            // tb_color
            // 
            this.tb_color.Enabled = false;
            this.tb_color.Location = new System.Drawing.Point(99, 46);
            this.tb_color.Name = "tb_color";
            this.tb_color.Size = new System.Drawing.Size(100, 20);
            this.tb_color.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Color:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Text to overlay:";
            // 
            // tb_textoverlay
            // 
            this.tb_textoverlay.Location = new System.Drawing.Point(99, 20);
            this.tb_textoverlay.Name = "tb_textoverlay";
            this.tb_textoverlay.Size = new System.Drawing.Size(195, 20);
            this.tb_textoverlay.TabIndex = 0;
            this.tb_textoverlay.Text = "Hello, Direct3D9 Overlay!";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lb_log);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(12, 222);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(371, 141);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Log";
            // 
            // lb_log
            // 
            this.lb_log.FormattingEnabled = true;
            this.lb_log.Location = new System.Drawing.Point(6, 19);
            this.lb_log.Name = "lb_log";
            this.lb_log.Size = new System.Drawing.Size(359, 108);
            this.lb_log.TabIndex = 0;
            // 
            // btn_att
            // 
            this.btn_att.Location = new System.Drawing.Point(272, 8);
            this.btn_att.Name = "btn_att";
            this.btn_att.Size = new System.Drawing.Size(105, 24);
            this.btn_att.TabIndex = 8;
            this.btn_att.Text = "Attach";
            this.btn_att.UseVisualStyleBackColor = true;
            this.btn_att.Click += new System.EventHandler(this.btn_att_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(31, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 20);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Text size:";
            // 
            // tb_size
            // 
            this.tb_size.Location = new System.Drawing.Point(99, 71);
            this.tb_size.Name = "tb_size";
            this.tb_size.Size = new System.Drawing.Size(28, 20);
            this.tb_size.TabIndex = 8;
            this.tb_size.Text = "18";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 375);
            this.Controls.Add(this.btn_att);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lb_);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.tb_game);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Direct3D9 Hook";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_game;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lb_;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_browse;
        private System.Windows.Forms.Button btn_startoverlay;
        private System.Windows.Forms.TextBox tb_color;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_textoverlay;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lb_log;
        private System.Windows.Forms.Button btn_att;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tb_size;
        private System.Windows.Forms.Label label4;
    }
}

