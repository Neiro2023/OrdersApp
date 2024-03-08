namespace Orders
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
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            panel1 = new Panel();
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label7 = new Label();
            textBoxRegName = new TextBox();
            label2 = new Label();
            textBoxRegLastname = new TextBox();
            label3 = new Label();
            textBoxRegEmail = new TextBox();
            label4 = new Label();
            maskedTextRegBoxPhone = new MaskedTextBox();
            label5 = new Label();
            maskedTextRegBoxBirth = new MaskedTextBox();
            label6 = new Label();
            textBoxRegPass = new TextBox();
            label8 = new Label();
            textBoxRegPassRepeat = new TextBox();
            checkBoxCheck = new CheckBox();
            checkBoxRobot = new CheckBox();
            buttonReg = new Button();
            label9 = new Label();
            label10 = new Label();
            buttonEnter = new Button();
            panel2 = new Panel();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Transparent;
            tabPage1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            tabPage1.ForeColor = Color.Lime;
            tabPage1.Location = new Point(4, 44);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(450, 464);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Регистрация";
            // 
            // tabPage2
            // 
            tabPage2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            tabPage2.Location = new Point(4, 44);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(450, 464);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Вход";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(616, 68);
            panel1.TabIndex = 0;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            panel1.MouseUp += panel1_MouseUp;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Right;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.FromArgb(128, 255, 128);
            label1.Location = new Point(544, 0);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(72, 68);
            label1.TabIndex = 1;
            label1.Text = "X";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label7);
            flowLayoutPanel1.Controls.Add(textBoxRegName);
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(textBoxRegLastname);
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Controls.Add(textBoxRegEmail);
            flowLayoutPanel1.Controls.Add(label4);
            flowLayoutPanel1.Controls.Add(maskedTextRegBoxPhone);
            flowLayoutPanel1.Controls.Add(label5);
            flowLayoutPanel1.Controls.Add(maskedTextRegBoxBirth);
            flowLayoutPanel1.Controls.Add(label6);
            flowLayoutPanel1.Controls.Add(textBoxRegPass);
            flowLayoutPanel1.Controls.Add(label8);
            flowLayoutPanel1.Controls.Add(textBoxRegPassRepeat);
            flowLayoutPanel1.Controls.Add(checkBoxCheck);
            flowLayoutPanel1.Controls.Add(checkBoxRobot);
            flowLayoutPanel1.Controls.Add(buttonReg);
            flowLayoutPanel1.Location = new Point(53, 159);
            flowLayoutPanel1.Margin = new Padding(2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(521, 904);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label7.Location = new Point(2, 0);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(431, 35);
            label7.TabIndex = 5;
            label7.Text = "*Имя";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxRegName
            // 
            textBoxRegName.Location = new Point(2, 37);
            textBoxRegName.Margin = new Padding(2);
            textBoxRegName.Name = "textBoxRegName";
            textBoxRegName.Size = new Size(518, 47);
            textBoxRegName.TabIndex = 6;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label2.Location = new Point(2, 86);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(518, 35);
            label2.TabIndex = 7;
            label2.Text = "*Фамилия";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxRegLastname
            // 
            textBoxRegLastname.Location = new Point(2, 123);
            textBoxRegLastname.Margin = new Padding(2);
            textBoxRegLastname.Name = "textBoxRegLastname";
            textBoxRegLastname.Size = new Size(518, 47);
            textBoxRegLastname.TabIndex = 8;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label3.Location = new Point(2, 172);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(518, 35);
            label3.TabIndex = 9;
            label3.Text = "*Емаил";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxRegEmail
            // 
            textBoxRegEmail.Location = new Point(2, 209);
            textBoxRegEmail.Margin = new Padding(2);
            textBoxRegEmail.Name = "textBoxRegEmail";
            textBoxRegEmail.Size = new Size(518, 47);
            textBoxRegEmail.TabIndex = 10;
            textBoxRegEmail.TextChanged += textBoxRegEmail_TextChanged;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label4.Location = new Point(2, 258);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(518, 35);
            label4.TabIndex = 11;
            label4.Text = "*Телефон";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // maskedTextRegBoxPhone
            // 
            maskedTextRegBoxPhone.Location = new Point(2, 295);
            maskedTextRegBoxPhone.Margin = new Padding(2);
            maskedTextRegBoxPhone.Mask = "(999) 000-0000";
            maskedTextRegBoxPhone.Name = "maskedTextRegBoxPhone";
            maskedTextRegBoxPhone.Size = new Size(518, 47);
            maskedTextRegBoxPhone.TabIndex = 12;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label5.Location = new Point(2, 344);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(518, 35);
            label5.TabIndex = 13;
            label5.Text = "*Дата рождения";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // maskedTextRegBoxBirth
            // 
            maskedTextRegBoxBirth.Location = new Point(2, 381);
            maskedTextRegBoxBirth.Margin = new Padding(2);
            maskedTextRegBoxBirth.Mask = "00/00/0000";
            maskedTextRegBoxBirth.Name = "maskedTextRegBoxBirth";
            maskedTextRegBoxBirth.Size = new Size(518, 47);
            maskedTextRegBoxBirth.TabIndex = 14;
            maskedTextRegBoxBirth.ValidatingType = typeof(DateTime);
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label6.Location = new Point(2, 430);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(518, 35);
            label6.TabIndex = 15;
            label6.Text = "*Пароль";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxRegPass
            // 
            textBoxRegPass.Location = new Point(2, 467);
            textBoxRegPass.Margin = new Padding(2);
            textBoxRegPass.Name = "textBoxRegPass";
            textBoxRegPass.Size = new Size(518, 47);
            textBoxRegPass.TabIndex = 16;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label8.Location = new Point(2, 516);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(518, 35);
            label8.TabIndex = 17;
            label8.Text = "*Повторить пароль";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxRegPassRepeat
            // 
            textBoxRegPassRepeat.Location = new Point(2, 553);
            textBoxRegPassRepeat.Margin = new Padding(2);
            textBoxRegPassRepeat.Name = "textBoxRegPassRepeat";
            textBoxRegPassRepeat.Size = new Size(518, 47);
            textBoxRegPassRepeat.TabIndex = 18;
            // 
            // checkBoxCheck
            // 
            checkBoxCheck.AutoSize = true;
            checkBoxCheck.Location = new Point(2, 604);
            checkBoxCheck.Margin = new Padding(2);
            checkBoxCheck.Name = "checkBoxCheck";
            checkBoxCheck.Size = new Size(317, 45);
            checkBoxCheck.TabIndex = 19;
            checkBoxCheck.Text = "Проверить данные";
            checkBoxCheck.UseVisualStyleBackColor = true;
            checkBoxCheck.MouseClick += checkBoxCheck_MouseClick;
            // 
            // checkBoxRobot
            // 
            checkBoxRobot.AutoSize = true;
            checkBoxRobot.Enabled = false;
            checkBoxRobot.Location = new Point(2, 653);
            checkBoxRobot.Margin = new Padding(2);
            checkBoxRobot.Name = "checkBoxRobot";
            checkBoxRobot.Size = new Size(467, 45);
            checkBoxRobot.TabIndex = 20;
            checkBoxRobot.Text = "Подтвердите что Вы не робот";
            checkBoxRobot.UseVisualStyleBackColor = true;
            checkBoxRobot.MouseClick += checkBoxRobot_MouseClick;
            // 
            // buttonReg
            // 
            buttonReg.BackColor = Color.DimGray;
            buttonReg.BackgroundImageLayout = ImageLayout.None;
            buttonReg.Enabled = false;
            buttonReg.FlatAppearance.BorderColor = Color.White;
            buttonReg.FlatAppearance.BorderSize = 0;
            buttonReg.FlatAppearance.MouseDownBackColor = Color.White;
            buttonReg.FlatAppearance.MouseOverBackColor = Color.White;
            buttonReg.Font = new Font("Segoe UI", 11.1F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonReg.ForeColor = Color.Lime;
            buttonReg.Location = new Point(2, 731);
            buttonReg.Margin = new Padding(2, 31, 2, 2);
            buttonReg.Name = "buttonReg";
            buttonReg.Size = new Size(518, 76);
            buttonReg.TabIndex = 21;
            buttonReg.Text = "Зарегистрироваться";
            buttonReg.UseVisualStyleBackColor = false;
            buttonReg.Click += buttonReg_Click;
            // 
            // label9
            // 
            label9.BackColor = Color.FromArgb(40, 40, 50);
            label9.Font = new Font("Segoe UI Semibold", 15.9000006F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label9.ForeColor = Color.Lime;
            label9.Location = new Point(53, 90);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(521, 82);
            label9.TabIndex = 2;
            label9.Text = "РЕГИСТРАЦИЯ";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(91, 1078);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(212, 41);
            label10.TabIndex = 3;
            label10.Text = "*Есть аккаунт?";
            // 
            // buttonEnter
            // 
            buttonEnter.BackColor = Color.FromArgb(64, 64, 64);
            buttonEnter.ForeColor = Color.FromArgb(128, 255, 128);
            buttonEnter.Location = new Point(388, 1067);
            buttonEnter.Margin = new Padding(2);
            buttonEnter.Name = "buttonEnter";
            buttonEnter.Size = new Size(134, 62);
            buttonEnter.TabIndex = 4;
            buttonEnter.Text = "Войти";
            buttonEnter.UseVisualStyleBackColor = false;
            buttonEnter.Click += buttonEnter_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Lime;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 1172);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(616, 10);
            panel2.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 50);
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(616, 1182);
            Controls.Add(panel2);
            Controls.Add(buttonEnter);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            ForeColor = SystemColors.ButtonFace;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "РЕГИСТРАЦИЯ";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private TabPage tabPage1;
        private TabPage tabPage2;
        private Panel panel1;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label7;
        private TextBox textBoxRegName;
        private Label label2;
        private TextBox textBoxRegLastname;
        private Label label3;
        private TextBox textBoxRegEmail;
        private Label label4;
        private MaskedTextBox maskedTextRegBoxPhone;
        private Label label5;
        private MaskedTextBox maskedTextRegBoxBirth;
        private Label label6;
        private TextBox textBoxRegPass;
        private Label label8;
        private TextBox textBoxRegPassRepeat;
        private CheckBox checkBoxCheck;
        private CheckBox checkBoxRobot;
        private Button buttonReg;
        private Label label9;
        private Label label10;
        private Button buttonEnter;
        private Panel panel2;
    }
}
