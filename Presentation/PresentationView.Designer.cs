namespace Presentation
{
    partial class PresentationView
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
            this.movementTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // movementTimer
            // 
            this.movementTimer.Enabled = true;
            this.movementTimer.Interval = 5000;
            this.movementTimer.Tick += new System.EventHandler(this.movementTimer_Tick);
            // 
            // PresentationView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "PresentationView";
            this.Text = "Presentation View";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PresentationView_FormClosing);
            this.Load += new System.EventHandler(this.PresentationView_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer movementTimer;
    }
}