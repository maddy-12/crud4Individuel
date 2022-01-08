using CrudBloc4.Views;
using CrudBloc4.Views.ManageDepartment;
using CrudBloc4.Views.ManageEmployee;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudBloc4
{
    public partial class FormApplication : Form
    {
        public FormApplication()
        {
            InitializeComponent();
        }

        private void gérerLesSiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SiteForm form = new SiteForm();
            form.Show();
        }

        private void gérerLesServicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DepartmentForm form = new DepartmentForm();
            form.Show();
        }

        private void gestionDesSalariésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeForm form = new EmployeeForm();
            form.Show();
        }

        private void FormApplication_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'database_projet4DataSet1.Department'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.departmentTableAdapter.Fill(this.database_projet4DataSet1.Department);
            // TODO: cette ligne de code charge les données dans la table 'database_projet4DataSet.Site'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.siteTableAdapter.Fill(this.database_projet4DataSet.Site);

        }
    }
}
