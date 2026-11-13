using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p7jazysebas
{
    public partial class principal : Form
    {
        public principal()
        {
            InitializeComponent();
            this.FormClosed += Principal_FormClosed;
        }

        private void Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void principal_Load(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
