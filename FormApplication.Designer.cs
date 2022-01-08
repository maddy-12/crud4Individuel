
namespace CrudBloc4
{
    partial class FormApplication
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sitesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gérerLesSiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.servicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gérerLesServicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salariésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesSalariésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_searchHome = new System.Windows.Forms.TextBox();
            this.btn_searchHome = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.siteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.database_projet4DataSet = new CrudBloc4.database_projet4DataSet();
            this.siteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database_projet4DataSet1 = new CrudBloc4.database_projet4DataSet1();
            this.siteTableAdapter = new CrudBloc4.database_projet4DataSetTableAdapters.SiteTableAdapter();
            this.departmentTableAdapter = new CrudBloc4.database_projet4DataSet1TableAdapters.DepartmentTableAdapter();
            this.database_projet4DataSet2 = new CrudBloc4.database_projet4DataSet2();
            this.database_projet4DataSet3 = new CrudBloc4.database_projet4DataSet3();
            this.databaseprojet4DataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtgv_home = new System.Windows.Forms.DataGridView();
            this.emplViewAllBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emplViewAllTableAdapter = new CrudBloc4.database_projet4DataSet3TableAdapters.EmplViewAllTableAdapter();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter = new CrudBloc4.database_projet4DataSet3TableAdapters.EmployeeTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonenumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobilenumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iddepartmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idsiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siteBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database_projet4DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database_projet4DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database_projet4DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database_projet4DataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseprojet4DataSet3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_home)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emplViewAllBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sitesToolStripMenuItem,
            this.servicesToolStripMenuItem,
            this.salariésToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sitesToolStripMenuItem
            // 
            this.sitesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gérerLesSiteToolStripMenuItem});
            this.sitesToolStripMenuItem.Name = "sitesToolStripMenuItem";
            this.sitesToolStripMenuItem.Size = new System.Drawing.Size(54, 24);
            this.sitesToolStripMenuItem.Text = "Sites";
            // 
            // gérerLesSiteToolStripMenuItem
            // 
            this.gérerLesSiteToolStripMenuItem.Name = "gérerLesSiteToolStripMenuItem";
            this.gérerLesSiteToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.gérerLesSiteToolStripMenuItem.Text = "Gérer les Site";
            this.gérerLesSiteToolStripMenuItem.Click += new System.EventHandler(this.gérerLesSiteToolStripMenuItem_Click);
            // 
            // servicesToolStripMenuItem
            // 
            this.servicesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gérerLesServicesToolStripMenuItem});
            this.servicesToolStripMenuItem.Name = "servicesToolStripMenuItem";
            this.servicesToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.servicesToolStripMenuItem.Text = "Services";
            // 
            // gérerLesServicesToolStripMenuItem
            // 
            this.gérerLesServicesToolStripMenuItem.Name = "gérerLesServicesToolStripMenuItem";
            this.gérerLesServicesToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.gérerLesServicesToolStripMenuItem.Text = "Gérer les services";
            this.gérerLesServicesToolStripMenuItem.Click += new System.EventHandler(this.gérerLesServicesToolStripMenuItem_Click);
            // 
            // salariésToolStripMenuItem
            // 
            this.salariésToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDesSalariésToolStripMenuItem});
            this.salariésToolStripMenuItem.Name = "salariésToolStripMenuItem";
            this.salariésToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.salariésToolStripMenuItem.Text = "Salariés";
            // 
            // gestionDesSalariésToolStripMenuItem
            // 
            this.gestionDesSalariésToolStripMenuItem.Name = "gestionDesSalariésToolStripMenuItem";
            this.gestionDesSalariésToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.gestionDesSalariésToolStripMenuItem.Text = "Gestion des salariés";
            this.gestionDesSalariésToolStripMenuItem.Click += new System.EventHandler(this.gestionDesSalariésToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(309, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Annuaire";
            // 
            // txt_searchHome
            // 
            this.txt_searchHome.Location = new System.Drawing.Point(204, 124);
            this.txt_searchHome.Name = "txt_searchHome";
            this.txt_searchHome.Size = new System.Drawing.Size(327, 22);
            this.txt_searchHome.TabIndex = 2;
            // 
            // btn_searchHome
            // 
            this.btn_searchHome.BackColor = System.Drawing.Color.MediumPurple;
            this.btn_searchHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_searchHome.ForeColor = System.Drawing.Color.White;
            this.btn_searchHome.Location = new System.Drawing.Point(555, 116);
            this.btn_searchHome.Name = "btn_searchHome";
            this.btn_searchHome.Size = new System.Drawing.Size(128, 35);
            this.btn_searchHome.TabIndex = 3;
            this.btn_searchHome.Text = "Rechercher";
            this.btn_searchHome.UseVisualStyleBackColor = false;
            this.btn_searchHome.Click += new System.EventHandler(this.btn_searchHome_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(83, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Rechercher";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sites ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(453, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Service";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.siteBindingSource1, "Id", true));
            this.comboBox1.DataSource = this.siteBindingSource;
            this.comboBox1.DisplayMember = "city_name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(100, 166);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(218, 24);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.ValueMember = "Id";
            // 
            // siteBindingSource1
            // 
            this.siteBindingSource1.DataMember = "Site";
            this.siteBindingSource1.DataSource = this.database_projet4DataSet;
            // 
            // database_projet4DataSet
            // 
            this.database_projet4DataSet.DataSetName = "database_projet4DataSet";
            this.database_projet4DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // siteBindingSource
            // 
            this.siteBindingSource.DataMember = "Site";
            this.siteBindingSource.DataSource = this.database_projet4DataSet;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.departmentBindingSource;
            this.comboBox2.DisplayMember = "department";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(528, 169);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(218, 24);
            this.comboBox2.TabIndex = 10;
            this.comboBox2.ValueMember = "Id";
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataMember = "Department";
            this.departmentBindingSource.DataSource = this.database_projet4DataSet1;
            // 
            // database_projet4DataSet1
            // 
            this.database_projet4DataSet1.DataSetName = "database_projet4DataSet1";
            this.database_projet4DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // siteTableAdapter
            // 
            this.siteTableAdapter.ClearBeforeFill = true;
            // 
            // departmentTableAdapter
            // 
            this.departmentTableAdapter.ClearBeforeFill = true;
            // 
            // database_projet4DataSet2
            // 
            this.database_projet4DataSet2.DataSetName = "database_projet4DataSet2";
            this.database_projet4DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // database_projet4DataSet3
            // 
            this.database_projet4DataSet3.DataSetName = "database_projet4DataSet3";
            this.database_projet4DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // databaseprojet4DataSet3BindingSource
            // 
            this.databaseprojet4DataSet3BindingSource.DataSource = this.database_projet4DataSet3;
            this.databaseprojet4DataSet3BindingSource.Position = 0;
            // 
            // dtgv_home
            // 
            this.dtgv_home.AllowUserToAddRows = false;
            this.dtgv_home.AllowUserToDeleteRows = false;
            this.dtgv_home.AutoGenerateColumns = false;
            this.dtgv_home.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_home.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.firstnameDataGridViewTextBoxColumn,
            this.phonenumberDataGridViewTextBoxColumn,
            this.mobilenumberDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.iddepartmentDataGridViewTextBoxColumn,
            this.idsiteDataGridViewTextBoxColumn});
            this.dtgv_home.DataSource = this.emplViewAllBindingSource;
            this.dtgv_home.Location = new System.Drawing.Point(54, 223);
            this.dtgv_home.Name = "dtgv_home";
            this.dtgv_home.ReadOnly = true;
            this.dtgv_home.RowHeadersWidth = 51;
            this.dtgv_home.RowTemplate.Height = 24;
            this.dtgv_home.Size = new System.Drawing.Size(691, 187);
            this.dtgv_home.TabIndex = 11;
            // 
            // emplViewAllBindingSource
            // 
            this.emplViewAllBindingSource.DataMember = "EmplViewAll";
            this.emplViewAllBindingSource.DataSource = this.databaseprojet4DataSet3BindingSource;
            // 
            // emplViewAllTableAdapter
            // 
            this.emplViewAllTableAdapter.ClearBeforeFill = true;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.databaseprojet4DataSet3BindingSource;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "first_name";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "first_name";
            this.firstnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            this.firstnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.firstnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // phonenumberDataGridViewTextBoxColumn
            // 
            this.phonenumberDataGridViewTextBoxColumn.DataPropertyName = "phone_number";
            this.phonenumberDataGridViewTextBoxColumn.HeaderText = "phone_number";
            this.phonenumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phonenumberDataGridViewTextBoxColumn.Name = "phonenumberDataGridViewTextBoxColumn";
            this.phonenumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.phonenumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // mobilenumberDataGridViewTextBoxColumn
            // 
            this.mobilenumberDataGridViewTextBoxColumn.DataPropertyName = "mobile_number";
            this.mobilenumberDataGridViewTextBoxColumn.HeaderText = "mobile_number";
            this.mobilenumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mobilenumberDataGridViewTextBoxColumn.Name = "mobilenumberDataGridViewTextBoxColumn";
            this.mobilenumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.mobilenumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // iddepartmentDataGridViewTextBoxColumn
            // 
            this.iddepartmentDataGridViewTextBoxColumn.DataPropertyName = "id_department";
            this.iddepartmentDataGridViewTextBoxColumn.HeaderText = "id_department";
            this.iddepartmentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iddepartmentDataGridViewTextBoxColumn.Name = "iddepartmentDataGridViewTextBoxColumn";
            this.iddepartmentDataGridViewTextBoxColumn.ReadOnly = true;
            this.iddepartmentDataGridViewTextBoxColumn.Width = 125;
            // 
            // idsiteDataGridViewTextBoxColumn
            // 
            this.idsiteDataGridViewTextBoxColumn.DataPropertyName = "id_site";
            this.idsiteDataGridViewTextBoxColumn.HeaderText = "id_site";
            this.idsiteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idsiteDataGridViewTextBoxColumn.Name = "idsiteDataGridViewTextBoxColumn";
            this.idsiteDataGridViewTextBoxColumn.ReadOnly = true;
            this.idsiteDataGridViewTextBoxColumn.Width = 125;
            // 
            // FormApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtgv_home);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_searchHome);
            this.Controls.Add(this.txt_searchHome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormApplication";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormApplication_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siteBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database_projet4DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database_projet4DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database_projet4DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database_projet4DataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseprojet4DataSet3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_home)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emplViewAllBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sitesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gérerLesSiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem servicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gérerLesServicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salariésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesSalariésToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_searchHome;
        private System.Windows.Forms.Button btn_searchHome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private database_projet4DataSet database_projet4DataSet;
        private System.Windows.Forms.BindingSource siteBindingSource;
        private database_projet4DataSetTableAdapters.SiteTableAdapter siteTableAdapter;
        private System.Windows.Forms.BindingSource siteBindingSource1;
        private database_projet4DataSet1 database_projet4DataSet1;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private database_projet4DataSet1TableAdapters.DepartmentTableAdapter departmentTableAdapter;
        private database_projet4DataSet2 database_projet4DataSet2;
        private database_projet4DataSet3 database_projet4DataSet3;
        private System.Windows.Forms.BindingSource databaseprojet4DataSet3BindingSource;
        private System.Windows.Forms.DataGridView dtgv_home;
        private System.Windows.Forms.BindingSource emplViewAllBindingSource;
        private database_projet4DataSet3TableAdapters.EmplViewAllTableAdapter emplViewAllTableAdapter;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private database_projet4DataSet3TableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonenumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobilenumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddepartmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idsiteDataGridViewTextBoxColumn;
    }
}

