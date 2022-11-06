using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace avtoriz
{
    public partial class help : Form
    {
        public help()
        {
            InitializeComponent();
            label1.Text = "Для того чтобы зарегистрироваться заполните все поля: 'Имя'\r\n 'Фамилия', 'Логин', 'Пароль'";
        }
        int clickeditem = 1;
        private void brat_btn1_Click(object sender, EventArgs e)
        {
            clickeditem--;
            changeSlide(ref clickeditem);
        }

        private void brat_btn2_Click(object sender, EventArgs e)
        {
            clickeditem++;
            changeSlide(ref clickeditem);
        }
        public void changeSlide(ref int num)
        {
                if (num < 1)
                    num = 6;
                else if (num > 6)
                    num = 1;
                Trace.WriteLine(num);
                
            switch (num)
            {
                case 1:
                    pictureBox1.Image = global:: avtoriz.Properties.Resources.регистр1;
                    label1.Text = "Для того чтобы зарегистрироваться заполните все поля: 'Имя'\r\n 'Фамилия', 'Логин', 'Пароль'";
                    break;
                case 2:
                    pictureBox1.Image = global::avtoriz.Properties.Resources.вход1;
                    label1.Text = "Для авторизации введите свои данные (Логин, Пароль), которые\r\n вводили в окне регистрации";
                    break;
                case 3:
                    pictureBox1.Image = global::avtoriz.Properties.Resources.меню1;
                    label1.Text = "Чтобы посмотреть расписание зала выберите пунк 'Расписание', если\r\n у вас возникли какие-либо вопросы может обратиться\r\n в техподдержку, для этого выберите пункт 'Техподдержка'.\r\n Для выхода из приложения выберите пункт 'Выход'";
                    break;
                case 4:
                    pictureBox1.Image = global::avtoriz.Properties.Resources.расп1;
                    label1.Text = "Чтобы забронировать зал, выберите удобное для вас время (свободное)\r\n для перехода в главное меню, выберите пункт 'Главная'";
                    break;
                case 5:
                    pictureBox1.Image = global::avtoriz.Properties.Resources.заяв;
                    label1.Text = "Чтобы забронировать зал  вам нужно заполнить все поля: 'Ваше Имя'\r\n'Ваш Телефон','Ваша Почта'. Далее нажмите 'Отправить' \r\n и ваша заявка будет отправлена. С вами свяжутся по телефону либо\r\n через почту для подтвреждения";
                    break;
                case 6:
                    pictureBox1.Image = global::avtoriz.Properties.Resources.техпод1;
                    label1.Text = "Если у вас возникли какие-либо вопросы, заполните все поля:\r\n 'Ваша почта','опишите проблему', далее нажмите отправить и в течении\r\n 24 часов вам ответят";
                    break;
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exit_MouseEnter(object sender, EventArgs e)
        {
            exit.ForeColor = Color.Red;//при наведение меняет цвет на красный
        }

        private void exit_MouseLeave(object sender, EventArgs e)
        {
            exit.ForeColor = Color.White;//при убирании мыши меняет цвет на белый
        }

        private void brat_btn3_Click(object sender, EventArgs e)
        {
           // MainForm main = new MainForm();
            this.DialogResult = DialogResult.OK;
             //main.Show();
            // main.Labuser.Text = loginuser;
            //this.Close();
        }
        private void showForm(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            this.Show();
            
            main.Labuser.Text = Loggeduser.Login;
        }
        Point lastPoint;
        private void help_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
                //код для перемещения окна
            }
        }

        private void help_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);//код для перемещения
        }
    }
}
