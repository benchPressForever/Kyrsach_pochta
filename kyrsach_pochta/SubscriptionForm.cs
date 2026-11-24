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
            dtpStartDate.MinDate = DateTime.Today;
            dtpStartDate.MaxDate = DateTime.Today.AddYears(2);

            startForm = form;
            clientInfo = CurrentSession.Client;

            loadAllEditions();

            loadClientSubs();

        }

        private void loadClientSubs()
        {
            try
            {
                sqlCommand3.Parameters["@userId"].Value = clientInfo.Id;

                mySqlConnection.Open();

                var id = clientInfo.Id;

                var temp = new DataTable();
                temp.Load(sqlCommand3.ExecuteReader());

                dataGridViewMySubs.DataSource = temp;
                dataGridViewMySubs.Columns["Код_подписки"].Visible = false;

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

                temp.Load(sqlCommand2.ExecuteReader());

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
                int mounts = Convert.ToInt32(numMonths.Value);

                sqlCommand1.Parameters["@userId"].Value = clientInfo.Id;
                sqlCommand1.Parameters["@idEdition"].Value = Convert.ToInt32(idEdition.Text);
                sqlCommand1.Parameters["@startDate"].Value = dtpStartDate.Value.Date;
                sqlCommand1.Parameters["@endDate"].Value = dtpStartDate.Value.Date.AddMonths(mounts);

                mySqlConnection.Open();

                sqlCommand1.ExecuteNonQuery();

                mySqlConnection.Close();

                loadClientSubs();

                MessageBox.Show($"Успешно: подписка успешно оформлена!", "успешно",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void btnExtend_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = dataGridViewMySubs.CurrentRow;
                int idSub = Convert.ToInt32(row.Cells["Код_подписки"].Value);

                object cellValue = row.Cells["Код_подписки"].Value;

                if (cellValue == null || cellValue == DBNull.Value)
                {
                    MessageBox.Show("Код подписки пустой!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int mounts = Convert.ToInt32(numExtendMonths.Value);

                sqlCommand4.Parameters["@mounts"].Value = mounts;
                sqlCommand4.Parameters["@idSub"].Value = idSub;

                mySqlConnection.Open();

                sqlCommand4.ExecuteNonQuery();

                mySqlConnection.Close();

                loadClientSubs();

                MessageBox.Show($"Успешно: подписка успешно продлена на {mounts} месяцев!", "успешно",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void btnCloseExpired_Click(object sender, EventArgs e)
        {

        }

        private void buttonCount_Click(object sender, EventArgs e)
        {

        }
    }
}
