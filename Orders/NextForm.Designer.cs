namespace Orders
{
    partial class NextForm
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
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(34, 43);
            panel1.Name = "panel1";
            panel1.Size = new Size(328, 250);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.9000006F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.FromArgb(128, 255, 128);
            label1.Location = new Point(53, 11);
            label1.Name = "label1";
            label1.Size = new Size(215, 72);
            label1.TabIndex = 0;
            label1.Text = "Баланс";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI Semibold", 14.1F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.FromArgb(128, 255, 255);
            label2.Location = new Point(3, 140);
            label2.Name = "label2";
            label2.Size = new Size(322, 68);
            label2.TabIndex = 1;
            label2.Text = "0.0000";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // NextForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 50);
            ClientSize = new Size(1483, 849);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "NextForm";
            Text = "NextForm";
            Load += NextForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
    }
}