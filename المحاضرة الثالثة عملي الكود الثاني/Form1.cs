using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace المحاضرة_الثالثة_عملي_الكود_الثاني
{
    public partial class sendr : Form
    {
        public sendr()
        {
            InitializeComponent();
        }
        private void traingforsendr(object sendr,EventArgs e)
        {
            if (sendr == butyelow)
                button4.BackColor = Color.Yellow;
            else if (((Button)sendr).Text== butgreen.Text)
               button4.BackColor = Color.Green;
            //else if (sendr == device2)
            //    button4.Text = device1.Text;
             
                
        }

    }
}
