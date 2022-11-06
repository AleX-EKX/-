using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace avtoriz
{
    public partial class MainForm : Form
    {
        
        public MainForm()
        {

            InitializeComponent();

            Labuser.Text = loginForm1.loginuser;
        }


        private void closelabel_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
        
            
               

                
                
    

    private void button1_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` ", db.GetConnection());// выбрать всех пользователь где логин равен тому что ввел пользователь и пароль также
            adapter.SelectCommand = command;
            adapter.Fill(table);//данные трансформируем внутрь обекта табл
            if (table.Rows.Count > 0)
            {
                raspisanie raspr = new raspisanie();
                if (raspr.pn_btn_16.Text == "Занято")
                {
                    raspr.pn_btn_16.Enabled = false;
                    raspr.pn_btn_16.BackColor = Color.Red;
                }
                else
                    raspr.pn_btn_16.BackColor = Color.Lime;
                raspr.pn_btn_16.Enabled = true;

                if (raspr.pn_btn_17.Text == "Занято")
                {
                    raspr.pn_btn_17.Enabled = false;
                    raspr.pn_btn_17.BackColor = Color.Red;
                }
                else
                    raspr.pn_btn_17.BackColor = Color.Lime;
                raspr.pn_btn_17.Enabled = true;
            }
            else
                MessageBox.Show("sfads");

            if (Labuser.Text == "BanyaLox")
            {
                MessageBox.Show("Ты че урод, пошел в жопу УРОД");
                    return;
            }


            db.openConnection();

            var reader = command.ExecuteReader();
            if (reader.Read())
            {
                Loggeduser logUser = new Loggeduser();
                Loggeduser.AccessLevel = (AccessLevel)Convert.ToInt32(reader["user_permission"]);


                if (Loggeduser.AccessLevel == AccessLevel.Granted)
                {

                    //this.Hide();
                    //raspisanie rasp = new raspisanie();
                    //rasp.ShowDialog();
                   // rasp.edit.Visible = true;
                   // this.Show();

                    raspisanie rasp = new raspisanie();
                    rasp.Show();
                    //rasp.edit.Visible = true;
                    rasp.clear.Visible = true;
                    this.Hide();
                    //MessageBox.Show("admin");

                    rasp.FormClosed += showForm;
                }


                else 
                {
                    //this.Hide();
                    //raspisanie rasp = new raspisanie();
                    //rasp.ShowDialog();
                    //rasp.edit.Visible = false;
                    //this.Show();
                    
                    raspisanie rasp = new raspisanie();
                   rasp.Show();
                    //rasp.edit.Visible = false;
                    rasp.clear.Visible = false;
                   this.Hide();
                    //MessageBox.Show("ne admin");
                    //FormState.PreviousPage = this;
                    rasp.FormClosed += showForm;


                }
               

            }

           

            db.closeConnection();
            this.Close();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            Exits Ex = new Exits();
            DialogResult result = Ex.ShowDialog();
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
            lastPoint = new Point(e.X, e.Y);//код для перемещения окна
        }

        private void closelabel_MouseEnter(object sender, EventArgs e)
        {
            closelabel.ForeColor = Color.Red;
        }

        private void closelabel_MouseLeave(object sender, EventArgs e)
        {
            closelabel.ForeColor = Color.White;
        }

        public void Labuser_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            technical_support ts = new technical_support();
            ts.ShowDialog();
            this.Show();
            //this.Hide();
            //ts.FormClosed += showForm;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Hide();
            help help = new help();
            help.ShowDialog();
            
            this.Show();
            
            //help.Show();
            //this.Hide();
            //help.FormClosed += showForm;
        }
        private void showForm(object sender, EventArgs e)
        {
            //this.Show();
            //this.Labuser.Text = Loggeduser.Login;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            registr reg = new registr();
           // reg.ShowDialog();
            reg.Show();
            //this.Hide();
            reg.FormClosed += showForm;
        }
    }
}
