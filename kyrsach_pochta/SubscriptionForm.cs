using System;
using System.Collections;
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
    public partial class SubscriptionForm : Form
    {
        ClientInfo clientInfo;
        ActionClientForm startForm;
        public SubscriptionForm(ActionClientForm form)
        {
            InitializeComponent();

            dtpStartDate.Value = DateTime.Today;

            startForm = form;
            clientInfo = CurrentSession.Client;

            loadAllEditions();

            loadClientSubs();

        }

        private void loadClientSubs()
        {
            try
            {
                mySqlConnection.Open();

                var id = clientInfo.Id;

                var temp = new DataTable();
                temp.Load(new SqlCommand(
                    $@"select Дата_оформления, Дата_окончания,Стоимость,Статус  
                    from Подписка_на_издание where Код_клиента = {id}",
                mySqlConnection).ExecuteReader());

                dataGridViewMySubs.DataSource = temp;

                mySqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке подписок: {ex.Message}", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (mySqlConnection.State == ConnectionState.Open)
                    mySqlConnection.Close();
            }
        }


        private void loadAllEditions()
        {
            try
            {
                mySqlConnection.Open();

                var temp = new DataTable();
                temp.Load(new SqlCommand(
                    @"select * from Периодическое_издание",
                mySqlConnection).ExecuteReader());

                dataGridViewAllEditions.DataSource = temp;

                mySqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке изданий: {ex.Message}", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (mySqlConnection.State == ConnectionState.Open)
                    mySqlConnection.Close();
            }
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            try
            {
                int idSub = 1001;
                int idEd = Convert.ToInt32(idEdition.Text);
                DateTime startDate = dtpStartDate.Value.Date;
                DateTime endDate = startDate.AddMonths((int)numMonths.Value);

                mySqlConnection.Open();

                string query = $@"insert into Подписка_на_издание 
                (Код_подписки, Код_клиента, Код_издания, Дата_оформления, Дата_окончания, Статус)
                values ({idSub},{clientInfo.Id},{idEd},'{startDate:yyyy-MM-dd}','{endDate:yyyy-MM-dd}','активна')";

                SqlCommand cmd = new SqlCommand(query, mySqlConnection);
                cmd.ExecuteNonQuery();

                mySqlConnection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (mySqlConnection.State == ConnectionState.Open)
                    mySqlConnection.Close();
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
            startForm.Visible = true;
        }
    }
}
