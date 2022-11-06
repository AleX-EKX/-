using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace avtoriz
{
    public partial class technical_support : Form
    {
        public technical_support()
        {
            InitializeComponent();

            email.Text = "Введите email";
            email.ForeColor = Color.Gray;
            otziv.Text = "Опишите суть проблемы";
            otziv.ForeColor = Color.Gray;
        }
        
        


private void email_Enter(object sender, EventArgs e)
        {
            if (email.Text == "Введите email")//если текст равен внутри формы введите имя, то будет очистка от текста
            {
                email.Text = "";
                email.ForeColor = Color.Black;
            }
        }

        private void email_Leave(object sender, EventArgs e)
        {
            if (email.Text == "")//если поле пустое, то напишем введите имя
                email.Text = "Введите email";
            email.ForeColor = Color.Gray;
        }

        private void otziv_Enter(object sender, EventArgs e)
        {
            if (otziv.Text == "Опишите суть проблемы")//если текст равен внутри формы введите имя, то будет очистка от текста
            {
                otziv.Text = "";
                otziv.ForeColor = Color.Black;
            }
        }

        private void otziv_Leave(object sender, EventArgs e)
        {
            
            if (otziv.Text == "")//если поле пустое, то напишем введите имя
                otziv.Text = "Опишите суть проблемы";
            otziv.ForeColor = Color.Gray;
        }

        private void brat_btn1_Click(object sender, EventArgs e)
        {
            try
            {
                string eemail = email.Text;
                var addr = new System.Net.Mail.MailAddress(eemail);

                if (addr.Address == eemail)
                {


                }
            }
            catch
            {
                MessageBox.Show("Неверный адрес");
                return;
            }

            if (email.Text == "Введите e-mail")
            {
                MessageBox.Show("Введите e-mail");
                return;
            }
            string qemail = email.Text;
            int dlm = 60;

            if (qemail.Length > dlm)
            {
                MessageBox.Show("email слишком длинный");
                qemail = qemail.Remove(dlm);
                return;
            }

            if (otziv.Text == "Опишите суть проблемы")
            {
                MessageBox.Show("Опишите суть проблемы");
                return;
            }
            string otz = otziv.Text;
            int dotz = 10;
            if(otz.Length < dotz)
            {
                MessageBox.Show("опишите конкретней проблему");
                // otz = otz.Remove(dotz);
                return;
                
            }
            






            if (checkuser())
                return;

            DB db = new DB();

            MySqlCommand command = new MySqlCommand("INSERT INTO `technical_support` (`email`,`otziv`) VALUES (@email,@otziv)", db.GetConnection());


            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = email.Text;
            command.Parameters.Add("@otziv", MySqlDbType.VarChar).Value = otziv.Text;



            db.openConnection();

            if (command.ExecuteNonQuery() == 1)// если выполнение команды успешно, то создаем акк

                MessageBox.Show("Заявка отправлена, она будет рассмотрена в течении 24 часов");

            else
                MessageBox.Show("Упс, заявка уже рассматривается");

        }

        public Boolean checkuser()
        {
            DB db = new DB();
            //создаем табл
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `technical_support` where `email`= @email", db.GetConnection());// выбрать всех пользователь у которых логин такой же как ввел пользователь в регистрации 

            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = email.Text;
            


            // адаптер позволяет нам выбрать данные из бд
            adapter.SelectCommand = command;
            adapter.Fill(table);//данные трансформируем внутрь обекта табл

            if (table.Rows.Count > 0)// если записей больше 0, то будет авторизован
            {
                MessageBox.Show("Упс, заявка уже рассматривается");
                return true;//это возврат если сущ пользователь
            }
            else

                return false;//это  если несущ пользователь
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exit_MouseLeave(object sender, EventArgs e)
        {
            exit.ForeColor = Color.White;//при убирании мыши меняет цвет на белый
        }

        private void exit_MouseEnter(object sender, EventArgs e)
        {
            exit.ForeColor = Color.Red;//при наведение меняет цвет на красный
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.OK;

        }
        private void showForm(object sender, EventArgs e)
        {
            this.Show();
            MainForm main = new MainForm();
            main.Labuser.Text = Loggeduser.Login;
        }
        Point lastPoint;
        private void technical_support_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
                //код для перемещения окна
            }
        }

        private void technical_support_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);//код для перемещения
        }
    }
}
