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
            this.slideTimer = new System.Windows.Forms.Timer(this.components);
            this.tweetTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // slideTimer
            // 
            this.slideTimer.Enabled = true;
            this.slideTimer.Interval = 5000;
            this.slideTimer.Tick += new System.EventHandler(this.slideTimer_Tick);
            // 
            // tweetTimer
            // 
            this.tweetTimer.Enabled = true;
            this.tweetTimer.Interval = 30000;
            this.tweetTimer.Tick += new System.EventHandler(this.tweetTimer_Tick);
            // 
            // PresentationView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.KeyPreview = true;
            this.Name = "PresentationView";
            this.Text = "Presentation View";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PresentationView_FormClosing);
            this.Load += new System.EventHandler(this.PresentationView_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PresentationView_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer slideTimer;
        private System.Windows.Forms.Timer tweetTimer;
    }
}