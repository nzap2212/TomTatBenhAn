namespace UI
{
    partial class PhacDoForm
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
            PhacDo_result = new RichTextBox();
            SuspendLayout();
            // 
            // PhacDo_result
            // 
            PhacDo_result.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PhacDo_result.Location = new Point(12, 12);
            PhacDo_result.Name = "PhacDo_result";
            PhacDo_result.ShortcutsEnabled = false;
            PhacDo_result.Size = new Size(805, 677);
            PhacDo_result.TabIndex = 0;
            PhacDo_result.Text = "";
            // 
            // PhacDoForm
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            ClientSize = new Size(830, 701);
            Controls.Add(PhacDo_result);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PhacDoForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gợi ý phác đồ điều trị";
            ResumeLayout(false);
        }

        #endregion

        public RichTextBox PhacDo_result;
    }
}