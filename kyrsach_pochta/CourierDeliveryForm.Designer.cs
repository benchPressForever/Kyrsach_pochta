namespace kyrsach_pochta
{
    partial class CourierDeliveryForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCreateOrder = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvCourierOrders = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtDeliveryAddress = new System.Windows.Forms.TextBox();
            this.cmbPackage = new System.Windows.Forms.ComboBox();
            this.dtpDesiredTime = new System.Windows.Forms.DateTimePicker();
            this.lblTotalCourierCost = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.mySqlConnection = new System.Data.SqlClient.SqlConnection();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourierOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTotalCourierCost);
            this.groupBox1.Controls.Add(this.dtpDesiredTime);
            this.groupBox1.Controls.Add(this.cmbPackage);
            this.groupBox1.Controls.Add(this.txtDeliveryAddress);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.btnCreateOrder);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(13, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(567, 258);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Оформление нового курьерского заказа";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Отправление:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Адрес доставки:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Желаемая дата:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(298, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Желаемое время:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Расчёт стоимости доставки:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(286, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Итоговая стоимость курьерской доставки:";
            // 
            // btnCreateOrder
            // 
            this.btnCreateOrder.Location = new System.Drawing.Point(453, 204);
            this.btnCreateOrder.Name = "btnCreateOrder";
            this.btnCreateOrder.Size = new System.Drawing.Size(99, 33);
            this.btnCreateOrder.TabIndex = 7;
            this.btnCreateOrder.Text = "Оформить";
            this.btnCreateOrder.UseVisualStyleBackColor = true;
            this.btnCreateOrder.Click += new System.EventHandler(this.btnCreateOrder_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvCourierOrders);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(13, 302);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(567, 291);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Мои курьерские заказы";
            // 
            // dgvCourierOrders
            // 
            this.dgvCourierOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCourierOrders.Location = new System.Drawing.Point(0, 22);
            this.dgvCourierOrders.MultiSelect = false;
            this.dgvCourierOrders.Name = "dgvCourierOrders";
            this.dgvCourierOrders.ReadOnly = true;
            this.dgvCourierOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCourierOrders.Size = new System.Drawing.Size(567, 269);
            this.dgvCourierOrders.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(133, 115);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(159, 22);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // txtDeliveryAddress
            // 
            this.txtDeliveryAddress.Location = new System.Drawing.Point(133, 81);
            this.txtDeliveryAddress.Name = "txtDeliveryAddress";
            this.txtDeliveryAddress.Size = new System.Drawing.Size(159, 22);
            this.txtDeliveryAddress.TabIndex = 10;
            // 
            // cmbPackage
            // 
            this.cmbPackage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPackage.FormattingEnabled = true;
            this.cmbPackage.Location = new System.Drawing.Point(133, 40);
            this.cmbPackage.Name = "cmbPackage";
            this.cmbPackage.Size = new System.Drawing.Size(159, 24);
            this.cmbPackage.TabIndex = 11;
            // 
            // dtpDesiredTime
            // 
            this.dtpDesiredTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpDesiredTime.Location = new System.Drawing.Point(427, 120);
            this.dtpDesiredTime.Name = "dtpDesiredTime";
            this.dtpDesiredTime.Size = new System.Drawing.Size(92, 22);
            this.dtpDesiredTime.TabIndex = 12;
            // 
            // lblTotalCourierCost
            // 
            this.lblTotalCourierCost.AutoSize = true;
            this.lblTotalCourierCost.Location = new System.Drawing.Point(312, 212);
            this.lblTotalCourierCost.Name = "lblTotalCourierCost";
            this.lblTotalCourierCost.Size = new System.Drawing.Size(44, 16);
            this.lblTotalCourierCost.TabIndex = 13;
            this.lblTotalCourierCost.Text = "0 руб.";
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit.Location = new System.Drawing.Point(383, 606);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(197, 49);
            this.exit.TabIndex = 15;
            this.exit.Text = "Вернуться к главному меню";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // mySqlConnection
            // 
            this.mySqlConnection.ConnectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=kyrsach;Integrated Security=True" +
    ";Encrypt=False";
            this.mySqlConnection.FireInfoMessageEventOnUserErrors = false;
            // 
            // CourierDeliveryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 667);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "CourierDeliveryForm";
            this.Text = "Курьерская доставка";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourierOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreateOrder;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvCourierOrders;
        private System.Windows.Forms.ComboBox cmbPackage;
        private System.Windows.Forms.TextBox txtDeliveryAddress;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblTotalCourierCost;
        private System.Windows.Forms.DateTimePicker dtpDesiredTime;
        private System.Windows.Forms.Button exit;
        private System.Data.SqlClient.SqlConnection mySqlConnection;
    }
}