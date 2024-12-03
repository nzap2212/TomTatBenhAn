namespace UI
{
    partial class WaitForm
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
            tomtat_status = new ProgressBar();
            SuspendLayout();
            // 
            // tomtat_status
            // 
            tomtat_status.Location = new Point(24, 40);
            tomtat_status.MarqueeAnimationSpeed = 50;
            tomtat_status.Name = "tomtat_status";
            tomtat_status.Size = new Size(198, 21);
            tomtat_status.Style = ProgressBarStyle.Marquee;
            tomtat_status.TabIndex = 0;
            tomtat_status.UseWaitCursor = true;
            // 
            // WaitForm
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            ClientSize = new Size(251, 101);
            ControlBox = false;
            Controls.Add(tomtat_status);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "WaitForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Vui lòng đợi...";
            TopMost = true;
            UseWaitCursor = true;
            ResumeLayout(false);
        }

        #endregion

        private ProgressBar tomtat_status;
    }
}