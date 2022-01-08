﻿using System;
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
                SqlCommand sqlCmd = new SqlCommand("EmplAdd", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@IdEmpl", emplId);
                sqlCmd.Parameters.AddWithValue("@nameEmpl", txt_nameEmp.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@firstNameEmpl", txt_FNameEmp.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@phoneEmpl", txt_phoneEmp.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@mobileEmpl", txt_mobileEmpl.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@emailEmpl", txt_emailEmp.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@IdDep", comboBox_dept.SelectedValue);
                sqlCmd.Parameters.AddWithValue("@IdSite", comboBox_site.SelectedValue);
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Salarié ajouté avec succès");
                GridFill();
            }
        }

        //Afficher dans le Grid
        
        void GridFill()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("EmplViewAll", sqlCon);
                sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dataTableEmpl = new DataTable();
                sqlDataAdapter.Fill(dataTableEmpl);
                dtgvEmpl.DataSource = dataTableEmpl;
                //dtgvEmpl.Columns[0].Visible = false; //Cacher ID
            }
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'database_projet4DataSet.Site'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.siteTableAdapter.Fill(this.database_projet4DataSet.Site);
            // TODO: cette ligne de code charge les données dans la table 'database_projet4DataSet1.Department'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.departmentTableAdapter.Fill(this.database_projet4DataSet1.Department);
            GridFill();

        }
    }
}
