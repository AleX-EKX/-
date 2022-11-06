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
    public partial class loginForm1 : Form
    {

        


        public loginForm1()
        {
            InitializeComponent();
            this.PassField.AutoSize = false;
            this.PassField.Size = new Size(this.PassField.Size.Width, 45);

            LogField.Text = "Введите логин";
            LogField.ForeColor = Color.Gray;
            
        }
        


        private void closelabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void closelabel_MouseEnter(object sender, EventArgs e)
        {
            closelabel.ForeColor = Color.Red;//при наведение меняет цвет на красный
        }

        private void closelabel_MouseLeave(object sender, EventArgs e)
        {
            closelabel.ForeColor = Color.White;//при убирании мыши меняет цвет на белый
        }


        Point lastPoint;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
                //код для перемещения окна
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);//код для перемещения окна
        }

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

       

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            registr registr = new registr();
            registr.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }
        public string getUserName()
        {
            return LogField.Text;
        }
        private void showForm(object sender, EventArgs e)
        {
            this.Show();
            MainForm mainForm = new MainForm();
            mainForm.Labuser.Text = Loggeduser.Login;
        }
        public static string loginuser;
        private void Login_btn_Click(object sender, EventArgs e)
        {
            

            string foo = LogField.Text;
            int trimLength = 35;

            if (foo.Length > trimLength)
            {
                MessageBox.Show("Логин слишком длинный");
                foo = foo.Remove(trimLength);
                return;
            }

            if (LogField.Text == "Введите логин")
            {
                MessageBox.Show("Введите имя");
                return;
            }
            if (PassField.Text == "")
            {
                MessageBox.Show("Введите пароль");
                return;
            }
            loginuser = LogField.Text; //получаем данные от пользователя
            string passuser = PassField.Text;
            DB db = new DB();
            //создаем табл
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` where `login`= @ul AND `pass`= @up", db.GetConnection());// выбрать всех пользователь где логин равен тому что ввел пользователь и пароль также

            command.Parameters.Add("@ul", MySqlDbType.VarChar).Value = loginuser;
            command.Parameters.Add("@up", MySqlDbType.VarChar).Value = passuser;


            // адаптер позволяет нам выбрать данные из бд
            adapter.SelectCommand = command;
            adapter.Fill(table);//данные трансформируем внутрь обекта табл

            if (table.Rows.Count > 0)// если записей больше 0, то будет авторизован
            {
                this.Hide();
                MainForm mainForm = new MainForm();

            }
            else
                MessageBox.Show("Не верно введен логин или пароль");
            // prava dostupa admina
            db.openConnection();

            

            var reader = command.ExecuteReader();

            if (reader.Read())
            {
                
                Loggeduser.AccessLevel = (AccessLevel)Convert.ToInt32(reader["user_permission"]);


                if (Loggeduser.AccessLevel == AccessLevel.Granted)//ур доступа
                {
                    this.Hide();
                    raspisanie rasp = new raspisanie();
                    //rasp.edit.Visible = true;
                    MessageBox.Show("admin");
                    //rasp.ShowDialog();
                    
                    rasp.Show();

                    //raspisanie rasp = new raspisanie();
                    //rasp.Show();
                    //rasp.edit.Visible = true;

                    //this.Hide();
                    
                }
                else
                {
                    this.Hide();
                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                    mainForm.Labuser.Text = loginuser;

                }


            }
           

            db.closeConnection();

            
            
            //Refresh();

            if (LogField.Text.Length > 0)
            {
                this.DialogResult = DialogResult.OK;

                MainForm main = new MainForm();
                

                main.Labuser.Text = loginuser;

            }
            else
            {
                MessageBox.Show("AAAAAA");
            }
            return;

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


    }
}
