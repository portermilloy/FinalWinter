namespace FinalWinter
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dgvPets = new DataGridView();
            petNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            animalDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            breedDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            petsBindingSource = new BindingSource(components);
            btnNew = new Button();
            btnEdit = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPets).BeginInit();
            ((System.ComponentModel.ISupportInitialize)petsBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dgvPets
            // 
            dgvPets.AutoGenerateColumns = false;
            dgvPets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPets.Columns.AddRange(new DataGridViewColumn[] { petNameDataGridViewTextBoxColumn, animalDataGridViewTextBoxColumn, breedDataGridViewTextBoxColumn });
            dgvPets.DataSource = petsBindingSource;
            dgvPets.Location = new Point(20, 75);
            dgvPets.Margin = new Padding(5);
            dgvPets.Name = "dgvPets";
            dgvPets.RowHeadersWidth = 51;
            dgvPets.Size = new Size(1261, 626);
            dgvPets.TabIndex = 1;
            // 
            // petNameDataGridViewTextBoxColumn
            // 
            petNameDataGridViewTextBoxColumn.DataPropertyName = "PetName";
            petNameDataGridViewTextBoxColumn.HeaderText = "PetName";
            petNameDataGridViewTextBoxColumn.MinimumWidth = 10;
            petNameDataGridViewTextBoxColumn.Name = "petNameDataGridViewTextBoxColumn";
            petNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // animalDataGridViewTextBoxColumn
            // 
            animalDataGridViewTextBoxColumn.DataPropertyName = "Animal";
            animalDataGridViewTextBoxColumn.HeaderText = "Animal";
            animalDataGridViewTextBoxColumn.MinimumWidth = 10;
            animalDataGridViewTextBoxColumn.Name = "animalDataGridViewTextBoxColumn";
            animalDataGridViewTextBoxColumn.Width = 200;
            // 
            // breedDataGridViewTextBoxColumn
            // 
            breedDataGridViewTextBoxColumn.DataPropertyName = "Breed";
            breedDataGridViewTextBoxColumn.HeaderText = "Breed";
            breedDataGridViewTextBoxColumn.MinimumWidth = 10;
            breedDataGridViewTextBoxColumn.Name = "breedDataGridViewTextBoxColumn";
            breedDataGridViewTextBoxColumn.Width = 200;
            // 
            // petsBindingSource
            // 
            petsBindingSource.DataSource = typeof(Pets);
            // 
            // btnNew
            // 
            btnNew.Location = new Point(1128, 19);
            btnNew.Margin = new Padding(5);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(153, 46);
            btnNew.TabIndex = 2;
            btnNew.Text = "New Pet";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(970, 21);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(150, 46);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Edit Pet";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 720);
            Controls.Add(btnEdit);
            Controls.Add(btnNew);
            Controls.Add(dgvPets);
            Margin = new Padding(5);
            Name = "MainForm";
            Text = "Pet Form";
            ((System.ComponentModel.ISupportInitialize)dgvPets).EndInit();
            ((System.ComponentModel.ISupportInitialize)petsBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAdd;
        private DataGridView dgvPets;
        private Button btnNew;
        private DataGridViewTextBoxColumn petNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn animalDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn breedDataGridViewTextBoxColumn;
        private BindingSource petsBindingSource;
        private Button btnEdit;
    }
}
