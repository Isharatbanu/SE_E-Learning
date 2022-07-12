namespace E_Learning_Platform.Admin_UC
{
    partial class UC_ViewUser
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_ViewUser));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.eLearningBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eLearning = new E_Learning_Platform.ELearning();
            this.SearchBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.ButtonDelete = new Guna.UI2.WinForms.Guna2Button();
            this.Refresh = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Firstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Middlename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fathername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mothername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bloodgrp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aadhar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nationality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SSC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HSC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Photo1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.UpdateButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteButton = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.eLearningBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eLearning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Refresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold);
            this.label.ForeColor = System.Drawing.Color.Teal;
            this.label.Location = new System.Drawing.Point(32, 27);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(197, 42);
            this.label.TabIndex = 0;
            this.label.Text = "View User";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // eLearningBindingSource
            // 
            this.eLearningBindingSource.DataSource = this.eLearning;
            this.eLearningBindingSource.Position = 0;
            // 
            // eLearning
            // 
            this.eLearning.DataSetName = "ELearning";
            this.eLearning.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SearchBox
            // 
            this.SearchBox.Animated = true;
            this.SearchBox.BackColor = System.Drawing.SystemColors.HotTrack;
            this.SearchBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchBox.DefaultText = "";
            this.SearchBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SearchBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SearchBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchBox.DisabledState.Parent = this.SearchBox;
            this.SearchBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchBox.FocusedState.Parent = this.SearchBox;
            this.SearchBox.Font = new System.Drawing.Font("Sitka Small", 10.8F, System.Drawing.FontStyle.Bold);
            this.SearchBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchBox.HoverState.Parent = this.SearchBox;
            this.SearchBox.Location = new System.Drawing.Point(334, 102);
            this.SearchBox.Margin = new System.Windows.Forms.Padding(4);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.PasswordChar = '\0';
            this.SearchBox.PlaceholderText = "Search........................................";
            this.SearchBox.SelectedText = "";
            this.SearchBox.ShadowDecoration.Parent = this.SearchBox;
            this.SearchBox.Size = new System.Drawing.Size(711, 42);
            this.SearchBox.TabIndex = 7;
            this.SearchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SearchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.AutoRoundedCorners = true;
            this.ButtonDelete.BackColor = System.Drawing.Color.Transparent;
            this.ButtonDelete.BorderRadius = 18;
            this.ButtonDelete.CheckedState.Parent = this.ButtonDelete;
            this.ButtonDelete.CustomImages.Parent = this.ButtonDelete;
            this.ButtonDelete.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDelete.ForeColor = System.Drawing.Color.White;
            this.ButtonDelete.HoverState.Parent = this.ButtonDelete;
            this.ButtonDelete.Image = ((System.Drawing.Image)(resources.GetObject("ButtonDelete.Image")));
            this.ButtonDelete.ImageSize = new System.Drawing.Size(25, 25);
            this.ButtonDelete.Location = new System.Drawing.Point(1020, 18);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.ShadowDecoration.Parent = this.ButtonDelete;
            this.ButtonDelete.Size = new System.Drawing.Size(125, 39);
            this.ButtonDelete.TabIndex = 8;
            this.ButtonDelete.Text = "Delete";
            this.ButtonDelete.UseTransparentBackground = true;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // Refresh
            // 
            this.Refresh.Image = ((System.Drawing.Image)(resources.GetObject("Refresh.Image")));
            this.Refresh.Location = new System.Drawing.Point(255, 18);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(64, 64);
            this.Refresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Refresh.TabIndex = 9;
            this.Refresh.TabStop = false;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdColumn,
            this.Firstname,
            this.Middlename,
            this.Lastname,
            this.Gender,
            this.Fathername,
            this.Mothername,
            this.Mobile,
            this.Email,
            this.Bloodgrp,
            this.Aadhar,
            this.Nationality,
            this.SSC,
            this.HSC,
            this.Photo1,
            this.UpdateButton,
            this.DeleteButton});
            this.dataGridView1.Location = new System.Drawing.Point(39, 254);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1091, 283);
            this.dataGridView1.TabIndex = 10;
            // 
            // IdColumn
            // 
            this.IdColumn.DataPropertyName = "Id";
            this.IdColumn.HeaderText = "Id";
            this.IdColumn.MinimumWidth = 6;
            this.IdColumn.Name = "IdColumn";
            this.IdColumn.Width = 125;
            // 
            // Firstname
            // 
            this.Firstname.DataPropertyName = "Firstname";
            this.Firstname.HeaderText = "Firstname";
            this.Firstname.MinimumWidth = 6;
            this.Firstname.Name = "Firstname";
            this.Firstname.Width = 125;
            // 
            // Middlename
            // 
            this.Middlename.DataPropertyName = "Middlename";
            this.Middlename.HeaderText = "Middlename";
            this.Middlename.MinimumWidth = 6;
            this.Middlename.Name = "Middlename";
            this.Middlename.Width = 125;
            // 
            // Lastname
            // 
            this.Lastname.DataPropertyName = "Lastname";
            this.Lastname.HeaderText = "Lastname";
            this.Lastname.MinimumWidth = 6;
            this.Lastname.Name = "Lastname";
            this.Lastname.Width = 125;
            // 
            // Gender
            // 
            this.Gender.DataPropertyName = "Gender";
            this.Gender.HeaderText = "Gender";
            this.Gender.MinimumWidth = 6;
            this.Gender.Name = "Gender";
            this.Gender.Width = 125;
            // 
            // Fathername
            // 
            this.Fathername.DataPropertyName = "Fathername";
            this.Fathername.HeaderText = "Fathername";
            this.Fathername.MinimumWidth = 6;
            this.Fathername.Name = "Fathername";
            this.Fathername.Width = 125;
            // 
            // Mothername
            // 
            this.Mothername.DataPropertyName = "Mothername";
            this.Mothername.HeaderText = "Mothername";
            this.Mothername.MinimumWidth = 6;
            this.Mothername.Name = "Mothername";
            this.Mothername.Width = 125;
            // 
            // Mobile
            // 
            this.Mobile.DataPropertyName = "Mobile";
            this.Mobile.HeaderText = "Mobile";
            this.Mobile.MinimumWidth = 6;
            this.Mobile.Name = "Mobile";
            this.Mobile.Width = 125;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.Width = 125;
            // 
            // Bloodgrp
            // 
            this.Bloodgrp.DataPropertyName = "Bloodgrp";
            this.Bloodgrp.HeaderText = "Blood group";
            this.Bloodgrp.MinimumWidth = 6;
            this.Bloodgrp.Name = "Bloodgrp";
            this.Bloodgrp.Width = 125;
            // 
            // Aadhar
            // 
            this.Aadhar.DataPropertyName = "Aadhar";
            this.Aadhar.HeaderText = "Aadhar no";
            this.Aadhar.MinimumWidth = 6;
            this.Aadhar.Name = "Aadhar";
            this.Aadhar.Width = 125;
            // 
            // Nationality
            // 
            this.Nationality.DataPropertyName = "Nationality";
            this.Nationality.HeaderText = "Nationality";
            this.Nationality.MinimumWidth = 6;
            this.Nationality.Name = "Nationality";
            this.Nationality.Width = 125;
            // 
            // SSC
            // 
            this.SSC.DataPropertyName = "SSC";
            this.SSC.HeaderText = "SSC";
            this.SSC.MinimumWidth = 6;
            this.SSC.Name = "SSC";
            this.SSC.Width = 125;
            // 
            // HSC
            // 
            this.HSC.DataPropertyName = "HSC";
            this.HSC.HeaderText = "HSC";
            this.HSC.MinimumWidth = 6;
            this.HSC.Name = "HSC";
            this.HSC.Width = 125;
            // 
            // Photo1
            // 
            this.Photo1.DataPropertyName = "Photo1";
            this.Photo1.HeaderText = "Photo";
            this.Photo1.MinimumWidth = 6;
            this.Photo1.Name = "Photo1";
            this.Photo1.Width = 125;
            // 
            // UpdateButton
            // 
            this.UpdateButton.HeaderText = "Update";
            this.UpdateButton.MinimumWidth = 6;
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseColumnTextForButtonValue = true;
            this.UpdateButton.Width = 125;
            // 
            // DeleteButton
            // 
            this.DeleteButton.HeaderText = "Delete";
            this.DeleteButton.MinimumWidth = 6;
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseColumnTextForButtonValue = true;
            this.DeleteButton.Width = 125;
            // 
            // UC_ViewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.label);
            this.Name = "UC_ViewUser";
            this.Size = new System.Drawing.Size(1179, 726);
            this.Load += new System.EventHandler(this.UC_ViewUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eLearningBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eLearning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Refresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2TextBox SearchBox;
        private Guna.UI2.WinForms.Guna2Button ButtonDelete;
        private new System.Windows.Forms.PictureBox Refresh;
        private System.Windows.Forms.BindingSource eLearningBindingSource;
        private ELearning eLearning;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Firstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Middlename;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fathername;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mothername;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bloodgrp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aadhar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nationality;
        private System.Windows.Forms.DataGridViewTextBoxColumn SSC;
        private System.Windows.Forms.DataGridViewTextBoxColumn HSC;
        private System.Windows.Forms.DataGridViewImageColumn Photo1;
        private System.Windows.Forms.DataGridViewButtonColumn UpdateButton;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteButton;
    }
}
