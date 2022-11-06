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
    public partial class registr : Form
    {
        public registr()
        {
            InitializeComponent();
            usernameField.Text = "Введите имя";
            usernameField.ForeColor = Color.Gray;
            usersureField.Text = "Введите фамилию";
            usersureField.ForeColor = Color.Gray;

            LogField.Text = "Введите логин";
            LogField.ForeColor = Color.Gray;
            PassField.Text = "Введите пароль";
            PassField.ForeColor = Color.Gray;

        }

        private void closelabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void closelabel_MouseLeave(object sender, EventArgs e)
        {
            closelabel.ForeColor = Color.White;//при убирании мыши меняет цвет на белый
        }

        private void closelabel_MouseEnter(object sender, EventArgs e)
        {
            closelabel.ForeColor = Color.Red;//при наведение меняет цвет на красный
        }

        Point lastPoint;
        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
                //код для перемещения окна
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);//код для перемещения
        }



        // при вводе текста
        private void usernameField_Enter(object sender, EventArgs e)
        {
            //когда пользователь будет что-то писать, будет пустым
            if(usernameField.Text=="Введите имя")//если текст равен внутри формы введите имя, то будет очистка от текста
            {
                usernameField.Text = "";
                usernameField.ForeColor = Color.Black;
            }
            
        }
        //при выходе с формы
        private void usernameField_Leave(object sender, EventArgs e)
        {

            if (usernameField.Text == "")//если поле пустое, то напишем введите имя
                usernameField.Text = "Введите имя";
            usernameField.ForeColor = Color.Gray;
        }

        private void usersureField_Enter(object sender, EventArgs e)
        {
            if (usersureField.Text == "Введите фамилию")//если текст равен внутри формы введите имя, то будет очистка от текста
            {
                usersureField.Text = "";
                usersureField.ForeColor = Color.Black;
            }
        }

        private void usersureField_Leave(object sender, EventArgs e)
        {
            if (usersureField.Text == "")//если поле пустое, то напишем введите имя
                usersureField.Text = "Введите фамилию";
            usersureField.ForeColor = Color.Gray;
        }

        private void LogField_Enter(object sender, EventArgs e)
        {
            if (LogField.Text == "Введите логин")//если текст равен внутри формы введите имя, то будет очистка от текста
            {
                LogField.Text = "";
                LogField.ForeColor = Color.Black;
            }
        }

        private void LogField_Leave(object sender, EventArgs e)
        {
            if (LogField.Text == "")//если поле пустое, то напишем введите имя
                LogField.Text = "Введите логин";
            LogField.ForeColor = Color.Gray;
        }

        private void PassField_Enter(object sender, EventArgs e)
        {
            if (PassField.Text == "Введите пароль")//если текст равен внутри формы введите имя, то будет очистка от текста
            {
                PassField.Text = "";
                PassField.ForeColor = Color.Black;
            }
        }

        private void PassField_Leave(object sender, EventArgs e)
        {
            if (PassField.Text == "")//если поле пустое, то напишем введите имя
                PassField.Text = "Введите пароль";
            PassField.ForeColor = Color.Gray;
        }
        private void registr_btn_Click(object sender, EventArgs e)
        {
            // проверка на ввод всех полей i proverka na dlinu 
            if (usernameField.Text == "Введите имя")
            {
                MessageBox.Show("Введите имя");
                return;
            }
            string imya = usernameField.Text;
            int dlimya = 50;

            if (imya.Length > dlimya)
            {
                MessageBox.Show("Имя слишком длинное");
                imya = imya.Remove(dlimya);
                return;
            }
            //
            if (usersureField.Text == "Введите фамилию")
            {
                MessageBox.Show("Введите фамилию");
                return;
            }
            string fam = usersureField.Text;
            int dlfam = 50;

            if (fam.Length > dlfam)
            {
                MessageBox.Show("Имя слишком длинное");
                fam = fam.Remove(dlfam);
                return;
            }
            //
            if (LogField.Text == "Введите логин")
            {
                MessageBox.Show("Введите логин");
                return;
            }
            string log = LogField.Text;
            int dllog = 35;

            if (log.Length > dllog)
            {
                MessageBox.Show("Имя слишком длинное");
                log = log.Remove(dllog);
                return;
            }
            //
            if (PassField.Text == "Введите пароль")
            {
                MessageBox.Show("Введите пароль");
                return;
            }
            string par = PassField.Text;
            int dlpar = 35;

            if (par.Length > dlpar)
            {
                MessageBox.Show("Имя слишком длинное");
                par = par.Remove(dlpar);
                return;
            }




            if (checkuser())
                return;



            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`, `pass`, `name`, `surname`) VALUES (@login, @pass, @name, @username)", db.GetConnection());

            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = LogField.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = PassField.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = usernameField.Text;
            command.Parameters.Add("@username", MySqlDbType.VarChar).Value = usersureField.Text;
           // command.Parameters.Add("@user_permission", MySqlDbType.VarChar).Value;
            //подключение к бд
            db.openConnection();

            if (command.ExecuteNonQuery() == 1)// если выполнение команды успешно, то создаем акк
                MessageBox.Show("Вы успешно зарегистрировались");
            else
                MessageBox.Show("Такой аккаунт уже существует");


            db.closeConnection();

        }



        //проверка есть ли уже зарегистрированный чел,если да, то не регистрируем
        public Boolean checkuser()
        {
            DB db = new DB();
            //создаем табл
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` where `login`= @ul", db.GetConnection());// выбрать всех пользователь у которых логин такой же как ввел пользователь в регистрации 

            command.Parameters.Add("@ul", MySqlDbType.VarChar).Value = LogField.Text;
            

            // адаптер позволяет нам выбрать данные из бд
            adapter.SelectCommand = command;
            adapter.Fill(table);//данные трансформируем внутрь обекта табл

            if (table.Rows.Count > 0)// если записей больше 0, то будет авторизован
            {
                MessageBox.Show("Такой логин уже есть, введите другой");
                return true;//это возврат если сущ пользователь
            }
            else
                
            return false;//это  если несущ пользователь
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginForm1 loginForm1 = new loginForm1();
            loginForm1.Show();
        }

       
    }
}
