using System.Data;
using System.Data.SqlClient;

namespace TelephoneDirectoryApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-RPEDS99\SQLEXPRESS;Initial Catalog=TelephoneDirectoryDb;Integrated Security=True");
        SqlCommand sqlCommand;
        private void txtLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text != "" || txtPassword.Text != "")
            {
                string username, password;
                username = txtUserName.Text;
                password = txtPassword.Text;
                connection.Open();
                try
                {
                    sqlCommand = new("SELECT * FROM Users WHERE UserName = '" + username + "' AND Password = '" + password + "'", connection);
                    SqlDataReader read = sqlCommand.ExecuteReader();
                    if (read.Read())
                    {
                        values.userid = read[0].ToString();
                        MessageBox.Show("Login Succes");
                        this.Size = new Size(680, 360);
                        panel1.Visible = false;
                        panel2.Visible = true;
                        panel3.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("User Not Found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtUserName.Clear();
                        txtPassword.Clear();
                        txtUserName.Focus();
                    }
                }
                catch { MessageBox.Show("Sql Connection Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                finally { connection.Close(); }
            }
            else MessageBox.Show("Please enter user name and password", "Login failed ", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
        Values values = new Values();
        private void btnList_Click(object sender, EventArgs e)
        {
            //int userid = Convert.ToInt32(label3.Text);

            //int userid2 = values.userid;
            this.dgList.DataSource = null;
            this.dgList.Rows.Clear();

            try
            {
                connection.Open();
                sqlCommand = new("SELECT * FROM Phones WHERE UserId = '" + values.userid + "'", connection);
                SqlDataReader sqlDR = sqlCommand.ExecuteReader();
                while (sqlDR.Read())
                {
                    string id = sqlDR[0].ToString();
                    string userId = sqlDR[1].ToString();
                    string name = sqlDR[2].ToString();
                    string lastName = sqlDR[3].ToString();
                    string phone = sqlDR[4].ToString();
                    string city = sqlDR[5].ToString();
                    string town = sqlDR[6].ToString();

                    dgList.ReadOnly = true;
                    dgList.AllowUserToDeleteRows = false;
                    dgList.ColumnCount = 6;
                    dgList.Columns[0].Name = "Id";
                    dgList.Columns[0].Width = 50;
                    //dgList.Columns[1].Name = "UserId";
                    //dgList.Columns[1].Width = 50;
                    dgList.Columns[1].Name = "FirstName";
                    dgList.Columns[1].Width = 125;
                    dgList.Columns[2].Name = "LastName";
                    dgList.Columns[2].Width = 125;
                    dgList.Columns[3].Name = "Phone";
                    dgList.Columns[3].Width = 125;
                    dgList.Columns[4].Name = "City";
                    dgList.Columns[4].Width = 100;
                    dgList.Columns[5].Name = "Town";
                    dgList.Columns[5].Width = 100;

                    dgList.Rows.Add(id, name, lastName, phone, city, town);
                }
            }
            catch
            {
                MessageBox.Show("Sql Connection Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtLastName.Clear();
            txtPhone.Clear();
            txtCity.Clear();
            txtTown.Clear();
            label3.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new Size(330, 145);
        }

        class Values
        {
            public string userid { get; set; }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtLastName.Text != "" && txtPhone.Text != "" && txtCity.Text != "" && txtTown.Text != "")
            {
                connection.Open();
                sqlCommand = new("INSERT INTO Phones (UserId, FirstName, LastName, Phone, City, Town) VALUES(@p1, @p2, @p3, @p4, @p5, @p6)", connection);
                sqlCommand.Parameters.AddWithValue("@p1", values.userid);
                sqlCommand.Parameters.AddWithValue("@p2", txtName.Text);
                sqlCommand.Parameters.AddWithValue("@p3", txtLastName.Text);
                sqlCommand.Parameters.AddWithValue("@p4", txtPhone.Text);
                sqlCommand.Parameters.AddWithValue("@p5", txtCity.Text);
                sqlCommand.Parameters.AddWithValue("@p6", txtTown.Text);
                sqlCommand.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Register Add","Register Succes",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);

            }
            else MessageBox.Show("Please fill out all fields!!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("The selected record will be deleted from the database.\nDo you want to proceed?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                connection.Open();
                sqlCommand = new("DELETE FROM Phones WHERE Id=@k1", connection);
                sqlCommand.Parameters.AddWithValue("@k1", label3.Text);
                sqlCommand.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("The selected record has been deleted from the database.");
            }
        }

        private void dgList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int choice = dgList.SelectedCells[0].RowIndex;
            label3.Text = dgList.Rows[choice].Cells[0].Value.ToString();
            txtName.Text = dgList.Rows[choice].Cells[1].Value.ToString();
            txtLastName.Text = dgList.Rows[choice].Cells[2].Value.ToString();
            txtPhone.Text = dgList.Rows[choice].Cells[3].Value.ToString();
            txtCity.Text = dgList.Rows[choice].Cells[4].Value.ToString();
            txtTown.Text = dgList.Rows[choice].Cells[5].Value.ToString();

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text != "" || txtPassword.Text != "")
            {
                string username, password;
                username = txtUserName.Text;
                password = txtPassword.Text;
                connection.Open();
                try
                {
                    sqlCommand = new("SELECT * FROM Users WHERE UserName = '" + username + "'", connection);
                    SqlDataReader read = sqlCommand.ExecuteReader();
                    if (read.Read())
                    {
                        MessageBox.Show("Someone with this username already exists.\nPlease enter a different username.");
                    }
                    else
                    {
                        read.Close();
                        SqlCommand add = new("INSERT INTO Users(UserName, Password) VALUES('" + username + "', '" + password + "')", connection);
                        add.ExecuteNonQuery();
                        MessageBox.Show("Registration successful.");
                    }
                }
                catch { MessageBox.Show("Sql Connection Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                finally { connection.Close(); }
            }
            else MessageBox.Show("Please enter user name and password", "Register not created", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtLastName.Text != "" && txtPhone.Text != "" && txtCity.Text != "" && txtTown.Text != "")
            {
                connection.Open();
                sqlCommand = new("UPDATE Phones SET FirstName = @p1, LastName = @p2, Phone = @p3, City = @p4, Town = @p5 WHERE Id = @p6", connection);
                sqlCommand.Parameters.AddWithValue("@p1", txtName.Text);
                sqlCommand.Parameters.AddWithValue("@p2", txtLastName.Text);
                sqlCommand.Parameters.AddWithValue("@p3", txtPhone.Text);
                sqlCommand.Parameters.AddWithValue("@p4", txtCity.Text);
                sqlCommand.Parameters.AddWithValue("@p5", txtTown.Text);
                sqlCommand.Parameters.AddWithValue("@p6", label3.Text);
                sqlCommand.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Register Update", "Update Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else MessageBox.Show("Please fill out all fields!!","Attention",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }
    }
}