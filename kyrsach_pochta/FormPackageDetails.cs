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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace kyrsach_pochta
{
    public partial class FormPackageDetails : Form
    {

        Package package;
        public FormPackageDetails(Package p)
        {
            InitializeComponent();

            package = p;
            TrackNumber.Text = p.TrackNumber.ToString();
            Type.Text = p.Type.ToString();
            Date.Text = p.AcceptDate.ToShortDateString();
            Sender.Text = p.SenderAddress.ToString();
            Recipient.Text = p.RecipientAddress.ToString();
            labelWeight.Text = p.Weight.ToString() + " кг";
            labelPrice.Text = p.DeclaredValue.ToString() + " руб.";
            currentStatus.Text = p.Status.ToString();
        }

        private void loadStatuses()
        {
            try
            {
                sqlCommand1.Parameters["@trackNumber"].Value = package.TrackNumber.ToString();

                mySqlConnection.Open();

                var temp = new DataTable();
                temp.Load(sqlCommand1.ExecuteReader());

                dataGridViewStatus.DataSource = temp;

                mySqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке истории статусов: {ex.Message}", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (mySqlConnection.State == ConnectionState.Open)
                    mySqlConnection.Close();
            }
        }

        private void FormPackageDetails_Load(object sender, EventArgs e)
        {
            loadStatuses();
        }
    }
}
