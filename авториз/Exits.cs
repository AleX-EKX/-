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
    public partial class Exits : Form
    {
        public Exits()
        {
            InitializeComponent();
        }

        private void Bt_yes_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Bt_no_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
