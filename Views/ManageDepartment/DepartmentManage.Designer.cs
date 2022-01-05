﻿
namespace CrudBloc4.Views.ManageDepartment
{
    partial class DepartmentManage
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
            this.lblDepartment = new System.Windows.Forms.Label();
            this.txtDep = new System.Windows.Forms.TextBox();
            this.btnAddDep = new System.Windows.Forms.Button();
            this.dtgvDep = new System.Windows.Forms.DataGridView();
            this.btnCancelDep = new System.Windows.Forms.Button();
            this.btnUpdateDep = new System.Windows.Forms.Button();
            this.btnDeleteDep = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDep)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartment.Location = new System.Drawing.Point(62, 100);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(96, 25);
            this.lblDepartment.TabIndex = 0;
            this.lblDepartment.Text = "Services";
            // 
            // txtDep
            // 
            this.txtDep.Location = new System.Drawing.Point(206, 103);
            this.txtDep.Name = "txtDep";
            this.txtDep.Size = new System.Drawing.Size(372, 22);
            this.txtDep.TabIndex = 1;
            // 
            // btnAddDep
            // 
            this.btnAddDep.BackColor = System.Drawing.Color.MediumPurple;
            this.btnAddDep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDep.ForeColor = System.Drawing.Color.White;
            this.btnAddDep.Location = new System.Drawing.Point(600, 96);
            this.btnAddDep.Name = "btnAddDep";
            this.btnAddDep.Size = new System.Drawing.Size(127, 35);
            this.btnAddDep.TabIndex = 2;
            this.btnAddDep.Text = "Ajouter";
            this.btnAddDep.UseVisualStyleBackColor = false;
            this.btnAddDep.Click += new System.EventHandler(this.btnAddDep_Click);
            // 
            // dtgvDep
            // 
            this.dtgvDep.AllowUserToAddRows = false;
            this.dtgvDep.AllowUserToDeleteRows = false;
            this.dtgvDep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDep.Location = new System.Drawing.Point(67, 175);
            this.dtgvDep.Name = "dtgvDep";
            this.dtgvDep.ReadOnly = true;
            this.dtgvDep.RowHeadersWidth = 51;
            this.dtgvDep.RowTemplate.Height = 24;
            this.dtgvDep.Size = new System.Drawing.Size(660, 175);
            this.dtgvDep.TabIndex = 3;
            // 
            // btnCancelDep
            // 
            this.btnCancelDep.BackColor = System.Drawing.Color.MediumPurple;
            this.btnCancelDep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelDep.ForeColor = System.Drawing.Color.White;
            this.btnCancelDep.Location = new System.Drawing.Point(206, 373);
            this.btnCancelDep.Name = "btnCancelDep";
            this.btnCancelDep.Size = new System.Drawing.Size(127, 35);
            this.btnCancelDep.TabIndex = 4;
            this.btnCancelDep.Text = "Annuler";
            this.btnCancelDep.UseVisualStyleBackColor = false;
            // 
            // btnUpdateDep
            // 
            this.btnUpdateDep.BackColor = System.Drawing.Color.MediumPurple;
            this.btnUpdateDep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateDep.ForeColor = System.Drawing.Color.White;
            this.btnUpdateDep.Location = new System.Drawing.Point(353, 373);
            this.btnUpdateDep.Name = "btnUpdateDep";
            this.btnUpdateDep.Size = new System.Drawing.Size(127, 35);
            this.btnUpdateDep.TabIndex = 5;
            this.btnUpdateDep.Text = "Modifier";
            this.btnUpdateDep.UseVisualStyleBackColor = false;
            // 
            // btnDeleteDep
            // 
            this.btnDeleteDep.BackColor = System.Drawing.Color.DarkRed;
            this.btnDeleteDep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteDep.ForeColor = System.Drawing.Color.White;
            this.btnDeleteDep.Location = new System.Drawing.Point(497, 373);
            this.btnDeleteDep.Name = "btnDeleteDep";
            this.btnDeleteDep.Size = new System.Drawing.Size(127, 35);
            this.btnDeleteDep.TabIndex = 6;
            this.btnDeleteDep.Text = "Supprimer";
            this.btnDeleteDep.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(347, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Services";
            // 
            // DepartmentManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeleteDep);
            this.Controls.Add(this.btnUpdateDep);
            this.Controls.Add(this.btnCancelDep);
            this.Controls.Add(this.dtgvDep);
            this.Controls.Add(this.btnAddDep);
            this.Controls.Add(this.txtDep);
            this.Controls.Add(this.lblDepartment);
            this.Name = "DepartmentManage";
            this.Text = "DepartmentManage";
            this.Load += new System.EventHandler(this.DepartmentManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.TextBox txtDep;
        private System.Windows.Forms.Button btnAddDep;
        private System.Windows.Forms.DataGridView dtgvDep;
        private System.Windows.Forms.Button btnCancelDep;
        private System.Windows.Forms.Button btnUpdateDep;
        private System.Windows.Forms.Button btnDeleteDep;
        private System.Windows.Forms.Label label1;
    }
}