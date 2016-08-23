namespace ChatOverlay
{
    partial class ControlPanel
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
            this.btnLaunchOverlay = new System.Windows.Forms.Button();
            this.btnLockOverlay = new System.Windows.Forms.Button();
            this.btnCloseOverlay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtChannel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ddlFont = new System.Windows.Forms.ComboBox();
            this.colorFont = new System.Windows.Forms.ColorDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.colorBG = new System.Windows.Forms.ColorDialog();
            this.boxColorFont = new System.Windows.Forms.PictureBox();
            this.boxColorBG = new System.Windows.Forms.PictureBox();
            this.chkShowUsers = new System.Windows.Forms.CheckBox();
            this.chkBold = new System.Windows.Forms.CheckBox();
            this.numOpacity = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.boxColorFont)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxColorBG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOpacity)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLaunchOverlay
            // 
            this.btnLaunchOverlay.BackColor = System.Drawing.SystemColors.Control;
            this.btnLaunchOverlay.Font = new System.Drawing.Font("Liberation Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaunchOverlay.Location = new System.Drawing.Point(12, 144);
            this.btnLaunchOverlay.Name = "btnLaunchOverlay";
            this.btnLaunchOverlay.Size = new System.Drawing.Size(80, 45);
            this.btnLaunchOverlay.TabIndex = 0;
            this.btnLaunchOverlay.Text = "Launch Overlay";
            this.btnLaunchOverlay.UseVisualStyleBackColor = false;
            this.btnLaunchOverlay.Click += new System.EventHandler(this.btnLaunchOverlay_Click);
            // 
            // btnLockOverlay
            // 
            this.btnLockOverlay.BackColor = System.Drawing.SystemColors.Control;
            this.btnLockOverlay.Enabled = false;
            this.btnLockOverlay.Font = new System.Drawing.Font("Liberation Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLockOverlay.Location = new System.Drawing.Point(98, 144);
            this.btnLockOverlay.Name = "btnLockOverlay";
            this.btnLockOverlay.Size = new System.Drawing.Size(80, 45);
            this.btnLockOverlay.TabIndex = 2;
            this.btnLockOverlay.Text = "Lock Overlay";
            this.btnLockOverlay.UseVisualStyleBackColor = false;
            this.btnLockOverlay.Click += new System.EventHandler(this.btnLockOverlay_Click);
            // 
            // btnCloseOverlay
            // 
            this.btnCloseOverlay.BackColor = System.Drawing.SystemColors.Control;
            this.btnCloseOverlay.Enabled = false;
            this.btnCloseOverlay.Font = new System.Drawing.Font("Liberation Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseOverlay.Location = new System.Drawing.Point(184, 144);
            this.btnCloseOverlay.Name = "btnCloseOverlay";
            this.btnCloseOverlay.Size = new System.Drawing.Size(80, 45);
            this.btnCloseOverlay.TabIndex = 3;
            this.btnCloseOverlay.Text = "Close Overlay";
            this.btnCloseOverlay.UseVisualStyleBackColor = false;
            this.btnCloseOverlay.Click += new System.EventHandler(this.btnCloseOverlay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Liberation Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Channel";
            // 
            // txtChannel
            // 
            this.txtChannel.Location = new System.Drawing.Point(79, 11);
            this.txtChannel.Name = "txtChannel";
            this.txtChannel.Size = new System.Drawing.Size(185, 20);
            this.txtChannel.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Liberation Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Font Size";
            // 
            // ddlFont
            // 
            this.ddlFont.FormattingEnabled = true;
            this.ddlFont.Items.AddRange(new object[] {
            "Smallest",
            "Small",
            "Medium",
            "Large",
            "XL"});
            this.ddlFont.Location = new System.Drawing.Point(78, 38);
            this.ddlFont.Name = "ddlFont";
            this.ddlFont.Size = new System.Drawing.Size(186, 21);
            this.ddlFont.TabIndex = 8;
            // 
            // colorFont
            // 
            this.colorFont.Color = System.Drawing.Color.White;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Liberation Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Font Color";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Liberation Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "BG Color";
            // 
            // boxColorFont
            // 
            this.boxColorFont.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.boxColorFont.Location = new System.Drawing.Point(78, 94);
            this.boxColorFont.Name = "boxColorFont";
            this.boxColorFont.Size = new System.Drawing.Size(69, 15);
            this.boxColorFont.TabIndex = 11;
            this.boxColorFont.TabStop = false;
            this.boxColorFont.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // boxColorBG
            // 
            this.boxColorBG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.boxColorBG.Location = new System.Drawing.Point(78, 118);
            this.boxColorBG.Name = "boxColorBG";
            this.boxColorBG.Size = new System.Drawing.Size(69, 15);
            this.boxColorBG.TabIndex = 12;
            this.boxColorBG.TabStop = false;
            this.boxColorBG.Click += new System.EventHandler(this.boxColorBG_Click);
            // 
            // chkShowUsers
            // 
            this.chkShowUsers.AutoSize = true;
            this.chkShowUsers.Location = new System.Drawing.Point(181, 118);
            this.chkShowUsers.Name = "chkShowUsers";
            this.chkShowUsers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkShowUsers.Size = new System.Drawing.Size(83, 17);
            this.chkShowUsers.TabIndex = 13;
            this.chkShowUsers.Text = "Show Users";
            this.chkShowUsers.UseVisualStyleBackColor = true;
            // 
            // chkBold
            // 
            this.chkBold.AutoSize = true;
            this.chkBold.Location = new System.Drawing.Point(193, 94);
            this.chkBold.Name = "chkBold";
            this.chkBold.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkBold.Size = new System.Drawing.Size(71, 17);
            this.chkBold.TabIndex = 14;
            this.chkBold.Text = "Bold Font";
            this.chkBold.UseVisualStyleBackColor = true;
            // 
            // numOpacity
            // 
            this.numOpacity.Location = new System.Drawing.Point(79, 65);
            this.numOpacity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numOpacity.Name = "numOpacity";
            this.numOpacity.Size = new System.Drawing.Size(68, 20);
            this.numOpacity.TabIndex = 15;
            this.numOpacity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Liberation Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "Opacity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(153, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "(1 to 100%)";
            // 
            // ControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 200);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numOpacity);
            this.Controls.Add(this.chkBold);
            this.Controls.Add(this.chkShowUsers);
            this.Controls.Add(this.boxColorBG);
            this.Controls.Add(this.boxColorFont);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ddlFont);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtChannel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLaunchOverlay);
            this.Controls.Add(this.btnCloseOverlay);
            this.Controls.Add(this.btnLockOverlay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ControlPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chatters - Chat Overlay for Twitch";
            ((System.ComponentModel.ISupportInitialize)(this.boxColorFont)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxColorBG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOpacity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLaunchOverlay;
        private System.Windows.Forms.Button btnLockOverlay;
        private System.Windows.Forms.Button btnCloseOverlay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtChannel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ddlFont;
        private System.Windows.Forms.ColorDialog colorFont;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColorDialog colorBG;
        private System.Windows.Forms.PictureBox boxColorFont;
        private System.Windows.Forms.PictureBox boxColorBG;
        private System.Windows.Forms.CheckBox chkShowUsers;
        private System.Windows.Forms.CheckBox chkBold;
        private System.Windows.Forms.NumericUpDown numOpacity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}