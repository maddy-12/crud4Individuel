
namespace CrudBloc4.Views.ManageEmployee
{
    partial class EmployeeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_empFName = new System.Windows.Forms.Label();
            this.lbl_EmpName = new System.Windows.Forms.Label();
            this.lbl_phone = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_mobile = new System.Windows.Forms.Label();
            this.lbl_dept = new System.Windows.Forms.Label();
            this.lbl_site = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_nameEmp = new System.Windows.Forms.TextBox();
            this.txt_FNameEmp = new System.Windows.Forms.TextBox();
            this.txt_phoneEmp = new System.Windows.Forms.TextBox();
            this.txt_mobileEmpl = new System.Windows.Forms.TextBox();
            this.txt_searchEmpl = new System.Windows.Forms.TextBox();
            this.txt_emailEmp = new System.Windows.Forms.TextBox();
            this.btnAddEmp = new System.Windows.Forms.Button();
            this.dtgvEmpl = new System.Windows.Forms.DataGridView();
            this.btnCancelEmp = new System.Windows.Forms.Button();
            this.btnDeleteEmp = new System.Windows.Forms.Button();
            this.btnSearchEmp = new System.Windows.Forms.Button();
            this.comboBox_site = new System.Windows.Forms.ComboBox();
            this.siteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database_projet4DataSet = new CrudBloc4.database_projet4DataSet();
            this.comboBox_dept = new System.Windows.Forms.ComboBox();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database_projet4DataSet1 = new CrudBloc4.database_projet4DataSet1();
            this.databaseprojet4DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departmentTableAdapter = new CrudBloc4.database_projet4DataSet1TableAdapters.DepartmentTableAdapter();
            this.siteTableAdapter = new CrudBloc4.database_projet4DataSetTableAdapters.SiteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEmpl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database_projet4DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database_projet4DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseprojet4DataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(283, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employés";
            // 
            // lbl_empFName
            // 
            this.lbl_empFName.AutoSize = true;
            this.lbl_empFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_empFName.Location = new System.Drawing.Point(57, 127);
            this.lbl_empFName.Name = "lbl_empFName";
            this.lbl_empFName.Size = new System.Drawing.Size(67, 18);
            this.lbl_empFName.TabIndex = 18;
            this.lbl_empFName.Text = "Prénom";
            // 
            // lbl_EmpName
            // 
            this.lbl_EmpName.AutoSize = true;
            this.lbl_EmpName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EmpName.Location = new System.Drawing.Point(57, 75);
            this.lbl_EmpName.Name = "lbl_EmpName";
            this.lbl_EmpName.Size = new System.Drawing.Size(44, 18);
            this.lbl_EmpName.TabIndex = 19;
            this.lbl_EmpName.Text = "Nom";
            // 
            // lbl_phone
            // 
            this.lbl_phone.AutoSize = true;
            this.lbl_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_phone.Location = new System.Drawing.Point(57, 172);
            this.lbl_phone.Name = "lbl_phone";
            this.lbl_phone.Size = new System.Drawing.Size(62, 18);
            this.lbl_phone.TabIndex = 20;
            this.lbl_phone.Text = "Tel fixe";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.Location = new System.Drawing.Point(437, 75);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(50, 18);
            this.lbl_email.TabIndex = 21;
            this.lbl_email.Text = "Email";
            // 
            // lbl_mobile
            // 
            this.lbl_mobile.AutoSize = true;
            this.lbl_mobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mobile.Location = new System.Drawing.Point(58, 220);
            this.lbl_mobile.Name = "lbl_mobile";
            this.lbl_mobile.Size = new System.Drawing.Size(97, 18);
            this.lbl_mobile.TabIndex = 22;
            this.lbl_mobile.Text = "Tel portable";
            // 
            // lbl_dept
            // 
            this.lbl_dept.AutoSize = true;
            this.lbl_dept.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dept.Location = new System.Drawing.Point(425, 172);
            this.lbl_dept.Name = "lbl_dept";
            this.lbl_dept.Size = new System.Drawing.Size(64, 18);
            this.lbl_dept.TabIndex = 23;
            this.lbl_dept.Text = "Service";
            // 
            // lbl_site
            // 
            this.lbl_site.AutoSize = true;
            this.lbl_site.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_site.Location = new System.Drawing.Point(448, 127);
            this.lbl_site.Name = "lbl_site";
            this.lbl_site.Size = new System.Drawing.Size(37, 18);
            this.lbl_site.TabIndex = 24;
            this.lbl_site.Text = "Site";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(57, 274);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 18);
            this.label9.TabIndex = 25;
            this.label9.Text = "Recherche";
            // 
            // txt_nameEmp
            // 
            this.txt_nameEmp.Location = new System.Drawing.Point(182, 76);
            this.txt_nameEmp.Name = "txt_nameEmp";
            this.txt_nameEmp.Size = new System.Drawing.Size(164, 22);
            this.txt_nameEmp.TabIndex = 26;
            // 
            // txt_FNameEmp
            // 
            this.txt_FNameEmp.Location = new System.Drawing.Point(182, 127);
            this.txt_FNameEmp.Name = "txt_FNameEmp";
            this.txt_FNameEmp.Size = new System.Drawing.Size(164, 22);
            this.txt_FNameEmp.TabIndex = 27;
            // 
            // txt_phoneEmp
            // 
            this.txt_phoneEmp.Location = new System.Drawing.Point(182, 172);
            this.txt_phoneEmp.Name = "txt_phoneEmp";
            this.txt_phoneEmp.Size = new System.Drawing.Size(164, 22);
            this.txt_phoneEmp.TabIndex = 28;
            // 
            // txt_mobileEmpl
            // 
            this.txt_mobileEmpl.Location = new System.Drawing.Point(182, 220);
            this.txt_mobileEmpl.Name = "txt_mobileEmpl";
            this.txt_mobileEmpl.Size = new System.Drawing.Size(164, 22);
            this.txt_mobileEmpl.TabIndex = 29;
            // 
            // txt_searchEmpl
            // 
            this.txt_searchEmpl.Location = new System.Drawing.Point(182, 273);
            this.txt_searchEmpl.Name = "txt_searchEmpl";
            this.txt_searchEmpl.Size = new System.Drawing.Size(455, 22);
            this.txt_searchEmpl.TabIndex = 30;
            // 
            // txt_emailEmp
            // 
            this.txt_emailEmp.Location = new System.Drawing.Point(517, 74);
            this.txt_emailEmp.Name = "txt_emailEmp";
            this.txt_emailEmp.Size = new System.Drawing.Size(275, 22);
            this.txt_emailEmp.TabIndex = 31;
            // 
            // btnAddEmp
            // 
            this.btnAddEmp.BackColor = System.Drawing.Color.MediumPurple;
            this.btnAddEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEmp.ForeColor = System.Drawing.Color.White;
            this.btnAddEmp.Location = new System.Drawing.Point(658, 215);
            this.btnAddEmp.Name = "btnAddEmp";
            this.btnAddEmp.Size = new System.Drawing.Size(133, 35);
            this.btnAddEmp.TabIndex = 34;
            this.btnAddEmp.Text = "Ajouter";
            this.btnAddEmp.UseVisualStyleBackColor = false;
            this.btnAddEmp.Click += new System.EventHandler(this.btnAddEmp_Click);
            // 
            // dtgvEmpl
            // 
            this.dtgvEmpl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvEmpl.Location = new System.Drawing.Point(61, 308);
            this.dtgvEmpl.Name = "dtgvEmpl";
            this.dtgvEmpl.RowHeadersWidth = 51;
            this.dtgvEmpl.RowTemplate.Height = 24;
            this.dtgvEmpl.Size = new System.Drawing.Size(731, 125);
            this.dtgvEmpl.TabIndex = 38;
            this.dtgvEmpl.DoubleClick += new System.EventHandler(this.dtgvEmpl_DoubleClick);
            // 
            // btnCancelEmp
            // 
            this.btnCancelEmp.BackColor = System.Drawing.Color.MediumPurple;
            this.btnCancelEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelEmp.ForeColor = System.Drawing.Color.White;
            this.btnCancelEmp.Location = new System.Drawing.Point(282, 455);
            this.btnCancelEmp.Name = "btnCancelEmp";
            this.btnCancelEmp.Size = new System.Drawing.Size(133, 34);
            this.btnCancelEmp.TabIndex = 36;
            this.btnCancelEmp.Text = "Annuler";
            this.btnCancelEmp.UseVisualStyleBackColor = false;
            this.btnCancelEmp.Click += new System.EventHandler(this.btnCancelEmp_Click);
            // 
            // btnDeleteEmp
            // 
            this.btnDeleteEmp.BackColor = System.Drawing.Color.DarkRed;
            this.btnDeleteEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteEmp.ForeColor = System.Drawing.Color.White;
            this.btnDeleteEmp.Location = new System.Drawing.Point(436, 455);
            this.btnDeleteEmp.Name = "btnDeleteEmp";
            this.btnDeleteEmp.Size = new System.Drawing.Size(133, 35);
            this.btnDeleteEmp.TabIndex = 37;
            this.btnDeleteEmp.Text = "Supprimer";
            this.btnDeleteEmp.UseVisualStyleBackColor = false;
            this.btnDeleteEmp.Click += new System.EventHandler(this.btnDeleteEmp_Click);
            // 
            // btnSearchEmp
            // 
            this.btnSearchEmp.BackColor = System.Drawing.Color.MediumPurple;
            this.btnSearchEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchEmp.ForeColor = System.Drawing.Color.White;
            this.btnSearchEmp.Location = new System.Drawing.Point(659, 264);
            this.btnSearchEmp.Name = "btnSearchEmp";
            this.btnSearchEmp.Size = new System.Drawing.Size(133, 38);
            this.btnSearchEmp.TabIndex = 35;
            this.btnSearchEmp.Text = "Rechercher";
            this.btnSearchEmp.UseVisualStyleBackColor = false;
            this.btnSearchEmp.Click += new System.EventHandler(this.btnSearchEmp_Click);
            // 
            // comboBox_site
            // 
            this.comboBox_site.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.siteBindingSource, "Id", true));
            this.comboBox_site.DataSource = this.siteBindingSource;
            this.comboBox_site.DisplayMember = "city_name";
            this.comboBox_site.FormattingEnabled = true;
            this.comboBox_site.Location = new System.Drawing.Point(517, 127);
            this.comboBox_site.Name = "comboBox_site";
            this.comboBox_site.Size = new System.Drawing.Size(275, 24);
            this.comboBox_site.TabIndex = 39;
            this.comboBox_site.ValueMember = "Id";
            // 
            // siteBindingSource
            // 
            this.siteBindingSource.DataMember = "Site";
            this.siteBindingSource.DataSource = this.database_projet4DataSet;
            // 
            // database_projet4DataSet
            // 
            this.database_projet4DataSet.DataSetName = "database_projet4DataSet";
            this.database_projet4DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox_dept
            // 
            this.comboBox_dept.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.departmentBindingSource, "Id", true));
            this.comboBox_dept.DataSource = this.departmentBindingSource;
            this.comboBox_dept.DisplayMember = "department";
            this.comboBox_dept.FormattingEnabled = true;
            this.comboBox_dept.Location = new System.Drawing.Point(517, 172);
            this.comboBox_dept.Name = "comboBox_dept";
            this.comboBox_dept.Size = new System.Drawing.Size(274, 24);
            this.comboBox_dept.TabIndex = 40;
            this.comboBox_dept.ValueMember = "Id";
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
            // databaseprojet4DataSetBindingSource
            // 
            this.databaseprojet4DataSetBindingSource.DataSource = this.database_projet4DataSet;
            this.databaseprojet4DataSetBindingSource.Position = 0;
            // 
            // departmentTableAdapter
            // 
            this.departmentTableAdapter.ClearBeforeFill = true;
            // 
            // siteTableAdapter
            // 
            this.siteTableAdapter.ClearBeforeFill = true;
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 505);
            this.Controls.Add(this.comboBox_dept);
            this.Controls.Add(this.comboBox_site);
            this.Controls.Add(this.dtgvEmpl);
            this.Controls.Add(this.btnDeleteEmp);
            this.Controls.Add(this.btnCancelEmp);
            this.Controls.Add(this.btnSearchEmp);
            this.Controls.Add(this.btnAddEmp);
            this.Controls.Add(this.txt_emailEmp);
            this.Controls.Add(this.txt_searchEmpl);
            this.Controls.Add(this.txt_mobileEmpl);
            this.Controls.Add(this.txt_phoneEmp);
            this.Controls.Add(this.txt_FNameEmp);
            this.Controls.Add(this.txt_nameEmp);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbl_site);
            this.Controls.Add(this.lbl_dept);
            this.Controls.Add(this.lbl_mobile);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_phone);
            this.Controls.Add(this.lbl_EmpName);
            this.Controls.Add(this.lbl_empFName);
            this.Controls.Add(this.label1);
            this.Name = "EmployeeForm";
            this.Text = "EmployeeForm";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEmpl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database_projet4DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database_projet4DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseprojet4DataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_empFName;
        private System.Windows.Forms.Label lbl_EmpName;
        private System.Windows.Forms.Label lbl_phone;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_mobile;
        private System.Windows.Forms.Label lbl_dept;
        private System.Windows.Forms.Label lbl_site;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_nameEmp;
        private System.Windows.Forms.TextBox txt_FNameEmp;
        private System.Windows.Forms.TextBox txt_phoneEmp;
        private System.Windows.Forms.TextBox txt_mobileEmpl;
        private System.Windows.Forms.TextBox txt_searchEmpl;
        private System.Windows.Forms.TextBox txt_emailEmp;
        private System.Windows.Forms.Button btnAddEmp;
        private System.Windows.Forms.DataGridView dtgvEmpl;
        private System.Windows.Forms.Button btnCancelEmp;
        private System.Windows.Forms.Button btnDeleteEmp;
        private System.Windows.Forms.Button btnSearchEmp;
        private System.Windows.Forms.ComboBox comboBox_site;
        private System.Windows.Forms.ComboBox comboBox_dept;
        private System.Windows.Forms.BindingSource databaseprojet4DataSetBindingSource;
        private database_projet4DataSet database_projet4DataSet;
        private database_projet4DataSet1 database_projet4DataSet1;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private database_projet4DataSet1TableAdapters.DepartmentTableAdapter departmentTableAdapter;
        private System.Windows.Forms.BindingSource siteBindingSource;
        private database_projet4DataSetTableAdapters.SiteTableAdapter siteTableAdapter;
    }
}