using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace learn.ui
{
    public partial class Splash : Form
    {
        byte counter = 0;
        public Splash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;
            if (counter == 5)
            {
                timer1.Enabled = false;
                Login login = new Login();
                login.Show();
                this.Hide();
            }
        }
    }
}
