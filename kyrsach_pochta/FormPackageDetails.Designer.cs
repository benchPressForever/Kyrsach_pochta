namespace kyrsach_pochta
{
    partial class FormPackageDetails
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
            this.IdOtpr = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TrackNumber = new System.Windows.Forms.Label();
            this.Type = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.Sender = new System.Windows.Forms.Label();
            this.Recipient = new System.Windows.Forms.Label();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.mySqlConnection = new System.Data.SqlClient.SqlConnection();
            this.dataGridViewStatus = new System.Windows.Forms.DataGridView();
            this.currentStatus = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(154, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Отправление  № ";
            // 
            // IdOtpr
            // 
            this.IdOtpr.AutoSize = true;
            this.IdOtpr.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.IdOtpr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IdOtpr.Location = new System.Drawing.Point(316, 22);
            this.IdOtpr.Name = "IdOtpr";
            this.IdOtpr.Size = new System.Drawing.Size(0, 24);
            this.IdOtpr.TabIndex = 1;
            this.IdOtpr.Click += new System.EventHandler(this.IdOtpr_Click);
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelId.Location = new System.Drawing.Point(336, 22);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(0, 24);
            this.labelId.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.currentStatus);
            this.groupBox1.Controls.Add(this.Recipient);
            this.groupBox1.Controls.Add(this.Sender);
            this.groupBox1.Controls.Add(this.Date);
            this.groupBox1.Controls.Add(this.Type);
            this.groupBox1.Controls.Add(this.TrackNumber);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.labelPrice);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(524, 280);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Информация об отправлении";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewStatus);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(12, 354);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(524, 268);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "История статусов";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(7, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Трек-номер:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(7, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Вид:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(7, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Дата приёма:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(7, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Отправитель:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(7, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Получатель:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(7, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(302, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Вес /  Ценность  /  Стоимость доставки";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(7, 213);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(0, 16);
            this.labelPrice.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(10, 249);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Текущий статус:";
            // 
            // TrackNumber
            // 
            this.TrackNumber.AutoSize = true;
            this.TrackNumber.Location = new System.Drawing.Point(156, 22);
            this.TrackNumber.Name = "TrackNumber";
            this.TrackNumber.Size = new System.Drawing.Size(44, 16);
            this.TrackNumber.TabIndex = 8;
            this.TrackNumber.Text = "label9";
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.Location = new System.Drawing.Point(156, 54);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(44, 16);
            this.Type.TabIndex = 9;
            this.Type.Text = "label9";
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Location = new System.Drawing.Point(156, 82);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(44, 16);
            this.Date.TabIndex = 10;
            this.Date.Text = "label9";
            // 
            // Sender
            // 
            this.Sender.AutoSize = true;
            this.Sender.Location = new System.Drawing.Point(156, 120);
            this.Sender.Name = "Sender";
            this.Sender.Size = new System.Drawing.Size(44, 16);
            this.Sender.TabIndex = 11;
            this.Sender.Text = "label9";
            // 
            // Recipient
            // 
            this.Recipient.AutoSize = true;
            this.Recipient.Location = new System.Drawing.Point(156, 151);
            this.Recipient.Name = "Recipient";
            this.Recipient.Size = new System.Drawing.Size(44, 16);
            this.Recipient.TabIndex = 12;
            this.Recipient.Text = "label9";
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.Connection = this.mySqlConnection;
            // 
            // mySqlConnection
            // 
            this.mySqlConnection.ConnectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=kyrsach;Integrated Security=True" +
    ";Encrypt=False";
            this.mySqlConnection.FireInfoMessageEventOnUserErrors = false;
            // 
            // dataGridViewStatus
            // 
            this.dataGridViewStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStatus.Location = new System.Drawing.Point(0, 22);
            this.dataGridViewStatus.Name = "dataGridViewStatus";
            this.dataGridViewStatus.Size = new System.Drawing.Size(524, 246);
            this.dataGridViewStatus.TabIndex = 0;
            // 
            // currentStatus
            // 
            this.currentStatus.AutoSize = true;
            this.currentStatus.Location = new System.Drawing.Point(156, 249);
            this.currentStatus.Name = "currentStatus";
            this.currentStatus.Size = new System.Drawing.Size(44, 16);
            this.currentStatus.TabIndex = 13;
            this.currentStatus.Text = "label9";
            // 
            // FormPackageDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 632);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.IdOtpr);
            this.Controls.Add(this.label1);
            this.Name = "FormPackageDetails";
            this.Text = "FormPackageDetails";
            this.Load += new System.EventHandler(this.FormPackageDetails_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label IdOtpr;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label Sender;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Label Type;
        private System.Windows.Forms.Label TrackNumber;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Recipient;
        private System.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Data.SqlClient.SqlConnection mySqlConnection;
        private System.Windows.Forms.DataGridView dataGridViewStatus;
        private System.Windows.Forms.Label currentStatus;
    }
}