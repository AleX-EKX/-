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
    public partial class BronButtoncs : UserControl
    {
        public WeekDays WeekDay { get; private set; }
        public BronButtoncs()
        {
            InitializeComponent();
        }
    }
}
