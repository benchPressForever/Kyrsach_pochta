using BCrypt;
using kyrsach_pochta.kyrsachDataSetTableAdapters;
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

namespace kyrsach_pochta
{
    public partial class LoginEmployeeForm : Form
    {
        StartForm startForm;
        public LoginEmployeeForm(StartForm form)
        {
            InitializeComponent();
            startForm = form;
        }

        private void button2login_Click(object sender, EventArgs e)
        {
            
            try
            {
                var password = PasswordTextBox2.Text.Trim();
                var login = EmailTextBox2.Text.Trim();

                var client = kyrsachDataSet.Сотрудник.FirstOrDefault(c => c.Логин == login);

                if (client == null)
                {
                    MessageBox.Show("Сотрудник не найден!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    EmailTextBox2.Focus();
                    return;
                }

                bool isValid = BCrypt.Net.BCrypt.Verify(password, client.Пароль);

                if (!isValid)
                {
                    MessageBox.Show("Неверный пароль!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    PasswordTextBox2.Focus();
                    return;
                }

                CurrentSession.LoginEmployee(client);
                MessageBox.Show($"Добро пожаловать, {client.ФИО}!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if(client.Должность == "Оператор")
                {
                    Form mainForm = new ActionEmployeeForm(startForm);
                    mainForm.Show();
                    this.Hide();
                }
                else
                {
                    Form mainForm = new ActionManagerForm(startForm);
                    mainForm.Show();
                    this.Hide();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при авторизации: {ex.Message}", "Ошибка");
            }


        }

        private void button1exit_Click(object sender, EventArgs e)
        {
            this.Close();
            startForm.Visible = true;
        }

        private void сотрудникBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.сотрудникBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kyrsachDataSet);

        }

        private void LoginEmployeeForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kyrsachDataSet.Сотрудник". При необходимости она может быть перемещена или удалена.
            this.сотрудникTableAdapter.Fill(this.kyrsachDataSet.Сотрудник);

        }
    }
}
