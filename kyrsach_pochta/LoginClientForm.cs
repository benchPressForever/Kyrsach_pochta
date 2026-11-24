using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using BCrypt;

namespace kyrsach_pochta
{
    public partial class LoginClientForm : Form
    {
        StartForm startForm;
        public LoginClientForm(StartForm form)
        {
            InitializeComponent();
            startForm = form;
        }

        private void LoginClientForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kyrsachDataSet.Клиент". При необходимости она может быть перемещена или удалена.
            this.клиентTableAdapter.Fill(this.kyrsachDataSet.Клиент);

        }

        private void button1exit_Click(object sender, EventArgs e)
        {
            this.Close();
            startForm.Visible = true;
        }

        private void button2login_Click(object sender, EventArgs e)
        {
            try
            {
                var email = EmailTextBox.Text.Trim();
                var password = PasswordTextBox.Text.Trim();

                var client = kyrsachDataSet.Клиент.FirstOrDefault(c => c.Электронная_почта == email);

                if (client == null)
                {
                    MessageBox.Show("Пользователь не найден!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    EmailTextBox.Focus();
                    return;
                }

                bool isValid = BCrypt.Net.BCrypt.Verify(password, client.Пароль);

                if (!isValid)
                {
                    MessageBox.Show("Неверный пароль!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    PasswordTextBox.Focus();
                    return;
                }

                CurrentSession.LoginClient(client);

                MessageBox.Show($"Добро пожаловать, {client.ФИО}!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Form actionForm = new ActionClientForm(startForm);
                actionForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при авторизации: {ex.Message}", "Ошибка");
            }
        }

        private void клиентBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.клиентBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kyrsachDataSet);

        }
    }
}
