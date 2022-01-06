using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CrudBloc4.Views.ManageEmployee
{
    public partial class EmployeeForm : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Benaf\OneDrive\Documents\Cours cesi\projetBloc4Individuel\database_projet4.mdf;Integrated Security=True;Connect Timeout=30";
        int emplId = 0;
        public EmployeeForm()
        {
            InitializeComponent();
        }

        //Ajouter un employé
        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("EmplAdd");
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@IdEmpl", emplId);
                sqlCmd.Parameters.AddWithValue("@nameEmpl", txt_nameEmp.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@firstNameEmpl", txt_FNameEmp.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@phoneEmpl", txt_phoneEmp.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@mobileEmpl", txt_mobileEmpl.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@emailEmpl", txt_emailEmp.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@IdDep", listBox_Service);
                sqlCmd.Parameters.AddWithValue("@IdSite", listBox_site);
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Salarié ajouté avec succès");


            }
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
