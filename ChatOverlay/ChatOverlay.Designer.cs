namespace ChatOverlay
{
    partial class ChatOverlay
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
            this.timerChat = new System.Windows.Forms.Timer(this.components);
            this.timerUsers = new System.Windows.Forms.Timer(this.components);
            this.tblLayout = new System.Windows.Forms.TableLayoutPanel();
            this.txtChat = new System.Windows.Forms.TextBox();
            this.txtUsers = new System.Windows.Forms.TextBox();
            this.lblMoveInfo = new System.Windows.Forms.Label();
            this.lblActiveControl = new System.Windows.Forms.Label();
            this.tblLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerChat
            // 
            this.timerChat.Interval = 1000;
            this.timerChat.Tick += new System.EventHandler(this.timerChat_Tick);
            // 
            // timerUsers
            // 
            this.timerUsers.Tick += new System.EventHandler(this.timerUsers_Tick);
            // 
            // tblLayout
            // 
            this.tblLayout.ColumnCount = 2;
            this.tblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.49347F));
            this.tblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.50653F));
            this.tblLayout.Controls.Add(this.txtChat, 0, 0);
            this.tblLayout.Controls.Add(this.txtUsers, 0, 0);
            this.tblLayout.Location = new System.Drawing.Point(-2, -3);
            this.tblLayout.Name = "tblLayout";
            this.tblLayout.RowCount = 1;
            this.tblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayout.Size = new System.Drawing.Size(766, 155);
            this.tblLayout.TabIndex = 5;
            this.tblLayout.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tblLayout_MouseDown);
            this.tblLayout.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tblLayout_MouseMove);
            this.tblLayout.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tblLayout_MouseUp);
            // 
            // txtChat
            // 
            this.txtChat.BackColor = System.Drawing.SystemColors.WindowText;
            this.txtChat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtChat.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtChat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtChat.ForeColor = System.Drawing.Color.White;
            this.txtChat.Location = new System.Drawing.Point(136, 3);
            this.txtChat.Multiline = true;
            this.txtChat.Name = "txtChat";
            this.txtChat.Size = new System.Drawing.Size(627, 149);
            this.txtChat.TabIndex = 5;
            this.txtChat.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tblLayout_MouseDown);
            this.txtChat.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tblLayout_MouseMove);
            this.txtChat.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tblLayout_MouseUp);
            // 
            // txtUsers
            // 
            this.txtUsers.BackColor = System.Drawing.SystemColors.WindowText;
            this.txtUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsers.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUsers.ForeColor = System.Drawing.Color.White;
            this.txtUsers.Location = new System.Drawing.Point(3, 3);
            this.txtUsers.Multiline = true;
            this.txtUsers.Name = "txtUsers";
            this.txtUsers.Size = new System.Drawing.Size(127, 149);
            this.txtUsers.TabIndex = 4;
            this.txtUsers.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tblLayout_MouseDown);
            this.txtUsers.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tblLayout_MouseMove);
            this.txtUsers.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tblLayout_MouseUp);
            // 
            // lblMoveInfo
            // 
            this.lblMoveInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMoveInfo.AutoSize = true;
            this.lblMoveInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblMoveInfo.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoveInfo.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblMoveInfo.Location = new System.Drawing.Point(184, 56);
            this.lblMoveInfo.Name = "lblMoveInfo";
            this.lblMoveInfo.Size = new System.Drawing.Size(399, 28);
            this.lblMoveInfo.TabIndex = 6;
            this.lblMoveInfo.Text = "Move me around then lock me in place.";
            this.lblMoveInfo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tblLayout_MouseDown);
            this.lblMoveInfo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tblLayout_MouseMove);
            this.lblMoveInfo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tblLayout_MouseUp);
            // 
            // lblActiveControl
            // 
            this.lblActiveControl.AutoSize = true;
            this.lblActiveControl.Location = new System.Drawing.Point(21, 20);
            this.lblActiveControl.Name = "lblActiveControl";
            this.lblActiveControl.Size = new System.Drawing.Size(0, 13);
            this.lblActiveControl.TabIndex = 7;
            // 
            // ChatOverlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 148);
            this.Controls.Add(this.lblMoveInfo);
            this.Controls.Add(this.tblLayout);
            this.Controls.Add(this.lblActiveControl);
            this.Name = "ChatOverlay";
            this.Text = "ChatOverlay";
            this.tblLayout.ResumeLayout(false);
            this.tblLayout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timerChat;
        private System.Windows.Forms.Timer timerUsers;
        private System.Windows.Forms.TableLayoutPanel tblLayout;
        private System.Windows.Forms.TextBox txtUsers;
        private System.Windows.Forms.Label lblMoveInfo;
        private System.Windows.Forms.TextBox txtChat;
        private System.Windows.Forms.Label lblActiveControl;
    }
}

