namespace kyrsach_pochta
{
    partial class LoginClientForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.button1exit = new System.Windows.Forms.Button();
            this.button2login = new System.Windows.Forms.Button();
            this.kyrsachDataSet = new kyrsach_pochta.kyrsachDataSet();
            this.клиентBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.клиентTableAdapter = new kyrsach_pochta.kyrsachDataSetTableAdapters.КлиентTableAdapter();
            this.tableAdapterManager = new kyrsach_pochta.kyrsachDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.kyrsachDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(79, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Авторизация";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(26, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Пароль:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(26, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Почта:";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmailTextBox.Location = new System.Drawing.Point(135, 112);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(145, 26);
            this.EmailTextBox.TabIndex = 3;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordTextBox.Location = new System.Drawing.Point(135, 162);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(145, 26);
            this.PasswordTextBox.TabIndex = 4;
            // 
            // button1exit
            // 
            this.button1exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1exit.Location = new System.Drawing.Point(30, 215);
            this.button1exit.Name = "button1exit";
            this.button1exit.Size = new System.Drawing.Size(75, 30);
            this.button1exit.TabIndex = 5;
            this.button1exit.Text = "Назад";
            this.button1exit.UseVisualStyleBackColor = true;
            this.button1exit.Click += new System.EventHandler(this.button1exit_Click);
            // 
            // button2login
            // 
            this.button2login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2login.Location = new System.Drawing.Point(129, 215);
            this.button2login.Name = "button2login";
            this.button2login.Size = new System.Drawing.Size(151, 30);
            this.button2login.TabIndex = 6;
            this.button2login.Text = "Авторизоваться";
            this.button2login.UseVisualStyleBackColor = true;
            this.button2login.Click += new System.EventHandler(this.button2login_Click);
            // 
            // kyrsachDataSet
            // 
            this.kyrsachDataSet.DataSetName = "kyrsachDataSet";
            this.kyrsachDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // клиентBindingSource
            // 
            this.клиентBindingSource.DataMember = "Клиент";
            this.клиентBindingSource.DataSource = this.kyrsachDataSet;
            // 
            // клиентTableAdapter
            // 
            this.клиентTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = kyrsach_pochta.kyrsachDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.КлиентTableAdapter = this.клиентTableAdapter;
            this.tableAdapterManager.Курьерский_заказTableAdapter = null;
            this.tableAdapterManager.ОтправлениеTableAdapter = null;
            this.tableAdapterManager.Периодическое_изданиеTableAdapter = null;
            this.tableAdapterManager.Подписка_на_изданиеTableAdapter = null;
            this.tableAdapterManager.СотрудникTableAdapter = null;
            this.tableAdapterManager.Статус_отправленияTableAdapter = null;
            // 
            // LoginClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 271);
            this.Controls.Add(this.button2login);
            this.Controls.Add(this.button1exit);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoginClientForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LoginClientForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kyrsachDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Button button1exit;
        private System.Windows.Forms.Button button2login;
        private kyrsachDataSet kyrsachDataSet;
        private System.Windows.Forms.BindingSource клиентBindingSource;
        private kyrsachDataSetTableAdapters.КлиентTableAdapter клиентTableAdapter;
        private kyrsachDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}