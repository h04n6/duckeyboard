namespace DuckeyBoard
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
            containerMain = new SplitContainer();
            cbxKeyboardLayout = new ComboBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)containerMain).BeginInit();
            containerMain.Panel1.SuspendLayout();
            containerMain.SuspendLayout();
            SuspendLayout();
            // 
            // containerMain
            // 
            containerMain.BorderStyle = BorderStyle.Fixed3D;
            containerMain.Dock = DockStyle.Fill;
            containerMain.Location = new Point(0, 0);
            containerMain.Name = "containerMain";
            // 
            // containerMain.Panel1
            // 
            containerMain.Panel1.Controls.Add(label1);
            containerMain.Panel1.Controls.Add(cbxKeyboardLayout);
            // 
            // containerMain.Panel2
            // 
            containerMain.Panel2.AutoScroll = true;
            containerMain.Size = new Size(1326, 539);
            containerMain.SplitterDistance = 223;
            containerMain.TabIndex = 2;
            // 
            // cbxKeyboardLayout
            // 
            cbxKeyboardLayout.FormattingEnabled = true;
            cbxKeyboardLayout.Location = new Point(10, 70);
            cbxKeyboardLayout.Name = "cbxKeyboardLayout";
            cbxKeyboardLayout.Size = new Size(163, 23);
            cbxKeyboardLayout.TabIndex = 0;
            cbxKeyboardLayout.SelectedIndexChanged += cbxKeyboardLayout_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 52);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 1;
            label1.Text = "Layouts";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1326, 539);
            Controls.Add(containerMain);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            containerMain.Panel1.ResumeLayout(false);
            containerMain.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)containerMain).EndInit();
            containerMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer containerMain;
        private Label label1;
        private ComboBox cbxKeyboardLayout;
    }
}