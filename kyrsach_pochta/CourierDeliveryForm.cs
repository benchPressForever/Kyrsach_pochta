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
    public partial class CourierDeliveryForm : Form
    {
        ClientInfo clientInfo;
        ActionClientForm startForm;
        public CourierDeliveryForm(ActionClientForm form)
        {
            InitializeComponent();
            startForm = form;
            clientInfo = CurrentSession.Client;

            loadAllCourierDelivery();
        }

        private void loadAllCourierDelivery()
        {
            try
            {
                mySqlConnection.Open();

                var temp = new DataTable();
                temp.Load(new SqlCommand(
                    $@"select * from Курьерский_заказ
                    where Код_получателя = {clientInfo.Id}",
                mySqlConnection).ExecuteReader());

                dgvCourierOrders.DataSource = temp;

                mySqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке доставок: {ex.Message}", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (mySqlConnection.State == ConnectionState.Open)
                    mySqlConnection.Close();
            }
        }

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
            startForm.Visible = true;
        }
    }
}
