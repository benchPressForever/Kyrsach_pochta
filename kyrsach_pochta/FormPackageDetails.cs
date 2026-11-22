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

namespace kyrsach_pochta
{
    public partial class FormPackageDetails : Form
    {

        Package package;
        public FormPackageDetails(Package p)
        {
            InitializeComponent();

            package = p;
            labelId.Text = p.Id.ToString();
            TrackNumber.Text = p.TrackNumber.ToString();
            Type.Text = p.Type.ToString();
            Date.Text = p.AcceptDate.ToString();
            Sender.Text = p.SenderAddress.ToString();
            Recipient.Text = p.RecipientAddress.ToString();
            labelPrice.Text = p.Weight.ToString() + " кг / " + p.DeclaredValue.ToString() + " руб. / " + p.DeliveryCost.ToString() + " руб.";

            mySqlConnection.Open();

            var id = p.Id.ToString();

            var temp = new DataTable();
            temp.Load(new SqlCommand(
                $"select * from Статус_отправления where Код_отправления = {id} " +
               "order by Дата_и_время, Код_статуса",
               mySqlConnection).ExecuteReader());

            dataGridViewStatus.DataSource = temp;

            mySqlConnection.Close();

            if (temp.Rows.Count > 0)
                currentStatus.Text = temp.Rows[temp.Rows.Count - 1]["Статус"].ToString();
            else
                currentStatus.Text = "нет статусов";

        }

        private void FormPackageDetails_Load(object sender, EventArgs e)
        {

        }

        private void IdOtpr_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
