using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kyrsach_pochta
{
    public partial class ActionManagerForm : Form
    {

        StartForm startForm;
        public ActionManagerForm(StartForm startForm)
        {
            InitializeComponent();
            this.startForm = startForm;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CurrentSession.Logout();
            startForm.Show();
            this.Hide();
        }
    }
}
