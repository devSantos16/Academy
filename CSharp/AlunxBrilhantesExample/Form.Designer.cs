namespace AlunxBrilhantesExample
{
    partial class Form
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
            LeftPanel = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // LeftPanel
            // 
            LeftPanel.FlowDirection = FlowDirection.RightToLeft;
            LeftPanel.Location = new Point(12, 12);
            LeftPanel.Name = "LeftPanel";
            LeftPanel.Size = new Size(161, 426);
            LeftPanel.TabIndex = 0;
            // 
            // Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LeftPanel);
            Name = "Form";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel LeftPanel;
    }
}
