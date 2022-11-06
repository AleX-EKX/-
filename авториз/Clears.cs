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
    public partial class Clears : Form
    {
        public Clears()
        {
            InitializeComponent();
        }

        private void Bt_yes_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            MySqlCommand command = new MySqlCommand("DELETE FROM mail", db.GetConnection());

            db.openConnection();
            command.ExecuteNonQuery();

            db.closeConnection();
            this.Close();
            raspisanie ras = new raspisanie();
            ras.Show();
        }

        private void Bt_no_Click(object sender, EventArgs e)
        {
            this.Close();
            raspisanie ras = new raspisanie();
            ras.Show();
        }
    }
}
