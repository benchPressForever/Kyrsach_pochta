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
    public partial class ActionClientForm : Form
    {
        StartForm startForm;

        public ActionClientForm(StartForm form)
        {
            InitializeComponent();
            this.startForm = form;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form mainForm = new SearchPackageClient(this);
            mainForm.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CurrentSession.Logout();
            startForm.Show();
            this.Hide();
        }

        private void ActionClientForm_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form form = new SubscriptionForm(this);
            form.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form form = new CourierDeliveryForm(this);
            form.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form form = new EditProfileForm(this);
            form.Show();
            this.Hide();
        }
    }
}
