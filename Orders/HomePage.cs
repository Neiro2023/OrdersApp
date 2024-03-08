using Orders.MainContexts;

namespace Orders
{
    public partial class HomePage : Base
    {
        bool drag = false;
        Point startPoint = new Point(0, 0);
        private Form? active = null;
        public HomePage() => InitializeComponent();

        //Код дизайна
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            startPoint = new Point(e.X, e.Y);
        }
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point point = PointToScreen(e.Location);
                this.Location = new Point(point.X - startPoint.X, point.Y - startPoint.Y);
            }
        }
        private void panel1_MouseUp(object sender, MouseEventArgs e) => drag = false;
        private void label1_Click(object sender, EventArgs e) => Application.Exit();
        private void label3_Click(object sender, EventArgs e)
        {
            panel6.Visible = true; panel6.BackColor = Color.Lime; panel7.Visible = false; panel8.Visible = false;
            OpenForm(new LastForm());
        }
        private void label4_Click(object sender, EventArgs e)
        {
            panel6.Visible = false; panel7.Visible = false; panel8.Visible = true; panel8.BackColor = Color.Lime;
            OpenForm(new NextForm());
        }
        private void label5_Click(object sender, EventArgs e)
        {
            panel7.Visible = true; panel6.Visible = false; panel7.BackColor = Color.Lime; panel8.Visible = false;
            OpenForm(new ElseForm());
        }
        private void OpenForm(Form cildren)
        {
            if (active != null) active.Close();
            active = cildren; cildren.TopLevel = false; cildren.FormBorderStyle = FormBorderStyle.None; cildren.Dock = DockStyle.Fill;
            panel4.Controls.Add(cildren); panel4.Tag = cildren; cildren.BringToFront(); cildren.Show();
        }
        private void label6_Click(object sender, EventArgs e)
        {
            new HomePage().Show();
            Hide();
        }
        private void label7_Click(object sender, EventArgs e)
        {
            ShowRegForm();
        }
        private void Home_MouseEnter(object sender, EventArgs e)
        {
            Home.BackColor = Color.Black;
        }
        private void Home_MouseLeave(object sender, EventArgs e)
        {
            Home.BackColor = Color.Transparent;
        }
        private void RegButton_MouseEnter(object sender, EventArgs e)
        {
            RegButton.BackColor = Color.Black;
        }
        private void RegButton_MouseLeave(object sender, EventArgs e)
        {
            RegButton.BackColor = Color.Transparent;
        }
        private void EntButton_Click(object sender, EventArgs e)
        {
            new Entrance().Show();
            this.Hide();
        }
        private void EntButton_MouseEnter(object sender, EventArgs e)
        {
            EntButton.BackColor = Color.Black;
        }
        private void EntButton_MouseLeave(object sender, EventArgs e)
        {
            EntButton.BackColor = Color.Transparent;
        }
        private void label2_MouseEnter(object sender, EventArgs e)
        {
            labelChange.BackColor = Color.Black;
        }
        private void labelChange_MouseLeave(object sender, EventArgs e)
        {
            labelChange.BackColor = Color.Transparent;
        }
        private void labelButCheckAccaunt_MouseEnter(object sender, EventArgs e)
        {
            labelButCheckAccaunt.BackColor = Color.Black;
        }
        private void labelButCheckAccaunt_MouseLeave(object sender, EventArgs e)
        {
            labelButCheckAccaunt.BackColor = Color.Transparent;
        }
        private void labelSend_MouseEnter(object sender, EventArgs e)
        {
            labelSend.BackColor = Color.Black;
        }
        private void labelSend_MouseLeave(object sender, EventArgs e)
        {
            labelSend.BackColor = Color.Transparent;
        }

        //Мои приватные методы 
        private void ShowRegForm()
        {
            new Form1().Show();
            Hide();
        }

        //События формы
        private void labelButCheckAccaunt_Click(object sender, EventArgs e)
        {
            string name = textBoxNameCheck.Text.Trim();
            string pass = textBoxLNameCheck.Text.Trim();
            if (appContext.Clients != null)
            {
                ClientDb? clientDb = dataService.SearchEntity(pass, name);
                if (clientDb?.Pass == pass) label11.Text = $"{name}, Вы есть в базе";
                else
                {
                    label11.Text = "Вас в базе нет ";
                    Task.Delay(1000);
                    ShowRegForm();
                }
            }
        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

     
    }
}
