namespace TelephoneDirectoryApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            dgList = new DataGridView();
            groupBox1 = new GroupBox();
            btnRegister = new Button();
            btnLogin = new Button();
            label2 = new Label();
            txtPassword = new TextBox();
            label1 = new Label();
            txtUserName = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            label3 = new Label();
            btnClear = new Button();
            btnList = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            lbTown = new Label();
            txtTown = new TextBox();
            lbCity = new Label();
            txtCity = new TextBox();
            lbPhone = new Label();
            txtPhone = new TextBox();
            lbLastName = new Label();
            txtLastName = new TextBox();
            lbName = new Label();
            txtName = new TextBox();
            lbId = new Label();
            ((System.ComponentModel.ISupportInitialize)dgList).BeginInit();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // dgList
            // 
            dgList.AllowUserToAddRows = false;
            dgList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgList.Dock = DockStyle.Fill;
            dgList.Location = new Point(0, 0);
            dgList.Name = "dgList";
            dgList.RowTemplate.Height = 25;
            dgList.Size = new Size(667, 201);
            dgList.TabIndex = 0;
            dgList.CellDoubleClick += dgList_CellDoubleClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnRegister);
            groupBox1.Controls.Add(btnLogin);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtUserName);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(294, 81);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "User Login";
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(213, 45);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(75, 23);
            btnRegister.TabIndex = 9;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(213, 16);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 8;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += txtLogin_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 48);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 6;
            label2.Text = "Password:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(84, 45);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(100, 23);
            txtPassword.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 4;
            label1.Text = "User Name:";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(84, 16);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(100, 23);
            txtUserName.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(667, 106);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgList);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 224);
            panel2.Name = "panel2";
            panel2.Size = new Size(667, 201);
            panel2.TabIndex = 3;
            panel2.Visible = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(label3);
            panel3.Controls.Add(btnClear);
            panel3.Controls.Add(btnList);
            panel3.Controls.Add(btnUpdate);
            panel3.Controls.Add(btnDelete);
            panel3.Controls.Add(btnSave);
            panel3.Controls.Add(lbTown);
            panel3.Controls.Add(txtTown);
            panel3.Controls.Add(lbCity);
            panel3.Controls.Add(txtCity);
            panel3.Controls.Add(lbPhone);
            panel3.Controls.Add(txtPhone);
            panel3.Controls.Add(lbLastName);
            panel3.Controls.Add(txtLastName);
            panel3.Controls.Add(lbName);
            panel3.Controls.Add(txtName);
            panel3.Controls.Add(lbId);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 106);
            panel3.Name = "panel3";
            panel3.Size = new Size(667, 118);
            panel3.TabIndex = 4;
            panel3.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(560, 38);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 30;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(420, 77);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 29;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnList
            // 
            btnList.Location = new Point(177, 77);
            btnList.Name = "btnList";
            btnList.Size = new Size(75, 23);
            btnList.TabIndex = 28;
            btnList.Text = "List";
            btnList.UseVisualStyleBackColor = true;
            btnList.Click += btnList_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(258, 77);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 27;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(339, 77);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 26;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(96, 77);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 25;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // lbTown
            // 
            lbTown.AutoSize = true;
            lbTown.Location = new Point(451, 17);
            lbTown.Name = "lbTown";
            lbTown.Size = new Size(38, 15);
            lbTown.TabIndex = 19;
            lbTown.Text = "Town:";
            // 
            // txtTown
            // 
            txtTown.Location = new Point(451, 35);
            txtTown.Name = "txtTown";
            txtTown.Size = new Size(100, 23);
            txtTown.TabIndex = 20;
            // 
            // lbCity
            // 
            lbCity.AutoSize = true;
            lbCity.Location = new Point(345, 17);
            lbCity.Name = "lbCity";
            lbCity.Size = new Size(31, 15);
            lbCity.TabIndex = 17;
            lbCity.Text = "City:";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(345, 35);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(100, 23);
            txtCity.TabIndex = 18;
            // 
            // lbPhone
            // 
            lbPhone.AutoSize = true;
            lbPhone.Location = new Point(239, 17);
            lbPhone.Name = "lbPhone";
            lbPhone.Size = new Size(44, 15);
            lbPhone.TabIndex = 15;
            lbPhone.Text = "Phone:";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(239, 35);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(100, 23);
            txtPhone.TabIndex = 16;
            // 
            // lbLastName
            // 
            lbLastName.AutoSize = true;
            lbLastName.Location = new Point(133, 18);
            lbLastName.Name = "lbLastName";
            lbLastName.Size = new Size(66, 15);
            lbLastName.TabIndex = 13;
            lbLastName.Text = "Last Name:";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(133, 35);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(100, 23);
            txtLastName.TabIndex = 14;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(27, 17);
            lbName.Name = "lbName";
            lbName.Size = new Size(42, 15);
            lbName.TabIndex = 11;
            lbName.Text = "Name:";
            // 
            // txtName
            // 
            txtName.Location = new Point(27, 35);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 12;
            // 
            // lbId
            // 
            lbId.AutoSize = true;
            lbId.Location = new Point(560, 17);
            lbId.Name = "lbId";
            lbId.Size = new Size(20, 15);
            lbId.TabIndex = 9;
            lbId.Text = "Id:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(667, 320);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Phone Directory";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgList).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgList;
        private GroupBox groupBox1;
        private Button btnLogin;
        private Label label2;
        private TextBox txtPassword;
        private Label label1;
        private TextBox txtUserName;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button btnClear;
        private Button btnList;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnSave;
        private Label lbTown;
        private TextBox txtTown;
        private Label lbCity;
        private TextBox txtCity;
        private Label lbPhone;
        private TextBox txtPhone;
        private Label lbLastName;
        private TextBox txtLastName;
        private Label lbName;
        private TextBox txtName;
        private Label lbId;
        private Label label3;
        private Button btnRegister;
    }
}