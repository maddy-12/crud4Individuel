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

namespace CrudBloc4.Views.ManageDepartment
{
    public partial class DepartmentManage : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Benaf\OneDrive\Documents\Cours cesi\projetBloc4Individuel\database_projet4.mdf;Integrated Security=True;Connect Timeout=30";
        private int Id = 0;
        public DepartmentManage()
        {
            InitializeComponent();
        }

        //Ajouter un Service
        private void btnAddDep_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {           
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("DepAdd", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@IdDep", Id);
                sqlCmd.Parameters.AddWithValue("@depName", txt_DeptName.Text.Trim());
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Service ajouté avec succès");
                GridFill(); 
                Clear();
            }
        }

        //Afficher les services dans le Grid
        void GridFill()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("DepViewAll", sqlCon);
                sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dataTableDept = new DataTable();
                sqlDataAdapter.Fill(dataTableDept);
                dtgvDep.DataSource = dataTableDept;
                dtgvDep.Columns[0].Visible = false; //Cacher la colonne ID
            }
        }

        private void DepartmentManage_Load(object sender, EventArgs e)
        {
            Clear();
            GridFill();
        }

        void Clear()
        {
            txt_DeptName.Text = "";
            Id = 0;
            btnAddDep.Text = "Ajouter";
            btnDeleteDep.Enabled = false;
        }

        private void dtgvDep_DoubleClick(object sender, EventArgs e)
        {
            if (dtgvDep.CurrentRow.Index != -1)//Verifier si la ligne est dans la grid View
            {
                txt_DeptName.Text = dtgvDep.CurrentRow.Cells[1].Value.ToString();
                Id = Convert.ToInt32(dtgvDep.CurrentRow.Cells[0].Value.ToString());
                btnDeleteDep.Enabled = true;
            }
        }

        private void btnCancelDep_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnUpdateDep_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteDep_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {   
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("DepAdd", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@IdDep", Id);
                sqlCmd.Parameters.AddWithValue("@depName", txt_DeptName.Text.Trim());
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Service supprimer avec succès");
                GridFill();
                Clear();
            }
        }

    }
}
