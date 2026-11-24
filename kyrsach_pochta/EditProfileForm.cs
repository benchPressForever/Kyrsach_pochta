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
    public partial class EditProfileForm : Form
    {
        ClientInfo clientInfo;
        ActionClientForm startForm;
        public EditProfileForm(ActionClientForm form)
        {
            InitializeComponent();

            startForm = form;
            clientInfo = CurrentSession.Client;

            txtEmail.Text = clientInfo.Email;
            txtFio.Text = clientInfo.Fio;
            txtPhone.Text = clientInfo.Phone;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            startForm.Visible = true;
        }
    }
}
