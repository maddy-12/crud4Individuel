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
    }
}
