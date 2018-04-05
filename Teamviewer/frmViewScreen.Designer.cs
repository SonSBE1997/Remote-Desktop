namespace Teamviewer
{
    partial class frmViewScreen
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
            this.pbViewScreen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbViewScreen)).BeginInit();
            this.SuspendLayout();
            // 
            // pbViewScreen
            // 
            this.pbViewScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbViewScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbViewScreen.Location = new System.Drawing.Point(0, 0);
            this.pbViewScreen.Name = "pbViewScreen";
            this.pbViewScreen.Size = new System.Drawing.Size(800, 599);
            this.pbViewScreen.TabIndex = 0;
            this.pbViewScreen.TabStop = false;
            this.pbViewScreen.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbViewScreen_MouseClick);
            this.pbViewScreen.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pbViewScreen_MouseDoubleClick);
            this.pbViewScreen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbViewScreen_MouseDown);
            this.pbViewScreen.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbViewScreen_MouseMove);
            this.pbViewScreen.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbViewScreen_MouseUp);
            // 
            // frmViewScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 599);
            this.Controls.Add(this.pbViewScreen);
            this.Name = "frmViewScreen";
            this.Text = "Remote Desktop";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmViewScreen_FormClosing);
            this.Load += new System.EventHandler(this.frmViewScreen_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmViewScreen_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmViewScreen_KeyUp);
            this.Resize += new System.EventHandler(this.frmViewScreen_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pbViewScreen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbViewScreen;
    }
}