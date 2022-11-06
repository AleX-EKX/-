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
    public partial class raspisanie : Form
    {
        public raspisanie()
        {
            InitializeComponent();

            DateTime today = DateTime.Now;
            DateTime answer = today.AddDays(6);
            
            nedelya.Text = DateTime.Now.DayOfWeek.ToString();
            if (nedelya.Text == "Monday")
            {
                label17.Text = "Расписание зала до " + DateTime.Now.AddDays(6).ToString("d");
            }
            if (nedelya.Text == "Tuesday")
            {
                label17.Text = "Расписание зала до " + DateTime.Now.AddDays(5).ToString("d");
            }
            if (nedelya.Text == "Wednesday")
            {
                label17.Text = "Расписание зала до " + DateTime.Now.AddDays(4).ToString("d");
            }
            if (nedelya.Text == "Thursday")
            {
                label17.Text = "Расписание зала до " + DateTime.Now.AddDays(3).ToString("d");
            }
            if (nedelya.Text == "Friday")
            {
                label17.Text = "Расписание зала до " + DateTime.Now.AddDays(2).ToString("d");
            }
            if (nedelya.Text == "Saturday")
            {
                label17.Text = "Расписание зала до " + DateTime.Now.AddDays(1).ToString("d");
            }
            if (nedelya.Text == "Sunday")
            {
                label17.Text = "Расписание зала до " + DateTime.Now.AddDays(0).ToString("d");
            }


        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.Day.ToString("") + "." + DateTime.Now.Month.ToString("00") + "." + DateTime.Now.Year.ToString("00") + "\r\n " + DateTime.Now.Hour.ToString("00") + ":" + DateTime.Now.Minute.ToString("00") + ":" + DateTime.Now.Second.ToString("00");
        }

        private void main_btn_Click(object sender, EventArgs e)
        { 
           // string loginuser = log.LogField.Text; //получаем данные от пользователя  
            DB db = new DB();
            //создаем табл
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` where `login`= @ul", db.GetConnection());// выбрать всех пользователь где логин равен тому что ввел пользователь и пароль также

            command.Parameters.Add("@ul", MySqlDbType.VarChar).Value = loginForm1.loginuser;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            this.DialogResult = DialogResult.OK;
            loginForm1 log = new loginForm1();
            this.Close();
            MainForm main = new MainForm();
            main.Show();

        }

        private  void clear_Click(object sender, EventArgs e)
        {
           // DB db = new DB();
            //создаем табл

            //MySqlCommand command = new MySqlCommand("UPDATE `mail` SET `kod`=''", db.GetConnection());
            //command.Parameters.AddWithValue("@kod", data.vremy);
            this.DialogResult = DialogResult.OK;
            this.Close();
            Clears cle = new Clears();
            cle.Show();
            //await command.ExecuteNonQueryAsync();
        }

        private void raspisanie_Load(object sender, EventArgs e)
        {
            DB bb = new DB();
            //создаем табл
            DataTable tablee = new DataTable();

            MySqlDataAdapter adapterr = new MySqlDataAdapter();

            MySqlCommand commandd = new MySqlCommand("SELECT * FROM `users` ", bb.GetConnection());// выбрать всех пользователь 
            
            adapterr.SelectCommand = commandd;
            adapterr.Fill(tablee);


            bb.openConnection();

            var readerr = commandd.ExecuteReader();
            
                if (readerr.Read())
                {

                    Loggeduser.AccessLevel = (AccessLevel)Convert.ToInt32(readerr["user_permission"]);


                    if (Loggeduser.AccessLevel == AccessLevel.Granted)//ур доступа
                    {
                       // edit.Visible = true;
                        clear.Visible = false;
                    }
                    else
                    {
                        clear.Visible = true;
                    }
                    

                }
            
            bb.closeConnection();

            DB db = new DB();
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `mail` ", db.GetConnection());// 

            command.Parameters.Add("@kod", MySqlDbType.VarChar).Value = data.vremy;
            adapter.SelectCommand = command;
            adapter.Fill(table);//данные трансформируем внутрь обекта табл
           

            db.openConnection();

            var reader = command.ExecuteReader();
            if (reader.HasRows)
            {

                while (reader.Read())
                {
                    
                        data.bron = (bron)Convert.ToInt32(reader["kod"]);

                        if (data.bron == bron.Denied)//ур доступа
                        {
                            this.Show();
                        }

                       
                    
                        for (int i = 0; i < 66; i++)
                    {

                        

                        if (data.bron == bron.ponedelnik16)//ур доступа
                        {
                            
                            pn_btn_16.Enabled = false;
                            pn_btn_16.Text = "Занято";
                            pn_btn_16.BackColor = Color.Red;
                        }

                        if (data.bron == bron.ponedelnik17)
                        {
                            
                            pn_btn_17.Enabled = false;
                            pn_btn_17.Text = "Занято";
                            pn_btn_17.BackColor = Color.Red;
                        }
                        if (data.bron == bron.ponedelnik18)
                        {
                            
                            pn_btn_18.Enabled = false;
                            pn_btn_18.Text = "Занято";
                            pn_btn_18.BackColor = Color.Red;
                        }
                        if (data.bron == bron.ponedelnik19)
                        {

                            pn_btn_19.Enabled = false;
                            pn_btn_19.Text = "Занято";
                            pn_btn_19.BackColor = Color.Red;
                        }
                        if (data.bron == bron.ponedelnik20)
                        {

                            pn_btn_20.Enabled = false;
                            pn_btn_20.Text = "Занято";
                            pn_btn_20.BackColor = Color.Red;
                        }
                        if (data.bron == bron.ponedelnik21)
                        {

                            pn_btn_21.Enabled = false;
                            pn_btn_21.Text = "Занято";
                            pn_btn_21.BackColor = Color.Red;
                        }
                        if (data.bron == bron.ponedelnik22)
                        {

                            pn_btn_22.Enabled = false;
                            pn_btn_22.Text = "Занято";
                            pn_btn_22.BackColor = Color.Red;
                        }
                        if (data.bron == bron.vtornik16)
                        {

                            vt_btn_16.Enabled = false;
                            vt_btn_16.Text = "Занято";
                            vt_btn_16.BackColor = Color.Red;
                        }
                        if (data.bron == bron.vtornik17)
                        {

                            vt_btn_17.Enabled = false;
                            vt_btn_17.Text = "Занято";
                            vt_btn_17.BackColor = Color.Red;
                        }
                        if (data.bron == bron.vtornik18)
                        {

                            vt_btn_18.Enabled = false;
                            vt_btn_18.Text = "Занято";
                            vt_btn_18.BackColor = Color.Red;
                        }
                        if (data.bron == bron.vtornik19)
                        {

                            vt_btn_19.Enabled = false;
                            vt_btn_19.Text = "Занято";
                            vt_btn_19.BackColor = Color.Red;
                        }
                        if (data.bron == bron.vtornik20)
                        {

                            vt_btn_20.Enabled = false;
                            vt_btn_20.Text = "Занято";
                            vt_btn_20.BackColor = Color.Red;
                        }
                        if (data.bron == bron.vtornik21)
                        {

                            vt_btn_21.Enabled = false;
                            vt_btn_21.Text = "Занято";
                            vt_btn_21.BackColor = Color.Red;
                        }
                        if (data.bron == bron.vtornik22)
                        {

                            vt_btn_22.Enabled = false;
                            vt_btn_22.Text = "Занято";
                            vt_btn_22.BackColor = Color.Red;
                        }
                        if (data.bron == bron.creda16)
                        {

                            cr_btn_16.Enabled = false;
                            cr_btn_16.Text = "Занято";
                            cr_btn_16.BackColor = Color.Red;
                        }
                        if (data.bron == bron.creda17)
                        {

                            cr_btn_17.Enabled = false;
                            cr_btn_17.Text = "Занято";
                            cr_btn_17.BackColor = Color.Red;
                        }
                        if (data.bron == bron.creda18)
                        {

                            cr_btn_18.Enabled = false;
                            cr_btn_18.Text = "Занято";
                            cr_btn_18.BackColor = Color.Red;
                        }
                        if (data.bron == bron.creda19)
                        {

                            cr_btn_19.Enabled = false;
                            cr_btn_19.Text = "Занято";
                            cr_btn_19.BackColor = Color.Red;
                        }
                        if (data.bron == bron.creda20)
                        {

                            cr_btn_20.Enabled = false;
                            cr_btn_20.Text = "Занято";
                            cr_btn_20.BackColor = Color.Red;
                        }
                        if (data.bron == bron.creda21)
                        {

                            cr_btn_21.Enabled = false;
                            cr_btn_21.Text = "Занято";
                            cr_btn_21.BackColor = Color.Red;
                        }
                        if (data.bron == bron.creda22)
                        {

                            cr_btn_22.Enabled = false;
                            cr_btn_22.Text = "Занято";
                            cr_btn_22.BackColor = Color.Red;
                        }
                        if (data.bron == bron.chetverg16)
                        {

                            cht_btn_16.Enabled = false;
                            cht_btn_16.Text = "Занято";
                            cht_btn_16.BackColor = Color.Red;
                        }
                        if (data.bron == bron.chetverg17)
                        {

                            cht_btn_17.Enabled = false;
                            cht_btn_17.Text = "Занято";
                            cht_btn_17.BackColor = Color.Red;
                        }
                        if (data.bron == bron.chetverg18)
                        {

                            cht_btn_18.Enabled = false;
                            cht_btn_18.Text = "Занято";
                            cht_btn_18.BackColor = Color.Red;
                        }
                        if (data.bron == bron.chetverg19)
                        {

                            cht_btn_19.Enabled = false;
                            cht_btn_19.Text = "Занято";
                            cht_btn_19.BackColor = Color.Red;
                        }
                        if (data.bron == bron.chetverg20)
                        {

                            cht_btn_20.Enabled = false;
                            cht_btn_20.Text = "Занято";
                            cht_btn_20.BackColor = Color.Red;
                        }
                        if (data.bron == bron.chetverg21)
                        {

                            cht_btn_21.Enabled = false;
                            cht_btn_21.Text = "Занято";
                            cht_btn_21.BackColor = Color.Red;
                        }
                        if (data.bron == bron.chetverg22)
                        {

                            cht_btn_22.Enabled = false;
                            cht_btn_22.Text = "Занято";
                            cht_btn_22.BackColor = Color.Red;
                        }
                        if (data.bron == bron.pyatnitsa16)
                        {

                            pt_btn_16.Enabled = false;
                            pt_btn_16.Text = "Занято";
                            pt_btn_16.BackColor = Color.Red;
                        }
                        if (data.bron == bron.pyatnitsa17)
                        {

                            pt_btn_17.Enabled = false;
                            pt_btn_17.Text = "Занято";
                            pt_btn_17.BackColor = Color.Red;
                        }
                        if (data.bron == bron.pyatnitsa18)
                        {

                            pt_btn_18.Enabled = false;
                            pt_btn_18.Text = "Занято";
                            pt_btn_18.BackColor = Color.Red;
                        }
                        if (data.bron == bron.pyatnitsa19)
                        {

                            pt_btn_19.Enabled = false;
                            pt_btn_19.Text = "Занято";
                            pt_btn_19.BackColor = Color.Red;
                        }
                        if (data.bron == bron.pyatnitsa20)
                        {

                            pt_btn_20.Enabled = false;
                            pt_btn_20.Text = "Занято";
                            pt_btn_20.BackColor = Color.Red;
                        }
                        if (data.bron == bron.pyatnitsa21)
                        {

                            pt_btn_21.Enabled = false;
                            pt_btn_21.Text = "Занято";
                            pt_btn_21.BackColor = Color.Red;
                        }
                        if (data.bron == bron.pyatnitsa22)
                        {

                            pt_btn_22.Enabled = false;
                            pt_btn_22.Text = "Занято";
                            pt_btn_22.BackColor = Color.Red;
                        }
                        if (data.bron == bron.subbota8)
                        {

                            sb_btn_8.Enabled = false;
                            sb_btn_8.Text = "Занято";
                            sb_btn_8.BackColor = Color.Red;
                        }

                        if (data.bron == bron.subbota9)
                        {

                            sb_btn_9.Enabled = false;
                            sb_btn_9.Text = "Занято";
                            sb_btn_9.BackColor = Color.Red;
                        }
                        if (data.bron == bron.subbota10)
                        {

                            sb_btn_10.Enabled = false;
                            sb_btn_10.Text = "Занято";
                            sb_btn_10.BackColor = Color.Red;
                        }
                        if (data.bron == bron.subbota11)
                        {

                            sb_btn_11.Enabled = false;
                            sb_btn_11.Text = "Занято";
                            sb_btn_11.BackColor = Color.Red;
                        }
                        if (data.bron == bron.subbota12)
                        {

                            sb_btn_12.Enabled = false;
                            sb_btn_12.Text = "Занято";
                            sb_btn_12.BackColor = Color.Red;
                        }
                        if (data.bron == bron.subbota13)
                        {

                            sb_btn_13.Enabled = false;
                            sb_btn_13.Text = "Занято";
                            sb_btn_13.BackColor = Color.Red;
                        }
                        if (data.bron == bron.subbota14)
                        {

                            sb_btn_14.Enabled = false;
                            sb_btn_14.Text = "Занято";
                            sb_btn_14.BackColor = Color.Red;
                        }
                        if (data.bron == bron.subbota15)
                        {

                            sb_btn_15.Enabled = false;
                            sb_btn_15.Text = "Занято";
                            sb_btn_15.BackColor = Color.Red;
                        }
                        if (data.bron == bron.subbota16)
                        {

                            sb_btn_16.Enabled = false;
                            sb_btn_16.Text = "Занято";
                            sb_btn_16.BackColor = Color.Red;
                        }
                        if (data.bron == bron.subbota17)
                        {

                            sb_btn_17.Enabled = false;
                            sb_btn_17.Text = "Занято";
                            sb_btn_17.BackColor = Color.Red;
                        }
                        if (data.bron == bron.subbota18)
                        {

                            sb_btn_18.Enabled = false;
                            sb_btn_18.Text = "Занято";
                            sb_btn_18.BackColor = Color.Red;
                        }
                        if (data.bron == bron.subbota19)
                        {

                            sb_btn_19.Enabled = false;
                            sb_btn_19.Text = "Занято";
                            sb_btn_19.BackColor = Color.Red;
                        }
                        if (data.bron == bron.subbota20)
                        {

                            sb_btn_20.Enabled = false;
                            sb_btn_20.Text = "Занято";
                            sb_btn_20.BackColor = Color.Red;
                        }
                        if (data.bron == bron.subbota21)
                        {

                            sb_btn_21.Enabled = false;
                            sb_btn_21.Text = "Занято";
                            sb_btn_21.BackColor = Color.Red;
                        }
                        if (data.bron == bron.subbota22)
                        {

                            sb_btn_22.Enabled = false;
                            sb_btn_22.Text = "Занято";
                            sb_btn_22.BackColor = Color.Red;
                        }
                        if (data.bron == bron.voskresene8)
                        {

                            vs_btn_8.Enabled = false;
                            vs_btn_8.Text = "Занято";
                            vs_btn_8.BackColor = Color.Red;
                        }
                        if (data.bron == bron.voskresene9)
                        {
                            vs_btn_9.Enabled = false;
                            vs_btn_9.Text = "Занято";
                            vs_btn_9.BackColor = Color.Red;
                        }
                        if (data.bron == bron.voskresene10)
                        {

                            vs_btn_10.Enabled = false;
                            vs_btn_10.Text = "Занято";
                            vs_btn_10.BackColor = Color.Red;
                        }
                        if (data.bron == bron.voskresene11)
                        {

                            vs_btn_11.Enabled = false;
                            vs_btn_11.Text = "Занято";
                            vs_btn_11.BackColor = Color.Red;
                        }
                        if (data.bron == bron.voskresene12)
                        {

                            vs_btn_12.Enabled = false;
                            vs_btn_12.Text = "Занято";
                            vs_btn_12.BackColor = Color.Red;
                        }
                        if (data.bron == bron.voskresene13)
                        {

                            vs_btn_13.Enabled = false;
                            vs_btn_13.Text = "Занято";
                            vs_btn_13.BackColor = Color.Red;
                        }
                        if (data.bron == bron.voskresene14)
                        {

                            vs_btn_14.Enabled = false;
                            vs_btn_14.Text = "Занято";
                            vs_btn_14.BackColor = Color.Red;
                        }
                        if (data.bron == bron.voskresene15)
                        {

                            vs_btn_15.Enabled = false;
                            vs_btn_15.Text = "Занято";
                            vs_btn_15.BackColor = Color.Red;
                        }
                        if (data.bron == bron.voskresene16)
                        {

                            vs_btn_16.Enabled = false;
                            vs_btn_16.Text = "Занято";
                            vs_btn_16.BackColor = Color.Red;
                        }
                        if (data.bron == bron.voskresene17)
                        {

                            vs_btn_17.Enabled = false;
                            vs_btn_17.Text = "Занято";
                            vs_btn_17.BackColor = Color.Red;
                        }
                        if (data.bron == bron.voskresene18)
                        {

                            vs_btn_18.Enabled = false;
                            vs_btn_18.Text = "Занято";
                            vs_btn_18.BackColor = Color.Red;
                        }
                        if (data.bron == bron.voskresene19)
                        {

                            vs_btn_19.Enabled = false;
                            vs_btn_19.Text = "Занято";
                            vs_btn_19.BackColor = Color.Red;
                        }
                        if (data.bron == bron.voskresene20)
                        {

                            vs_btn_20.Enabled = false;
                            vs_btn_20.Text = "Занято";
                            vs_btn_20.BackColor = Color.Red;
                        }
                        if (data.bron == bron.voskresene21)
                        {

                            vs_btn_21.Enabled = false;
                            vs_btn_21.Text = "Занято";
                            vs_btn_21.BackColor = Color.Red;
                        }
                        if (data.bron == bron.voskresene22)
                        {
                            
                            vs_btn_22.Enabled = false;
                            vs_btn_22.Text = "Занято";
                            vs_btn_22.BackColor = Color.Red;
                        }
                        break;
                    }

                    

                }
                
            }
            db.closeConnection();
        }


        Point lastPoint;
        private void raspisanie_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
                //код для перемещения окна
            }
        }

        private void raspisanie_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);//код для перемещения
        }

        private void main_btn_MouseLeave(object sender, EventArgs e)
        {
            //main_btn.ForeColor = Color.White;
        }

        private void main_btn_MouseEnter(object sender, EventArgs e)
        {
            //main_btn.ForeColor = Color.LightSkyBlue;
        }
        private void okras(object sender, EventArgs e)
        {
            


        }
        private void pn_lab_MouseEnter(object sender, EventArgs e)
        {
            Button[] bt = new Button[] { pn_btn_16, pn_btn_17, pn_btn_18, pn_btn_19, pn_btn_20, pn_btn_21, pn_btn_22 };
            foreach (Button i in bt)
            {
                if (i.Text == "Занято")
                {
                    i.Enabled = false;
                    i.BackColor = Color.Red;
                }
                else
                {
                    i.BackColor = Color.Lime;
                    i.Enabled = true;
                }
            }

        }

        private void pn_lab_MouseLeave(object sender, EventArgs e)
        {
            Button[] bt = new Button[] { pn_btn_16, pn_btn_17, pn_btn_18, pn_btn_19, pn_btn_20, pn_btn_21, pn_btn_22 };
            foreach (Button i in bt)
            {
                if (i.Text == "Занято")
                {
                    i.Enabled = false;
                    i.BackColor = Color.Red;
                }
                else
                {
                    i.BackColor = Color.Transparent;
                    i.Enabled = true;
                }
            }
        }

        private void vt_lab_MouseEnter(object sender, EventArgs e)
        {
            Button[] bt = new Button[] { vt_btn_16, vt_btn_17, vt_btn_18, vt_btn_19, vt_btn_20, vt_btn_21, vt_btn_22 };
            foreach (Button i in bt)
            {
                if (i.Text == "Занято")
                {
                    i.Enabled = false;
                    i.BackColor = Color.Red;
                }
                else
                {
                    i.BackColor = Color.Lime;
                    i.Enabled = true;
                }

            }
        }

        private void vt_lab_MouseLeave(object sender, EventArgs e)
        {
            Button[] bt = new Button[] { vt_btn_16, vt_btn_17, vt_btn_18, vt_btn_19, vt_btn_20, vt_btn_21, vt_btn_22 };
            foreach (Button i in bt)
            {
                if (i.Text == "Занято")
                {
                    i.Enabled = false;
                    i.BackColor = Color.Red;
                }
                else
                {
                    i.BackColor = Color.Transparent;
                    i.Enabled = true;
                }
            }
        }

        private void sr_lab_MouseEnter(object sender, EventArgs e)
        {
            Button[] bt = new Button[] { cr_btn_16, cr_btn_17, cr_btn_18, cr_btn_19, cr_btn_20, cr_btn_21, cr_btn_22 };
            foreach (Button i in bt)
            {
                if (i.Text == "Занято")
                {
                    i.Enabled = false;
                    i.BackColor = Color.Red;
                }
                else
                {
                    i.BackColor = Color.Lime;
                    i.Enabled = true;
                }
            }
        }

        private void sr_lab_MouseLeave(object sender, EventArgs e)
        {
            Button[] bt = new Button[] { cr_btn_16, cr_btn_17, cr_btn_18, cr_btn_19, cr_btn_20, cr_btn_21, cr_btn_22 };
            foreach (Button i in bt)
            {
                if (i.Text == "Занято")
                {
                    i.Enabled = false;
                    i.BackColor = Color.Red;
                }
                else
                {
                    i.BackColor = Color.Transparent;
                    i.Enabled = true;
                }
            }
        }

        private void cht_lab_MouseEnter(object sender, EventArgs e)
        {
            Button[] bt = new Button[] { cht_btn_16, cht_btn_17, cht_btn_18, cht_btn_19, cht_btn_20, cht_btn_21, cht_btn_22 };
            foreach (Button i in bt)
            {
                if (i.Text == "Занято")
                {
                    i.Enabled = false;
                    i.BackColor = Color.Red;
                }
                else
                {
                    i.BackColor = Color.Lime;
                    i.Enabled = true;
                }
            }
        }

        private void cht_lab_MouseLeave(object sender, EventArgs e)
        {
            Button[] bt = new Button[] { cht_btn_16, cht_btn_17, cht_btn_18, cht_btn_19, cht_btn_20, cht_btn_21, cht_btn_22 };
            foreach (Button i in bt)
            {
                if (i.Text == "Занято")
                {
                    i.Enabled = false;
                    i.BackColor = Color.Red;
                }
                else
                {
                    i.BackColor = Color.Transparent;
                    i.Enabled = true;
                }
            }
        }

        private void pt_lab_MouseEnter(object sender, EventArgs e)
        {
            Button[] bt = new Button[] { pt_btn_16, pt_btn_17, pt_btn_18, pt_btn_19, pt_btn_20, pt_btn_21, pt_btn_22 };
            foreach (Button i in bt)
            {
                if (i.Text == "Занято")
                {
                    i.Enabled = false;
                    i.BackColor = Color.Red;
                }
                else
                {
                    i.BackColor = Color.Lime;
                    i.Enabled = true;
                }
            }
        }

        private void pt_lab_MouseLeave(object sender, EventArgs e)
        {
            Button[] bt = new Button[] { pt_btn_16, pt_btn_17, pt_btn_18, pt_btn_19, pt_btn_20, pt_btn_21, pt_btn_22 };
            foreach (Button i in bt)
            {
                if (i.Text == "Занято")
                {
                    i.Enabled = false;
                    i.BackColor = Color.Red;
                }
                else
                {
                    i.BackColor = Color.Transparent;
                    i.Enabled = true;
                }
            }
        }

        private void sb_lab_MouseEnter(object sender, EventArgs e)
        {
            Button[] bt = new Button[] { sb_btn_8, sb_btn_9, sb_btn_10, sb_btn_11, sb_btn_12, sb_btn_13, sb_btn_14, sb_btn_15, sb_btn_16, sb_btn_17, sb_btn_18, sb_btn_19, sb_btn_20, sb_btn_21, sb_btn_22 };
            foreach (Button i in bt)
            {
                if (i.Text == "Занято")
                {
                    i.Enabled = false;
                    i.BackColor = Color.Red;
                }
                else
                {
                    i.BackColor = Color.Tomato;
                    i.Enabled = true;
                }
            }
        }

        private void sb_lab_MouseLeave(object sender, EventArgs e)
        {
            Button[] bt = new Button[] { sb_btn_8, sb_btn_9, sb_btn_10, sb_btn_11, sb_btn_12, sb_btn_13, sb_btn_14, sb_btn_15, sb_btn_16, sb_btn_17, sb_btn_18, sb_btn_19, sb_btn_20, sb_btn_21, sb_btn_22 };
            foreach (Button i in bt)
            {
                if (i.Text == "Занято")
                {
                    i.Enabled = false;
                    i.BackColor = Color.Red;
                }
                else
                {
                    i.BackColor = Color.Transparent;
                    i.Enabled = true;
                }
            }
        }

        private void vs_lab_MouseEnter(object sender, EventArgs e)
        {
            Button[] bt = new Button[] { vs_btn_8, vs_btn_9, vs_btn_10, vs_btn_11, vs_btn_12, vs_btn_13, vs_btn_14, vs_btn_15, vs_btn_16, vs_btn_17, vs_btn_18, vs_btn_19, vs_btn_20, vs_btn_21, vs_btn_22 };
            foreach (Button i in bt)
            {
                if (i.Text == "Занято")
                {
                    i.Enabled = false;
                    i.BackColor = Color.Red;
                }
                else
                {
                    i.BackColor = Color.Tomato;
                    i.Enabled = true;
                }
            }
        }

        private void vs_lab_MouseLeave(object sender, EventArgs e)
        {
            Button[] bt = new Button[] { vs_btn_8, vs_btn_9, vs_btn_10, vs_btn_11, vs_btn_12, vs_btn_13, vs_btn_14, vs_btn_15, vs_btn_16, vs_btn_17, vs_btn_18, vs_btn_19, vs_btn_20, vs_btn_21, vs_btn_22 };
            foreach (Button i in bt)
            {
                if (i.Text == "Занято")
                {
                    i.Enabled = false;
                    i.BackColor = Color.Red;
                }
                else
                {
                    i.BackColor = Color.Transparent;
                    i.Enabled = true;
                }
            }

        }
        //нажатие др форма показ (Суббота)

        application apl = new application();
        private void vse(object sender, EventArgs e)
        {
            //EventHandler[] bt = new EventHandler[] { pn_btn_17_Click};
            
                if (zareg())
                    return;
            bool[] pn = {data.pn16, data.pn17, data.pn18, data.pn19, data.pn20, data.pn21, data.pn22,
                data.vt16, data.vt17, data.vt18, data.vt19, data.vt20, data.vt21, data.vt22,
                data.cr16, data.cr17, data.cr18, data.cr19, data.cr20, data.cr21, data.cr22,
                data.cht16,data.cht17,data.cht18,data.cht19,data.cht20,data.cht21,data.cht22,
                data.pt16, data.pt17, data.pt18, data.pt19, data.pt20, data.pt21, data.pt22,
                data.sb8, data.sb9, data.sb10, data.sb11,data.sb12,data.sb13, data.sb14,data.sb15,data.sb16,data.sb17,data.sb18,data.sb19,data.sb20,data.sb21,data.sb22,
                data.vs8, data.vs9, data.vs10, data.vs11,data.vs12,data.vs13, data.vs14,data.vs15,data.vs16,data.vs17,data.vs18,data.vs19,data.vs20,data.vs21,data.vs22};
            foreach (bool i in pn)
            {
                if (i == true)
                {
                    this.DialogResult = DialogResult.OK;
                    apl.Show();


                    if (i == data.sb8 || data.sb9 || data.sb10 || data.sb11 || data.sb12 || data.sb13 || data.vs8 || data.vs9 || data.vs10 || data.vs11 || data.vs12 || data.vs13 == true)
                    {
                        for (int a = 0; a < pn.Length; a++)
                        {
                            pn[a] = false;
                            apl.cena.Text = "300 рублей";
                        }
                        // снова делаю то что я не нажимал
                        /*int[] f = Enumerable.Range(Convert.ToInt32(data.sb8), Convert.ToInt32(data.sb11)).ToArray();*/ //диапозон                                   
                    }
                    else
                    {
                        apl.cena.Text = "400 рублей";
                    }
                    this.Hide();
                    return;
                }
            }
           /* if (2==0)
                {
                    
                    this.DialogResult = DialogResult.OK;
                    application apl = new application();
                    
                }*/
  
        }
        

        private void pn_btn_16_Click(object sender, EventArgs e)
        {
            if (zareg())
                return;
            this.DialogResult = DialogResult.OK;     
            apl.Show();
            apl.chislo.Text = "Понедельник 16:30";
            apl.cena.Text = "400 рублей";
            Program.per_id_bt = "pn_btn_16";
            data.vremy = "1";
            this.Hide();
        }

        private void pn_btn_17_Click(object sender, EventArgs e)
        {
            apl.Show();
            apl.chislo.Text = "Понедельник 17:30";
            apl.cena.Text = "400 рублей";
            Program.per_id_bt = "pn_btn_17";
            data.vremy = "2";
            this.Hide();
        }

        private void pn_btn_18_Click(object sender, EventArgs e)
        {
            if (zareg())
                return;
            this.DialogResult = DialogResult.OK;         
            apl.Show();
            apl.chislo.Text = "Понедельник 18:30";
            apl.cena.Text = "400 рублей";
            Program.per_id_bt = "pn_btn_18";
            data.vremy = "3";
            this.Hide();
        }

        private void pn_btn_19_Click(object sender, EventArgs e)
        {
            if (zareg())
                return;
            this.DialogResult = DialogResult.OK;           
            apl.Show();
            apl.chislo.Text = "Понедельник 19:30";
            apl.cena.Text = "400 рублей";
            Program.per_id_bt = "pn_btn_19";
            data.vremy = "4";
            this.Hide();
        }

        private void pn_btn_20_Click(object sender, EventArgs e)
        {
            if (zareg())
                return;
            this.DialogResult = DialogResult.OK;   
            apl.Show();
            apl.chislo.Text = "Понедельник 20:30";
            apl.cena.Text = "400 рублей";
            Program.per_id_bt = "pn_btn_20";
            data.vremy = "5";
            this.Hide();
        }

        private void pn_btn_21_Click(object sender, EventArgs e)
        {
            if (zareg())
                return;
            this.DialogResult = DialogResult.OK;
            apl.Show();
            apl.chislo.Text = "Понедельник 21:30";
            apl.cena.Text = "400 рублей";
            Program.per_id_bt = "pn_btn_21";
            data.vremy = "6";
            this.Hide();
        }

        private void pn_btn_22_Click(object sender, EventArgs e)
        {
            if (zareg())
                return;
            this.DialogResult = DialogResult.OK;
            apl.Show();
            apl.chislo.Text = "Понедельник 22:30";
            apl.cena.Text = "400 рублей";
            Program.per_id_bt = "pn_btn_22";
            data.vremy = "7";
            this.Hide();
        }

        private void vt_btn_16_Click(object sender, EventArgs e)
        {

            //this.Hide();
            //
            //apl.chislo.Text = "Вторник 16:30";
            //apl.cena.Text = "400 рублей";
            //Program.per_id_bt = "vt_btn_16";
            //apl.ShowDialog();
            //this.Show();

            if (zareg())
                return;
            this.DialogResult = DialogResult.OK;
            apl.Show();
            apl.chislo.Text = "Вторник 16:30";
            apl.cena.Text = "400 рублей";
            Program.per_id_bt = "vt_btn_16";
            data.vremy = "8";
            this.Hide();
        }

        private void vt_btn_17_Click(object sender, EventArgs e)
        {
            if (zareg())
                return;
            this.DialogResult = DialogResult.OK; 
            apl.Show();
            apl.chislo.Text = "Вторник 17:30";
            apl.cena.Text = "400 рублей";
            Program.per_id_bt = "vt_btn_17";
            data.vremy = "9";
            this.Hide();
        }

        private void vt_btn_18_Click(object sender, EventArgs e)
        {
            if (zareg())
                return;
            this.DialogResult = DialogResult.OK;
            apl.Show();
            apl.chislo.Text = "Вторник 18:30";
            apl.cena.Text = "400 рублей";
            Program.per_id_bt = "vt_btn_18";
            data.vremy = "10";
            this.Hide();
        }

        private void vt_btn_19_Click(object sender, EventArgs e)
        {
            if (zareg())
                return;
            this.DialogResult = DialogResult.OK;
            this.Show();
            apl.chislo.Text = "Вторник 19:30";
            apl.cena.Text = "400 рублей";
            Program.per_id_bt = "vt_btn_19";
            data.vremy = "11";
            this.Hide();
        }

        private void vt_btn_20_Click(object sender, EventArgs e)
        {
            if (zareg())
                return;
            this.DialogResult = DialogResult.OK; 
            apl.Show();
            apl.chislo.Text = "Вторник 20:30";
            apl.cena.Text = "400 рублей";
            Program.per_id_bt = "vt_btn_20";
            data.vremy = "12";
            this.Hide();
        }

        private void vt_btn_21_Click(object sender, EventArgs e)
        {
            if (zareg())
                return;
            this.DialogResult = DialogResult.OK;        
            apl.Show();
            apl.chislo.Text = "Вторник 21:30";
            apl.cena.Text = "400 рублей";
            Program.per_id_bt = "vt_btn_21";
            data.vremy = "13";
            this.Hide();
        }

        private void vt_btn_22_Click(object sender, EventArgs e)
        {
            if (zareg())
                return;
            this.DialogResult = DialogResult.OK;           
            apl.Show();
            apl.chislo.Text = "Вторник 22:30";
            apl.cena.Text = "400 рублей";
            Program.per_id_bt = "vt_btn_22";
            data.vremy = "14";
            this.Hide();
        }

        private void cr_btn_16_Click(object sender, EventArgs e)
        {
            if (zareg())
                return;
            this.DialogResult = DialogResult.OK;            
            apl.Show();
            apl.chislo.Text = "Среда 16:30";
            apl.cena.Text = "400 рублей";
            Program.per_id_bt = "cr_btn_16";
            data.vremy = "15";
            this.Hide();
        }

        private void cr_btn_17_Click(object sender, EventArgs e)
        {
            if (zareg())
                return;
            this.DialogResult = DialogResult.OK;           
            apl.Show();
            apl.chislo.Text = "Среда 17:30";
            apl.cena.Text = "400 рублей";
            Program.per_id_bt = "cr_btn_17";
            data.vremy = "16";
            this.Hide();
        }

        private void cr_btn_18_Click(object sender, EventArgs e)
        {
            if (zareg())
                return;
            this.DialogResult = DialogResult.OK;            
            apl.Show();
            apl.chislo.Text = "Среда 18:30";
            apl.cena.Text = "400 рублей";
            Program.per_id_bt = "cr_btn_18";
            data.vremy = "17";
            this.Hide();
        }

        private void cr_btn_19_Click(object sender, EventArgs e)
        {
            if (zareg())
                return;
            this.DialogResult = DialogResult.OK;            
            apl.Show();
            apl.chislo.Text = "Среда 19:30";
            apl.cena.Text = "400 рублей";
            Program.per_id_bt = "cr_btn_19";
            data.vremy = "18";
            this.Hide();
        }

        private void cr_btn_20_Click(object sender, EventArgs e)
        {
            if (zareg())
                return;
            this.DialogResult = DialogResult.OK;           
            apl.Show();
            apl.chislo.Text = "Среда 20:30";
            apl.cena.Text = "400 рублей";
            Program.per_id_bt = "cr_btn_20";
            data.vremy = "19";
            this.Hide();
        }

        private void cr_btn_21_Click(object sender, EventArgs e)
        {
            if (zareg())
                return;
            this.DialogResult = DialogResult.OK;           
            apl.Show();
            apl.chislo.Text = "Среда 21:30";
            apl.cena.Text = "400 рублей";
            Program.per_id_bt = "cr_btn_21";
            data.vremy = "20";
            this.Hide();
        }

        private void cr_btn_22_Click(object sender, EventArgs e)
        {
            if (zareg())
                return;
            this.DialogResult = DialogResult.OK;           
            apl.Show();
            apl.chislo.Text = "Среда 22:30";
            apl.cena.Text = "400 рублей";
            Program.per_id_bt = "cr_btn_22";
            data.vremy = "21";
            this.Hide();
        }

        private void cht_btn_16_Click(object sender, EventArgs e)
        {
            if (zareg())
                return;
            this.DialogResult = DialogResult.OK;            
            apl.Show();
            apl.chislo.Text = "Четверг 16:30";
            apl.cena.Text = "400 рублей";
            Program.per_id_bt = "cht_btn_16";
            data.vremy = "22";
            this.Hide();
        }

        private void cht_btn_17_Click(object sender, EventArgs e)
        {
            if (zareg())
                return;
            this.DialogResult = DialogResult.OK;           
            apl.Show();
            apl.chislo.Text = "Четверг 17:30";
            apl.cena.Text = "400 рублей";
            Program.per_id_bt = "cht_btn_17";
            data.vremy = "23";
            this.Hide();
        }

        private void cht_btn_18_Click(object sender, EventArgs e)
        {
            if (zareg())
                return;
            this.DialogResult = DialogResult.OK;           
            apl.Show();
            apl.chislo.Text = "Четверг 18:30";
            apl.cena.Text = "400 рублей";
            Program.per_id_bt = "cht_btn_18";
            data.vremy = "24";
            this.Hide();
        }

        private void cht_btn_19_Click(object sender, EventArgs e)
        {
            if (zareg())
                return;
            this.DialogResult = DialogResult.OK;           
            apl.Show();
            apl.chislo.Text = "Четверг 19:30";
            apl.cena.Text = "400 рублей";
            Program.per_id_bt = "cht_btn_19";
            data.vremy = "25";
            this.Hide();
        }

        private void cht_btn_20_Click(object sender, EventArgs e)
        {
            if (zareg())
                return;
            this.DialogResult = DialogResult.OK;          
            apl.Show();
            apl.chislo.Text = "Четверг 20:30";
            apl.cena.Text = "400 рублей";
            Program.per_id_bt = "cht_btn_20";
            data.vremy = "26";
            this.Hide();
        }

        private void cht_btn_21_Click(object sender, EventArgs e)
        {
            if (zareg())
                return;
            this.DialogResult = DialogResult.OK;           
            apl.Show();
            apl.chislo.Text = "Четверг 21:30";
            apl.cena.Text = "400 рублей";
            Program.per_id_bt = "cht_btn_21";
            data.vremy = "27";
            this.Hide();
        }

        private void cht_btn_22_Click(object sender, EventArgs e)
        {
            if (zareg())
                return;
            this.DialogResult = DialogResult.OK;           
            apl.Show();
            apl.chislo.Text = "Четверг 22:30";
            apl.cena.Text = "400 рублей";
            Program.per_id_bt = "cht_btn_22";
            data.vremy = "28";
            this.Hide();
        }

        private void pt_btn_16_Click(object sender, EventArgs e)
        {
            if (zareg())
                return;
            this.DialogResult = DialogResult.OK;           
            apl.Show();
            apl.chislo.Text = "Пятница 16:30";
            apl.cena.Text = "400 рублей";
            Program.per_id_bt = "pt_btn_16";
            data.vremy = "29";
            this.Hide();
        }

        private void pt_btn_17_Click(object sender, EventArgs e)
        {
            if (zareg())
                return;
            this.DialogResult = DialogResult.OK;           
            apl.Show();
            apl.chislo.Text = "Пятница 17:30";
            apl.cena.Text = "400 рублей";
            Program.per_id_bt = "pt_btn_17";
            data.vremy = "30";
            this.Hide();
        }

        private void pt_btn_18_Click(object sender, EventArgs e)
        {
            if (zareg())
                return;
            this.DialogResult = DialogResult.OK;           
            apl.Show();
            apl.chislo.Text = "Пятница 18:30";
            apl.cena.Text = "400 рублей";
            Program.per_id_bt = "pt_btn_18";
            data.vremy = "31";
            this.Hide();
        }

        private void pt_btn_19_Click(object sender, EventArgs e)
        {
            if (zareg())
                return;
            this.DialogResult = DialogResult.OK;          
            apl.Show();
            apl.chislo.Text = "Пятница 19:30";
            apl.cena.Text = "400 рублей";
            Program.per_id_bt = "pt_btn_19";
            data.vremy = "32";
            this.Hide();
        }

        private void pt_btn_20_Click(object sender, EventArgs e)
        {
            if (zareg())
                return;
            this.DialogResult = DialogResult.OK;           
            apl.Show();
            apl.chislo.Text = "Пятница 20:30";
            apl.cena.Text = "400 рублей";
            Program.per_id_bt = "pt_btn_20";
            data.vremy = "33";
            this.Hide();
        }

        private void pt_btn_21_Click(object sender, EventArgs e)
        {
            if (zareg())
                return;
            this.DialogResult = DialogResult.OK;           
            apl.Show();
            apl.chislo.Text = "Пятница 21:30";
            apl.cena.Text = "400 рублей";
            Program.per_id_bt = "pt_btn_21";
            data.vremy = "34";
            this.Hide();
        }

        private void pt_btn_22_Click(object sender, EventArgs e)
        {
            if (zareg())
                return;
            this.DialogResult = DialogResult.OK;           
            apl.Show();
            apl.chislo.Text = "Пятница 22:30";
            apl.cena.Text = "400 рублей";
            Program.per_id_bt = "pt_btn_22";
            data.vremy = "35";
            this.Hide();
        }

        private void sb_btn_8_Click(object sender, EventArgs e)
        {
            if (zareg())
                return;
            this.DialogResult = DialogResult.OK;            
            apl.Show();
            apl.chislo.Text = "Суббота 8:30";
            apl.cena.Text = "300 рублей";
            Program.per_id_bt = "sb_btn_8";
            data.vremy = "36";
            this.Hide();
        }

        private void sb_btn_9_Click(object sender, EventArgs e)
        {
            if (zareg())
                return;
            this.DialogResult = DialogResult.OK;           
            apl.Show();
            apl.chislo.Text = "Суббота 9:30";
            apl.cena.Text = "300 рублей";
            Program.per_id_bt = "sb_btn_9";
            data.vremy = "37";
            this.Hide();
        }

        private void sb_btn_10_Click(object sender, EventArgs e)
        {
            if (zareg())
                return;
            this.DialogResult = DialogResult.OK;           
            apl.Show();
            apl.chislo.Text = "Суббота 10:30";
            apl.cena.Text = "300 рублей";
            Program.per_id_bt = "sb_btn_10";
            data.vremy = "38";
            this.Hide();
        }

        private void sb_btn_11_Click(object sender, EventArgs e)
        {
            if (zareg())
                return;
            this.DialogResult = DialogResult.OK;            
            apl.Show();
            apl.chislo.Text = "Суббота 11:30";
            apl.cena.Text = "300 рублей";
            Program.per_id_bt = "sb_btn_11";
            data.vremy = "39";
            this.Hide();
        }

        private void sb_btn_12_Click(object sender, EventArgs e)
        {
            if (zareg())
                return;
            this.DialogResult = DialogResult.OK;           
            apl.Show();
            apl.chislo.Text = "Суббота 12:30";
            apl.cena.Text = "300 рублей";
            Program.per_id_bt = "sb_btn_12";
            data.vremy = "40";
            this.Hide();
        }

        private void sb_btn_13_Click(object sender, EventArgs e)
        {
            if (zareg())
                return;
            this.DialogResult = DialogResult.OK;           
            apl.Show();
            apl.chislo.Text = "Суббота 13:30";
            apl.cena.Text = "300 рублей";
            Program.per_id_bt = "sb_btn_13";
            data.vremy = "41";
            this.Hide();
        }

        private void sb_btn_14_Click(object sender, EventArgs e)
        {
            if (zareg())
                return;
            this.DialogResult = DialogResult.OK;           
            apl.Show();
            apl.chislo.Text = "Суббота 14:30";
            apl.cena.Text = "300 рублей";
            Program.per_id_bt = "sb_btn_14";
            data.vremy = "42";
            this.Hide();
        }

        private void sb_btn_15_Click(object sender, EventArgs e)
        {
            if (zareg())
                return;
            this.DialogResult = DialogResult.OK;          
            apl.Show();
            apl.chislo.Text = "Суббота 15:30";
            apl.cena.Text = "400 рублей";
            Program.per_id_bt = "sb_btn_15";
            data.vremy = "43";
            this.Hide();
        }

        private void sb_btn_16_Click(object sender, EventArgs e)
        {
            if (zareg())
                return;
            this.DialogResult = DialogResult.OK;            
            apl.Show();
            apl.chislo.Text = "Суббота 16:30";
            apl.cena.Text = "400 рублей";
            Program.per_id_bt = "sb_btn_16";
            data.vremy = "44";
            this.Hide();
        }

        private void sb_btn_17_Click(object sender, EventArgs e)
        {
            if (zareg())
                return;
            this.DialogResult = DialogResult.OK;           
            apl.Show();
            apl.chislo.Text = "Суббота 17:30";
            apl.cena.Text = "400 рублей";
            Program.per_id_bt = "sb_btn_17";
            data.vremy = "45";
            this.Hide();
        }

        private void sb_btn_18_Click(object sender, EventArgs e)
        {
            if (zareg())
                return;
            this.DialogResult = DialogResult.OK;          
            apl.Show();
            apl.chislo.Text = "Суббота 18:30";
            apl.cena.Text = "400 рублей";
            Program.per_id_bt = "sb_btn_18";
            data.vremy = "46";
            this.Hide();
        }

        private void sb_btn_19_Click(object sender, EventArgs e)
        {
            if (zareg())
                return;
            this.DialogResult = DialogResult.OK;           
            apl.Show();
            apl.chislo.Text = "Суббота 19:30";
            apl.cena.Text = "400 рублей";
            Program.per_id_bt = "sb_btn_19";
            data.vremy = "47";
            this.Hide();
        }

        private void sb_btn_20_Click(object sender, EventArgs e)
        {
            if (zareg())
                return;
            this.DialogResult = DialogResult.OK;            
            apl.Show();
            apl.chislo.Text = "Суббота 20:30";
            apl.cena.Text = "400 рублей";
            Program.per_id_bt = "sb_btn_20";
            data.vremy = "48";
            this.Hide();
        }

        private void sb_btn_21_Click(object sender, EventArgs e)
        {
            if (zareg())
                return;
            this.DialogResult = DialogResult.OK;
            apl.Show();
            apl.chislo.Text = "Суббота 21:30";
            apl.cena.Text = "400 рублей";
            Program.per_id_bt = "sb_btn_21";
            data.vremy = "49";
            this.Hide();
        }

        private void sb_btn_22_Click(object sender, EventArgs e)
        {
            if (zareg())
                return;
            this.DialogResult = DialogResult.OK;
            apl.Show();
            apl.chislo.Text = "Суббота 22:30";
            apl.cena.Text = "400 рублей";
            Program.per_id_bt = "sb_btn_22";
            data.vremy = "50";
            this.Hide();
        }

        private void vs_btn_8_Click(object sender, EventArgs e)
        {
            if (zareg())
                return;
            this.DialogResult = DialogResult.OK;
            apl.Show();
            apl.chislo.Text = "Воскресенье 8:30";
            apl.cena.Text = "300 рублей";
            Program.per_id_bt = "vs_btn_8";
            data.vremy = "51";
            this.Hide();
        }

        private void vs_btn_9_Click(object sender, EventArgs e)
        {
            if (zareg())
                return;
            this.DialogResult = DialogResult.OK;
            apl.Show();
            apl.chislo.Text = "Воскресенье 9:30";
            apl.cena.Text = "300 рублей";
            Program.per_id_bt = "vs_btn_9";
            data.vremy = "52";
            this.Hide();
        }

        private void vs_btn_10_Click(object sender, EventArgs e)
        {
            if (zareg())
                return;
            this.DialogResult = DialogResult.OK;
            apl.Show();
            apl.chislo.Text = "Воскресенье 10:30";
            apl.cena.Text = "300 рублей";
            Program.per_id_bt = "vs_btn_10";
            data.vremy = "53";
            this.Hide();
        }

        private void vs_btn_11_Click(object sender, EventArgs e)
        {
            if (zareg())
                return;
            this.DialogResult = DialogResult.OK;
            apl.Show();
            apl.chislo.Text = "Воскресенье 11:30";
            apl.cena.Text = "300 рублей";
            Program.per_id_bt = "vs_btn_11";
            data.vremy = "54";
            this.Hide();
        }

        private void vs_btn_12_Click(object sender, EventArgs e)
        {
            if (zareg())
                return;
            this.DialogResult = DialogResult.OK;
            apl.Show();
            apl.chislo.Text = "Воскресенье 12:30";
            apl.cena.Text = "300 рублей";
            Program.per_id_bt = "vs_btn_12";
            data.vremy = "55";
            this.Hide();
        }

        private void vs_btn_13_Click(object sender, EventArgs e)
        {
            if (zareg())
                return;
            this.DialogResult = DialogResult.OK;
            apl.Show();
            apl.chislo.Text = "Воскресенье 13:30";
            apl.cena.Text = "300 рублей";
            Program.per_id_bt = "vs_btn_13";
            data.vremy = "56";
            this.Hide();
        }

        private void vs_btn_14_Click(object sender, EventArgs e)
        {
            if (zareg())
                return;
            this.DialogResult = DialogResult.OK;
            apl.Show();
            apl.chislo.Text = "Воскресенье 14:30";
            apl.cena.Text = "300 рублей";
            Program.per_id_bt = "vs_btn_14";
            data.vremy = "57";
            this.Hide();
        }

        private void vs_btn_15_Click(object sender, EventArgs e)
        {
            if (zareg())
                return;
            this.DialogResult = DialogResult.OK;
            apl.Show();
            apl.chislo.Text = "Воскресенье 15:30";
            apl.cena.Text = "400 рублей";
            Program.per_id_bt = "vs_btn_15";
            data.vremy = "58";
            this.Hide();
        }

        private void vs_btn_16_Click(object sender, EventArgs e)
        {
            if (zareg())
                return;
            this.DialogResult = DialogResult.OK;
            apl.Show();
            apl.chislo.Text = "Воскресенье 16:30";
            apl.cena.Text = "400 рублей";
            Program.per_id_bt = "vs_btn_16";
            data.vremy = "59";
            this.Hide();
        }

        private void vs_btn_17_Click(object sender, EventArgs e)
        {
            if (zareg())
                return;
            this.DialogResult = DialogResult.OK;
            apl.Show();
            apl.chislo.Text = "Воскресенье 17:30";
            apl.cena.Text = "400 рублей";
            Program.per_id_bt = "vs_btn_17";
            data.vremy = "60";
            this.Hide();
        }

        private void vs_btn_18_Click(object sender, EventArgs e)
        {
            if (zareg())
                return;
            this.DialogResult = DialogResult.OK;
            apl.Show();
            apl.chislo.Text = "Воскресенье 18:30";
            apl.cena.Text = "400 рублей";
            Program.per_id_bt = "vs_btn_18";
            data.vremy = "61";
            this.Hide();
        }

        private void vs_btn_19_Click(object sender, EventArgs e)
        {
            if (zareg())
                return;
            this.DialogResult = DialogResult.OK;
            apl.Show();
            apl.chislo.Text = "Воскресенье 19:30";
            apl.cena.Text = "400 рублей";
            Program.per_id_bt = "vs_btn_19";
            data.vremy = "62";
            this.Hide();
        }

        private void vs_btn_20_Click(object sender, EventArgs e)
        {
            if (zareg())
                return;
            this.DialogResult = DialogResult.OK;
            apl.Show();
            apl.chislo.Text = "Воскресенье 20:30";
            apl.cena.Text = "400 рублей";
            Program.per_id_bt = "vs_btn_20";
            data.vremy = "63";
            this.Hide();
        }

        private void vs_btn_21_Click(object sender, EventArgs e)
        {
            if (zareg())
                return;
            this.DialogResult = DialogResult.OK;
            apl.Show();
            apl.chislo.Text = "Воскресенье 21:30";
            apl.cena.Text = "400 рублей";
            Program.per_id_bt = "vs_btn_21";
            data.vremy = "64";
            this.Hide();
        }

        private void vs_btn_22_Click(object sender, EventArgs e)
        {
            if (zareg())
                return;
            apl.Show();
            apl.chislo.Text = "Воскресенье 22:30";
            apl.cena.Text = "400 рублей";
            Program.per_id_bt = "vs_btn_22";
            data.vremy = "65";
            this.Hide();
        }

        public Boolean zareg()
        {
            MainForm main = new MainForm();
            if (main.Labuser.Text == "")
            {
                MessageBox.Show(" Сначала зарегистрируйтесь");
                return true;
            }
            else
                return false;
        }

        private void update_lab_Click(object sender, EventArgs e)
        {
            this.Close();
            raspisanie ras = new raspisanie();
            ras.Show();
        }
    }
}
