namespace kyrsach_pochta
{
    partial class LoginEmployeeForm
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
            this.button3login = new System.Windows.Forms.Button();
            this.button2exit = new System.Windows.Forms.Button();
            this.PasswordTextBox2 = new System.Windows.Forms.TextBox();
            this.EmailTextBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Label = new System.Windows.Forms.Label();
            this.kyrsachDataSet = new kyrsach_pochta.kyrsachDataSet();
            this.сотрудникBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.сотрудникTableAdapter = new kyrsach_pochta.kyrsachDataSetTableAdapters.СотрудникTableAdapter();
            this.tableAdapterManager = new kyrsach_pochta.kyrsachDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.kyrsachDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button3login
            // 
            this.button3login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3login.Location = new System.Drawing.Point(146, 200);
            this.button3login.Name = "button3login";
            this.button3login.Size = new System.Drawing.Size(151, 30);
            this.button3login.TabIndex = 13;
            this.button3login.Text = "Авторизоваться";
            this.button3login.UseVisualStyleBackColor = true;
            this.button3login.Click += new System.EventHandler(this.button2login_Click);
            // 
            // button2exit
            // 
            this.button2exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2exit.Location = new System.Drawing.Point(39, 200);
            this.button2exit.Name = "button2exit";
            this.button2exit.Size = new System.Drawing.Size(75, 30);
            this.button2exit.TabIndex = 12;
            this.button2exit.Text = "Назад";
            this.button2exit.UseVisualStyleBackColor = true;
            this.button2exit.Click += new System.EventHandler(this.button1exit_Click);
            // 
            // PasswordTextBox2
            // 
            this.PasswordTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordTextBox2.Location = new System.Drawing.Point(152, 151);
            this.PasswordTextBox2.Name = "PasswordTextBox2";
            this.PasswordTextBox2.Size = new System.Drawing.Size(145, 26);
            this.PasswordTextBox2.TabIndex = 11;
            // 
            // EmailTextBox2
            // 
            this.EmailTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmailTextBox2.Location = new System.Drawing.Point(152, 101);
            this.EmailTextBox2.Name = "EmailTextBox2";
            this.EmailTextBox2.Size = new System.Drawing.Size(145, 26);
            this.EmailTextBox2.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(43, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Логин:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(43, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Пароль:";
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label.Location = new System.Drawing.Point(101, 42);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(141, 25);
            this.Label.TabIndex = 7;
            this.Label.Text = "Авторизация";
            // 
            // kyrsachDataSet
            // 
            this.kyrsachDataSet.DataSetName = "kyrsachDataSet";
            this.kyrsachDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // сотрудникBindingSource
            // 
            this.сотрудникBindingSource.DataMember = "Сотрудник";
            this.сотрудникBindingSource.DataSource = this.kyrsachDataSet;
            // 
            // сотрудникTableAdapter
            // 
            this.сотрудникTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = kyrsach_pochta.kyrsachDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.КлиентTableAdapter = null;
            this.tableAdapterManager.Курьерский_заказTableAdapter = null;
            this.tableAdapterManager.ОтправлениеTableAdapter = null;
            this.tableAdapterManager.Периодическое_изданиеTableAdapter = null;
            this.tableAdapterManager.Подписка_на_изданиеTableAdapter = null;
            this.tableAdapterManager.СотрудникTableAdapter = this.сотрудникTableAdapter;
            this.tableAdapterManager.Статус_отправленияTableAdapter = null;
            // 
            // LoginEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 247);
            this.Controls.Add(this.button3login);
            this.Controls.Add(this.button2exit);
            this.Controls.Add(this.PasswordTextBox2);
            this.Controls.Add(this.EmailTextBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Label);
            this.Name = "LoginEmployeeForm";
            this.Text = "LoginEmployeeForm";
            this.Load += new System.EventHandler(this.LoginEmployeeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kyrsachDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3login;
        private System.Windows.Forms.Button button2exit;
        private System.Windows.Forms.TextBox PasswordTextBox2;
        private System.Windows.Forms.TextBox EmailTextBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Label;
        private kyrsachDataSet kyrsachDataSet;
        private System.Windows.Forms.BindingSource сотрудникBindingSource;
        private kyrsachDataSetTableAdapters.СотрудникTableAdapter сотрудникTableAdapter;
        private kyrsachDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}