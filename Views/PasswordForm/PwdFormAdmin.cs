using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudBloc4.Views.PasswordForm
{
    public partial class PwdFormAdmin : Form
    {
        public PwdFormAdmin()
        {
            InitializeComponent();
        }

        public bool btn_password_clicked { get; private set; }

        private void btn_password_Click(object sender, EventArgs e)
        {
            if (txt_password.Text == "adminPassword")
            {
               FormApplication form = new FormApplication();
               form.menuStrip1.Visible = true;
               this.Hide();
               form.Show();
            } else if (txt_password.Text == "")
            {
                MessageBox.Show("vide");
            } else
            {
                MessageBox.Show("Faux");
            }
        }

        private void PwdFormAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
