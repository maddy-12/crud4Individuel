using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudBloc4.Views
{
    public partial class SiteForm : Form
    {
        //Connexion à la BDD
       string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Benaf\OneDrive\Documents\Cours cesi\projetBloc4Individuel\database_projet4.mdf;Integrated Security=True;Connect Timeout=30";
        private int Id = 0;
        public SiteForm()
        {
            InitializeComponent();
        }
        //Ajouter
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // using ferme la connexion vu qu'on fait la connexion dedans
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("SiteAddOrEdit", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@Id", Id);
                sqlCmd.Parameters.AddWithValue("@city_name", txt_cityName.Text.Trim());
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Site ajouté avec succès");
                Clear();
                GridFill();
            }  
        }

        //Afficher les information dans le grid
        void GridFill()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SiteViewAll", sqlCon);
                sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dataTableSite = new DataTable();
                sqlDataAdapter.Fill(dataTableSite);
                dtgvSite.DataSource = dataTableSite;
                dtgvSite.Columns[0].Visible = false; //Cacher la colonne ID
            }
        }
        
        private void SiteForm_Load(object sender, EventArgs e)
        {
            Clear();
            GridFill();
        }

        //Vider les champs après l'enregistrement de la donnée
        void Clear()
        {
            txt_cityName.Text = "";
            Id = 0;
            btnAdd.Text = "Ajouter";
            btnDelete.Enabled = false;
        }

        //Modifier
        private void dtgvSite_DoubleClick(object sender, EventArgs e)
        {
            if (dtgvSite.CurrentRow.Index != -1)//Verifier si la ligne est dans la grid View
            {
                txt_cityName.Text = dtgvSite.CurrentRow.Cells[1].Value.ToString();
                Id = Convert.ToInt32(dtgvSite.CurrentRow.Cells[0].Value.ToString());
                btnDelete.Enabled = true;
                btnAdd.Text = "Modifier";
            }
        }

        //Annuler
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        //Supprimer
        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("SiteDeleteById", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@Id", Id);
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Site supprimé avec succès");
                Clear();
                GridFill();
            }
        }

    }
}
