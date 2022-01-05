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
        private int depId = 0;
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
                SqlCommand SqlCmd = new SqlCommand("DepAdd", sqlCon);
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlCmd.Parameters.AddWithValue("@depName", depId);
                SqlCmd.ExecuteNonQuery();
                MessageBox.Show("Service ajouté avec succès");
                GridFill();
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
                //dtgvDep.Columns[0].Visible = false; //Cacher la colonne ID
            }
        }

        private void DepartmentManage_Load(object sender, EventArgs e)
        {
            GridFill();
        }
    }
}
