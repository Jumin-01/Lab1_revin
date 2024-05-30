namespace UserUse
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.animatedNotifyIcon1 = new AnimatedNotifyIcon.AnimatedNotifyIcon();
            this.SuspendLayout();
            // 
            // animatedNotifyIcon1
            // 
            this.animatedNotifyIcon1.Location = new System.Drawing.Point(-3, -1);
            this.animatedNotifyIcon1.Name = "animatedNotifyIcon1";
            this.animatedNotifyIcon1.NotifyContextMenu = null;
            this.animatedNotifyIcon1.NotifyText = "notifyIcon1";
            this.animatedNotifyIcon1.Size = new System.Drawing.Size(457, 281);
            this.animatedNotifyIcon1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 279);
            this.Controls.Add(this.animatedNotifyIcon1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private ContextMenuStrip contextMenuStrip1;
        private AnimatedNotifyIcon.AnimatedNotifyIcon animatedNotifyIcon1;
    }
}