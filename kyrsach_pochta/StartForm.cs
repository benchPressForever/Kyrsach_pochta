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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form LoginForm = new LoginClientForm(this);
            LoginForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form RegForm = new RegisterClientForm(this);
            RegForm.Show();
            this.Hide();
        }

        private void StartForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form LoginEmployerForm = new LoginEmployeeForm(this);
            LoginEmployerForm.Show();
            this.Hide();
        }
    }
}
