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
            textBox1 = new TextBox();
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
            containerMain.Panel1.Controls.Add(textBox1);
            // 
            // containerMain.Panel2
            // 
            containerMain.Panel2.AutoScroll = true;
            containerMain.Size = new Size(1326, 539);
            containerMain.SplitterDistance = 223;
            containerMain.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(30, 45);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
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
        private TextBox textBox1;
    }
}