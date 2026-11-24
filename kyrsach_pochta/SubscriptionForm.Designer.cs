namespace kyrsach_pochta
{
    partial class SubscriptionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewAllEditions = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.totalPrice = new System.Windows.Forms.TextBox();
            this.numMonths = new System.Windows.Forms.NumericUpDown();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.idEdition = new System.Windows.Forms.TextBox();
            this.buttonSub = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridViewMySubs = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.numExtendMonths = new System.Windows.Forms.NumericUpDown();
            this.btnExtend = new System.Windows.Forms.Button();
            this.mySqlConnection = new System.Data.SqlClient.SqlConnection();
            this.exit = new System.Windows.Forms.Button();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand3 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand4 = new System.Data.SqlClient.SqlCommand();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonCount = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllEditions)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMonths)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMySubs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numExtendMonths)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(93, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(620, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Оформление и управление подписками на периодические издания";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewAllEditions);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(16, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 236);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Каталог периодических изданий";
            // 
            // dataGridViewAllEditions
            // 
            this.dataGridViewAllEditions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAllEditions.Location = new System.Drawing.Point(0, 19);
            this.dataGridViewAllEditions.Name = "dataGridViewAllEditions";
            this.dataGridViewAllEditions.Size = new System.Drawing.Size(440, 217);
            this.dataGridViewAllEditions.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonCount);
            this.groupBox2.Controls.Add(this.totalPrice);
            this.groupBox2.Controls.Add(this.numMonths);
            this.groupBox2.Controls.Add(this.dtpStartDate);
            this.groupBox2.Controls.Add(this.idEdition);
            this.groupBox2.Controls.Add(this.buttonSub);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(474, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(304, 236);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Оформление подписки";
            // 
            // totalPrice
            // 
            this.totalPrice.Enabled = false;
            this.totalPrice.Location = new System.Drawing.Point(198, 146);
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.Size = new System.Drawing.Size(100, 22);
            this.totalPrice.TabIndex = 11;
            // 
            // numMonths
            // 
            this.numMonths.Location = new System.Drawing.Point(254, 111);
            this.numMonths.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numMonths.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMonths.Name = "numMonths";
            this.numMonths.Size = new System.Drawing.Size(44, 22);
            this.numMonths.TabIndex = 10;
            this.numMonths.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(139, 74);
            this.dtpStartDate.MinDate = new System.DateTime(2026, 11, 24, 0, 0, 0, 0);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(159, 22);
            this.dtpStartDate.TabIndex = 7;
            this.dtpStartDate.Value = new System.DateTime(2026, 11, 24, 0, 0, 0, 0);
            // 
            // idEdition
            // 
            this.idEdition.Location = new System.Drawing.Point(198, 37);
            this.idEdition.Name = "idEdition";
            this.idEdition.Size = new System.Drawing.Size(100, 22);
            this.idEdition.TabIndex = 6;
            // 
            // buttonSub
            // 
            this.buttonSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSub.Location = new System.Drawing.Point(188, 187);
            this.buttonSub.Name = "buttonSub";
            this.buttonSub.Size = new System.Drawing.Size(110, 34);
            this.buttonSub.TabIndex = 5;
            this.buttonSub.Text = "Оформить";
            this.buttonSub.UseVisualStyleBackColor = true;
            this.buttonSub.Click += new System.EventHandler(this.buttonSub_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(6, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Итого к оплате:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(6, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Срок (мес.) :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Дата начала:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(8, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Код издания:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridViewMySubs);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(16, 309);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(440, 294);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Мои подписки";
            // 
            // dataGridViewMySubs
            // 
            this.dataGridViewMySubs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMySubs.Location = new System.Drawing.Point(0, 22);
            this.dataGridViewMySubs.Name = "dataGridViewMySubs";
            this.dataGridViewMySubs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMySubs.Size = new System.Drawing.Size(440, 272);
            this.dataGridViewMySubs.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(481, 365);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 44);
            this.label2.TabIndex = 4;
            this.label2.Text = "Продлить выбранную на (мес.) :";
            // 
            // numExtendMonths
            // 
            this.numExtendMonths.Location = new System.Drawing.Point(635, 377);
            this.numExtendMonths.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numExtendMonths.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numExtendMonths.Name = "numExtendMonths";
            this.numExtendMonths.Size = new System.Drawing.Size(44, 20);
            this.numExtendMonths.TabIndex = 5;
            this.numExtendMonths.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnExtend
            // 
            this.btnExtend.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExtend.Location = new System.Drawing.Point(690, 370);
            this.btnExtend.Name = "btnExtend";
            this.btnExtend.Size = new System.Drawing.Size(88, 30);
            this.btnExtend.TabIndex = 6;
            this.btnExtend.Text = "Продлить";
            this.btnExtend.UseVisualStyleBackColor = true;
            this.btnExtend.Click += new System.EventHandler(this.btnExtend_Click);
            // 
            // mySqlConnection
            // 
            this.mySqlConnection.ConnectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=kyrsach;Integrated Security=True" +
    ";Encrypt=False";
            this.mySqlConnection.FireInfoMessageEventOnUserErrors = false;
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit.Location = new System.Drawing.Point(474, 554);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(304, 49);
            this.exit.TabIndex = 15;
            this.exit.Text = "Вернуться к главному меню";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandText = "Оформление_подписки_на_издание";
            this.sqlCommand1.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlCommand1.Connection = this.mySqlConnection;
            this.sqlCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@userId", System.Data.SqlDbType.Int),
            new System.Data.SqlClient.SqlParameter("@idEdition", System.Data.SqlDbType.Int),
            new System.Data.SqlClient.SqlParameter("@startDate", System.Data.SqlDbType.DateTime),
            new System.Data.SqlClient.SqlParameter("@endDate", System.Data.SqlDbType.DateTime)});
            // 
            // sqlCommand2
            // 
            this.sqlCommand2.CommandText = "SELECT        Код_издания, Название, Тип, Издательство, Частота_выхода, Стоимость" +
    "_за_месяц\r\nFROM            Периодическое_издание";
            this.sqlCommand2.Connection = this.mySqlConnection;
            // 
            // sqlCommand3
            // 
            this.sqlCommand3.CommandText = "SELECT        Код_подписки, Дата_оформления, Дата_окончания, Стоимость, Статус\r\nF" +
    "ROM            dbo.Поиск_подписок_у_клиента(@userId) AS Поиск_подписок_у_клиента" +
    "_1";
            this.sqlCommand3.Connection = this.mySqlConnection;
            this.sqlCommand3.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@userId", System.Data.SqlDbType.Int)});
            // 
            // sqlCommand4
            // 
            this.sqlCommand4.CommandText = "Продление_подписки_на_издание";
            this.sqlCommand4.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlCommand4.Connection = this.mySqlConnection;
            this.sqlCommand4.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@mounts", System.Data.SqlDbType.Int),
            new System.Data.SqlClient.SqlParameter("@idSub", System.Data.SqlDbType.Int)});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(480, 319);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Действия:";
            // 
            // buttonCount
            // 
            this.buttonCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCount.Location = new System.Drawing.Point(10, 187);
            this.buttonCount.Name = "buttonCount";
            this.buttonCount.Size = new System.Drawing.Size(117, 34);
            this.buttonCount.TabIndex = 12;
            this.buttonCount.Text = "Рассчитать";
            this.buttonCount.UseVisualStyleBackColor = true;
            this.buttonCount.Click += new System.EventHandler(this.buttonCount_Click);
            // 
            // SubscriptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 626);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnExtend);
            this.Controls.Add(this.numExtendMonths);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SubscriptionForm";
            this.Text = "Периодические издания";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllEditions)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMonths)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMySubs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numExtendMonths)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewAllEditions;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSub;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridViewMySubs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numExtendMonths;
        private System.Windows.Forms.Button btnExtend;
        private System.Windows.Forms.TextBox idEdition;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.NumericUpDown numMonths;
        private System.Windows.Forms.TextBox totalPrice;
        private System.Data.SqlClient.SqlConnection mySqlConnection;
        private System.Windows.Forms.Button exit;
        private System.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Data.SqlClient.SqlCommand sqlCommand2;
        private System.Data.SqlClient.SqlCommand sqlCommand3;
        private System.Data.SqlClient.SqlCommand sqlCommand4;
        private System.Windows.Forms.Button buttonCount;
        private System.Windows.Forms.Label label7;
    }
}