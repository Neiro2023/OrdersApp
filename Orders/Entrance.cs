using Orders.MainContexts;

namespace Orders
{
    public partial class Entrance : Base
    {
        private bool drag = false;
        private Point startPoint = new Point(0, 0);
        public Entrance() => InitializeComponent();

        //Код дизайна
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            startPoint = new Point(e.X, e.Y);
        }
        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point point = PointToScreen(e.Location);
                this.Location = new Point(point.X - startPoint.X, point.Y - startPoint.Y);
            }
        }
        private void panel2_MouseUp(object sender, MouseEventArgs e) => drag = false;
        private void Close2_Click(object sender, EventArgs e) => Application.Exit();

        //Мои приватные методы
        private void SearchClient(string pass, string name)
        {
            if (appContext.Clients != null)
            {
                ClientDb? clientDb = dataService.SearchEntity(pass, name);
                if (clientDb?.Pass == pass) ShowHomePage();
                else MessageBox.Show("Такой пользователь не найден");
            }
        }
        private void ShowHomePage()
        {
            new HomePage().Show();
            this.Hide();
        }

        //События формы
        private void buttonRegBack_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }
        private void buttonEnter_Click(object sender, EventArgs e)
        {
            string name = textBoxEntName.Text;  
            string pass = textBoxEntPass.Text;
            SearchClient(pass, name);
        }
    }
}
