using Orders.MainContexts;

namespace Orders
{
    public partial class Form1 : Base
    {
        private bool drag = false;
        private Point startPoint = new Point(0, 0);

        public Form1() => InitializeComponent();

        //�������� �����
        private void Form1_Load(object sender, EventArgs e)
        {
            buttonReg.Enabled = false;
            checkBoxRobot.Enabled = false;
            checkBoxCheck.Enabled = true;
        }

        //��� �������
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

        //��� ��������� ������
        private void GetValues()
        {
            string name, lastname, email, phone, birth, pass, passCheck;
            name = textBoxRegName.Text; lastname = textBoxRegLastname.Text; email = textBoxRegEmail.Text; phone = maskedTextRegBoxPhone.Text;
            birth = maskedTextRegBoxBirth.Text; pass = textBoxRegPass.Text; passCheck = textBoxRegPassRepeat.Text;
            if (!string.IsNullOrWhiteSpace(name) && !string.IsNullOrWhiteSpace(lastname) && !string.IsNullOrWhiteSpace(email) && !string.IsNullOrWhiteSpace(phone) &&
                !string.IsNullOrWhiteSpace(birth) && !string.IsNullOrWhiteSpace(pass) && !string.IsNullOrWhiteSpace(passCheck)) checkBoxRobot.Enabled = true;
            if (!string.Equals(pass, passCheck)) MessageBox.Show("������ �� ���������", "��������������", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void AddNewClient()
        {
            ClientDb clientDb = new ClientDb()
            {
                Name = reg.GetName(textBoxRegName.Text),
                Lastname = reg.GetLastname(textBoxRegLastname.Text),
                Email = reg.GetEmail(textBoxRegEmail.Text),
                Pass = reg.GetPass(textBoxRegPass.Text),
                Phone = maskedTextRegBoxPhone.Text,
                Birth = maskedTextRegBoxBirth.Text
            };
            dataService.AddEntity(clientDb);
        }
        private void ShowEnterForm()
        {
            new Entrance().Show();
            this.Hide();
        }
        private void buttonEnter_Click(object sender, EventArgs e) => ShowEnterForm();

        //������� �����
        private void checkBoxCheck_MouseClick(object sender, MouseEventArgs e)
        {
            if (checkBoxCheck.Checked == true)
            {
                checkBoxCheck.Text = "�������� ������";
                GetValues();
            }
            else checkBoxCheck.Text = "��� ���� ������������";
        }

        private void checkBoxRobot_MouseClick(object sender, MouseEventArgs e) => buttonReg.Enabled = true;


        private void buttonReg_Click(object sender, EventArgs e)
        {
            try
            {
                AddNewClient();
                MessageBox.Show("�� ������� ���������������", "���������");
            }
            catch (Exception)
            {
                MessageBox.Show("���� ������ �� ����������", "���������");
            }
            ShowEnterForm();
        }

        private void textBoxRegEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
