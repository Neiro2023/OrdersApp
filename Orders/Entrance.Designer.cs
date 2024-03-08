namespace Orders
{
    partial class Entrance 
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
            panel2 = new Panel();
            Close2 = new Label();
            panel3 = new Panel();
            label1 = new Label();
            panel1 = new Panel();
            label6 = new Label();
            label5 = new Label();
            buttonRegBack = new Button();
            label4 = new Label();
            buttonEnter = new Button();
            textBoxEntPass = new TextBox();
            textBoxEntName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(64, 64, 64);
            panel2.Controls.Add(Close2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(586, 68);
            panel2.TabIndex = 0;
            panel2.MouseDown += panel2_MouseDown;
            panel2.MouseMove += panel2_MouseMove;
            panel2.MouseUp += panel2_MouseUp;
            // 
            // Close2
            // 
            Close2.Dock = DockStyle.Right;
            Close2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Close2.ForeColor = Color.FromArgb(128, 255, 128);
            Close2.Location = new Point(514, 0);
            Close2.Margin = new Padding(2, 0, 2, 0);
            Close2.Name = "Close2";
            Close2.Size = new Size(72, 68);
            Close2.TabIndex = 2;
            Close2.Text = "X";
            Close2.TextAlign = ContentAlignment.MiddleCenter;
            Close2.Click += Close2_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Lime;
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 1167);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(586, 10);
            panel3.TabIndex = 3;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 15.9000006F, FontStyle.Bold);
            label1.ForeColor = Color.Lime;
            label1.Location = new Point(32, 146);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(521, 82);
            label1.TabIndex = 1;
            label1.Text = "ВХОД";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(buttonRegBack);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(buttonEnter);
            panel1.Controls.Add(textBoxEntPass);
            panel1.Controls.Add(textBoxEntName);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(40, 260);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(499, 822);
            panel1.TabIndex = 2;
            // 
            // label6
            // 
            label6.BackColor = Color.Gainsboro;
            label6.Location = new Point(0, 713);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(493, 10);
            label6.TabIndex = 8;
            // 
            // label5
            // 
            label5.BackColor = Color.Gainsboro;
            label5.Location = new Point(2, 529);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(493, 10);
            label5.TabIndex = 7;
            // 
            // buttonRegBack
            // 
            buttonRegBack.BackColor = Color.Black;
            buttonRegBack.ForeColor = Color.FromArgb(128, 255, 128);
            buttonRegBack.Location = new Point(2, 594);
            buttonRegBack.Margin = new Padding(2);
            buttonRegBack.Name = "buttonRegBack";
            buttonRegBack.Size = new Size(493, 88);
            buttonRegBack.TabIndex = 6;
            buttonRegBack.Text = "Регистрация";
            buttonRegBack.UseVisualStyleBackColor = false;
            buttonRegBack.Click += buttonRegBack_Click;
            // 
            // label4
            // 
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(2, 539);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(493, 41);
            label4.TabIndex = 5;
            label4.Text = "Вернуться к регистрации";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonEnter
            // 
            buttonEnter.BackColor = Color.Black;
            buttonEnter.Font = new Font("Segoe UI", 11.1F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonEnter.ForeColor = Color.Lime;
            buttonEnter.Location = new Point(2, 353);
            buttonEnter.Margin = new Padding(2);
            buttonEnter.Name = "buttonEnter";
            buttonEnter.Size = new Size(497, 76);
            buttonEnter.TabIndex = 4;
            buttonEnter.Text = "Войти";
            buttonEnter.UseVisualStyleBackColor = false;
            buttonEnter.Click += buttonEnter_Click;
            // 
            // textBoxEntPass
            // 
            textBoxEntPass.Location = new Point(2, 228);
            textBoxEntPass.Margin = new Padding(2);
            textBoxEntPass.Name = "textBoxEntPass";
            textBoxEntPass.Size = new Size(495, 47);
            textBoxEntPass.TabIndex = 3;
            // 
            // textBoxEntName
            // 
            textBoxEntName.Location = new Point(2, 76);
            textBoxEntName.Margin = new Padding(2);
            textBoxEntName.Name = "textBoxEntName";
            textBoxEntName.Size = new Size(495, 47);
            textBoxEntName.TabIndex = 2;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(2, 156);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(497, 45);
            label3.TabIndex = 1;
            label3.Text = "Пароль";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(0, 0);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(497, 45);
            label2.TabIndex = 0;
            label2.Text = "Имя";
            // 
            // Entrance
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 50);
            ClientSize = new Size(586, 1177);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            MaximizeBox = false;
            Name = "Entrance";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Entrance";
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        internal Panel panel2;
        internal Label Close2;
        internal Label label1;
        internal Panel panel1;
        internal Button buttonEnter;
        internal TextBox textBoxEntPass;
        internal TextBox textBoxEntName;
        internal Label label3;
        internal Label label2;
        internal Button buttonRegBack;
        internal Label label4;
        internal Label label5;
        internal Label label6;
        internal Panel panel3;
    }
}