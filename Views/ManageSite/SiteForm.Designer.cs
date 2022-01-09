
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace CrudBloc4.Views
{
    partial class SiteForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_city = new System.Windows.Forms.Label();
            this.txt_cityName = new System.Windows.Forms.TextBox();
            this.dtgvSite = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSite)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(347, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "SITES";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_city
            // 
            this.lbl_city.AutoSize = true;
            this.lbl_city.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_city.Location = new System.Drawing.Point(57, 132);
            this.lbl_city.Name = "lbl_city";
            this.lbl_city.Size = new System.Drawing.Size(54, 25);
            this.lbl_city.TabIndex = 1;
            this.lbl_city.Text = "Ville";
            // 
            // txt_cityName
            // 
            this.txt_cityName.Location = new System.Drawing.Point(182, 132);
            this.txt_cityName.Name = "txt_cityName";
            this.txt_cityName.Size = new System.Drawing.Size(404, 22);
            this.txt_cityName.TabIndex = 2;
            // 
            // dtgvSite
            // 
            this.dtgvSite.AllowUserToAddRows = false;
            this.dtgvSite.AllowUserToDeleteRows = false;
            this.dtgvSite.BackgroundColor = System.Drawing.Color.Lavender;
            this.dtgvSite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvSite.GridColor = System.Drawing.Color.Thistle;
            this.dtgvSite.Location = new System.Drawing.Point(62, 207);
            this.dtgvSite.Name = "dtgvSite";
            this.dtgvSite.ReadOnly = true;
            this.dtgvSite.RowHeadersWidth = 51;
            this.dtgvSite.RowTemplate.Height = 24;
            this.dtgvSite.Size = new System.Drawing.Size(683, 169);
            this.dtgvSite.TabIndex = 3;
            this.dtgvSite.DoubleClick += new System.EventHandler(this.dtgvSite_DoubleClick);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.MediumPurple;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.Location = new System.Drawing.Point(608, 125);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(137, 35);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Ajouter";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.MediumPurple;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(192, 408);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(146, 35);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Firebrick;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(354, 408);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(146, 35);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Supprimer";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.MediumPurple;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdate.Location = new System.Drawing.Point(515, 408);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(137, 35);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Modifier";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // SiteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 474);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dtgvSite);
            this.Controls.Add(this.txt_cityName);
            this.Controls.Add(this.lbl_city);
            this.Controls.Add(this.label1);
            this.Name = "SiteForm";
            this.Text = "SiteForm";
            this.Load += new System.EventHandler(this.SiteForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public SiteForm(IContainer components, Label label1, Label lbl_city, TextBox txt_cityName, DataGridView dtgvSite, Button btnAdd, Button btnCancel, Button button3, string connectionString, int siteId)
        {
            this.components = components;
            this.label1 = label1;
            this.lbl_city = lbl_city;
            this.txt_cityName = txt_cityName;
            this.dtgvSite = dtgvSite;
            this.btnAdd = btnAdd;
            this.btnCancel = btnCancel;
            this.btnDelete = button3;
            this.connectionString = connectionString;
            this.Id = Id;
        }


        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_city;
        private System.Windows.Forms.TextBox txt_cityName;
        private System.Windows.Forms.DataGridView dtgvSite;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private Button btnUpdate;

        //public EventHandler SiteForm_Load { get; private set; }
    }
}