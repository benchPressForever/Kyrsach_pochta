using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace kyrsach_pochta
{
    public partial class SearchPackageClient : Form
    {

        ClientInfo clientInfo;
        ActionClientForm startForm;

        public SearchPackageClient(ActionClientForm form)
        {
            InitializeComponent();
            startForm = form;
            clientInfo = CurrentSession.Client;
        }

        private void MainFormClient_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kyrsachDataSet.Статус_отправления". При необходимости она может быть перемещена или удалена.
            this.статус_отправленияTableAdapter.Fill(this.kyrsachDataSet.Статус_отправления);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kyrsachDataSet.Отправление". При необходимости она может быть перемещена или удалена.
            this.отправлениеTableAdapter.Fill(this.kyrsachDataSet.Отправление);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kyrsachDataSet.Клиент". При необходимости она может быть перемещена или удалена.
            this.клиентTableAdapter.Fill(this.kyrsachDataSet.Клиент);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int packageId = (int) numericUpDown1.Value;

            var package = kyrsachDataSet.Отправление.FirstOrDefault(
                c => c.Код_отправления == packageId 
                && c.Код_клиента_получателя ==  clientInfo.Id
                || c.Код_отправления == packageId
                && c.Код_клиента_отправителя == clientInfo.Id);

            if (package == null)
            {
                MessageBox.Show($"Отправление с ID {packageId} не найдено.", "Не найдено",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var temp = kyrsachDataSet.Отправление.Clone();

            temp.Rows.Add(
                package.Код_отправления,
                package.Дата_приёма,
                (object)package.Адрес_отправителя ?? DBNull.Value,
                (object)package.Адрес_получателя ?? DBNull.Value,
                package.Код_клиента_отправителя,
                package.Код_клиента_получателя,
                (object)package.Вид_отправления ?? DBNull.Value,
                package.Вес,
                package.Объявленная_ценность,
                package.Стоимость_доставки,
                (object)package.Трек_номер ?? DBNull.Value
            );


            dataGridViewPackages.DataSource = temp;

            MessageBox.Show($"Отправление {package.Код_отправления} найдено!", "Успех",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void клиентBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.клиентBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kyrsachDataSet);

        }

        private void loadList(List<kyrsachDataSet.ОтправлениеRow> packages)
        {
            dataGridViewPackages.DataSource = null;
            var temp = kyrsachDataSet.Отправление.Clone();

            foreach (var package in packages)
            {
                temp.Rows.Add(
                    package.Код_отправления,
                    package.Дата_приёма,
                    (object)package.Адрес_отправителя ?? DBNull.Value,
                    (object)package.Адрес_получателя ?? DBNull.Value,
                    package.Код_клиента_отправителя,
                    package.Код_клиента_получателя,
                    (object)package.Вид_отправления ?? DBNull.Value,
                    package.Вес,
                    package.Объявленная_ценность,
                    package.Стоимость_доставки,
                    (object)package.Трек_номер ?? DBNull.Value
                );
            }
            dataGridViewPackages.DataSource = temp;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            var packages = kyrsachDataSet.Отправление
            .Where(c => c.Код_клиента_получателя == clientInfo.Id
                     || c.Код_клиента_отправителя == clientInfo.Id)
            .ToList();

            loadList(packages);
        }

        private void filterStatus(String status)
        {
            sqlCommand1.Parameters["@userId"].Value = (int)clientInfo.Id;
            sqlCommand1.Parameters["@status"].Value = status;

            sqlConnection1.Open();

            var temp = kyrsachDataSet.Отправление.Clone();

            temp.Load(sqlCommand1.ExecuteReader());

            dataGridViewPackages.DataSource = temp;

            sqlConnection1.Close();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            filterStatus("зарегистрировано");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            startForm.Visible = true;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            filterStatus("транспортируется");
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            filterStatus("готово_к_выдаче");
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            filterStatus("выдано");
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            filterStatus("утилизировано");
        }

        private void dataGridViewPackages_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var rowData = dataGridViewPackages.Rows[e.RowIndex].DataBoundItem as DataRowView;

                if (rowData == null) return;

                Package package = new Package
                {
                    Id = Convert.ToInt32(rowData["Код_отправления"]),
                    AcceptDate = Convert.ToDateTime(rowData["Дата_приёма"]),
                    SenderAddress = rowData["Адрес_отправителя"].ToString(),
                    RecipientAddress = rowData["Адрес_получателя"].ToString(),
                    SenderId = Convert.ToInt32(rowData["Код_клиента_отправителя"]),
                    RecipientId = Convert.ToInt32(rowData["Код_клиента_получателя"]),
                    Type = rowData["Вид_отправления"].ToString(),
                    Weight = Convert.ToDecimal(rowData["Вес"]),
                    DeclaredValue = Convert.ToDecimal(rowData["Объявленная_ценность"]),
                    DeliveryCost = Convert.ToDecimal(rowData["Стоимость_доставки"]),
                    TrackNumber = rowData["Трек_номер"].ToString()
                };

                Form form = new FormPackageDetails(package);
                form.Show();
            }
        }
    }
}
