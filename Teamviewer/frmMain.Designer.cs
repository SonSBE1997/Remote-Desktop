namespace Teamviewer
{
    partial class frmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtYourIP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtYourPassword = new System.Windows.Forms.TextBox();
            this.txtRemotePassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnectRemote = new System.Windows.Forms.Button();
            this.txtStatus = new System.Windows.Forms.Label();
            this.txtRemoteIP = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your IP:";
            // 
            // txtYourIP
            // 
            this.txtYourIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYourIP.Location = new System.Drawing.Point(56, 62);
            this.txtYourIP.Name = "txtYourIP";
            this.txtYourIP.ReadOnly = true;
            this.txtYourIP.Size = new System.Drawing.Size(172, 26);
            this.txtYourIP.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // txtYourPassword
            // 
            this.txtYourPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYourPassword.Location = new System.Drawing.Point(56, 143);
            this.txtYourPassword.Name = "txtYourPassword";
            this.txtYourPassword.ReadOnly = true;
            this.txtYourPassword.Size = new System.Drawing.Size(172, 26);
            this.txtYourPassword.TabIndex = 8;
            // 
            // txtRemotePassword
            // 
            this.txtRemotePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemotePassword.Location = new System.Drawing.Point(449, 143);
            this.txtRemotePassword.Name = "txtRemotePassword";
            this.txtRemotePassword.Size = new System.Drawing.Size(172, 26);
            this.txtRemotePassword.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(446, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(446, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Remote IP";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(481, 201);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(107, 32);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisconnectRemote
            // 
            this.btnDisconnectRemote.Enabled = false;
            this.btnDisconnectRemote.Location = new System.Drawing.Point(70, 201);
            this.btnDisconnectRemote.Name = "btnDisconnectRemote";
            this.btnDisconnectRemote.Size = new System.Drawing.Size(131, 32);
            this.btnDisconnectRemote.TabIndex = 4;
            this.btnDisconnectRemote.Text = "Disconnect Remote";
            this.btnDisconnectRemote.UseVisualStyleBackColor = true;
            this.btnDisconnectRemote.Click += new System.EventHandler(this.btnDisconnectRemote_Click);
            // 
            // txtStatus
            // 
            this.txtStatus.AutoSize = true;
            this.txtStatus.Location = new System.Drawing.Point(53, 259);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(0, 13);
            this.txtStatus.TabIndex = 10;
            // 
            // txtRemoteIP
            // 
            this.txtRemoteIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemoteIP.Location = new System.Drawing.Point(449, 62);
            this.txtRemoteIP.Name = "txtRemoteIP";
            this.txtRemoteIP.Size = new System.Drawing.Size(172, 26);
            this.txtRemoteIP.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 304);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.btnDisconnectRemote);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtRemotePassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRemoteIP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtYourPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtYourIP);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Teamviewer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtYourIP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtYourPassword;
        private System.Windows.Forms.TextBox txtRemotePassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisconnectRemote;
        private System.Windows.Forms.Label txtStatus;
        private System.Windows.Forms.TextBox txtRemoteIP;
    }
}

