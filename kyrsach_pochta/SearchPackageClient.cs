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


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            startForm.Visible = true;
        }

        private void dataGridViewPackages_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var rowData = dataGridViewPackages.Rows[e.RowIndex].DataBoundItem as DataRowView;

                if (rowData == null) return;

                Package package = new Package
                {
                    TrackNumber = rowData["Трек номер"].ToString(),
                    AcceptDate = Convert.ToDateTime(rowData["Дата приёма"]),
                    SenderAddress = rowData["Адрес отправителя"].ToString(),
                    RecipientAddress = rowData["Адрес получателя"].ToString(),
                    Type = rowData["Вид отправления"].ToString(),
                    Status = rowData["Статус"].ToString(),
                    Weight = Convert.ToDecimal(rowData["Вес"]),
                    DeclaredValue = Convert.ToDecimal(rowData["Объявленная ценность"])
                };

                Form form = new FormPackageDetails(package);
                form.Show();
            }
        }

        private void comboBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            string status = comboBoxStatus.Text;

            sqlCommand2.Parameters["@status"].Value = status;
            sqlCommand2.Parameters["@userId"].Value = clientInfo.Id;

            mySqlConnection.Open();

            var temp = new DataTable();

            temp.Load(sqlCommand2.ExecuteReader());

            dataGridViewPackages.DataSource = temp;

            dataGridViewPackages.Columns["Вес"].Visible = false;
            dataGridViewPackages.Columns["Объявленная ценность"].Visible = false;

            mySqlConnection.Close();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            sqlCommand1.Parameters["@trackNumber"].Value = textTrackNum.Text;

            mySqlConnection.Open();

            var temp = new DataTable();

            temp.Load(sqlCommand1.ExecuteReader());

            dataGridViewPackages.DataSource = temp;

            dataGridViewPackages.Columns["Вес"].Visible = false;
            dataGridViewPackages.Columns["Объявленная ценность"].Visible = false;

            mySqlConnection.Close();
        }
    }
}
