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
    public partial class RegisterClientForm : Form
    {
        StartForm startForm;
        public RegisterClientForm(StartForm form)
        {
            InitializeComponent();
           startForm = form;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            startForm.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = textBoxEmail.Text.Trim();
            string password = textBoxPassword.Text.Trim();
            string password2 = textBoxPassword2.Text.Trim();
            string fio = textBoxFIO.Text.Trim();
            string number = textBoxNumber.Text.Trim();


            try
            {
                var newRow = kyrsachDataSet.Клиент.NewКлиентRow();
                newRow.Пароль = password;
                newRow.Телефон = number;
                newRow.ФИО = fio;
                newRow.Электронная_почта = email;
                kyrsachDataSet.Клиент.AddКлиентRow(newRow);
                клиентTableAdapter.Update(kyrsachDataSet.Клиент);
                MessageBox.Show("Регистрация успешна!", "Успех");
            }
            catch(Exception ex) {
                MessageBox.Show($"Ошибка при регистрации: {ex.Message}", "Ошибка");
            }
            

        }

        private void RegisterClientForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kyrsachDataSet.Клиент". При необходимости она может быть перемещена или удалена.
            this.клиентTableAdapter.Fill(this.kyrsachDataSet.Клиент);

        }

        private void клиентBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.клиентBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kyrsachDataSet);

        }
    }
}
