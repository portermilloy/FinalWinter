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
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            petNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            animalDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            breedDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            petsBindingSource1 = new BindingSource(components);
            petsBindingSource = new BindingSource(components);
            btnNew = new Button();
            btnEdit = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPets).BeginInit();
            ((System.ComponentModel.ISupportInitialize)petsBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)petsBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dgvPets
            // 
            dgvPets.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvPets.AutoGenerateColumns = false;
            dgvPets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPets.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, petNameDataGridViewTextBoxColumn, animalDataGridViewTextBoxColumn, breedDataGridViewTextBoxColumn });
            dgvPets.DataSource = petsBindingSource1;
            dgvPets.Location = new Point(12, 47);
            dgvPets.Name = "dgvPets";
            dgvPets.RowHeadersWidth = 51;
            dgvPets.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPets.Size = new Size(776, 391);
            dgvPets.TabIndex = 1;
            dgvPets.CellContentClick += dgvPets_CellContentClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "PetId";
            dataGridViewTextBoxColumn1.HeaderText = "PetId";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 125;
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
            // petsBindingSource1
            // 
            petsBindingSource1.DataSource = typeof(Pets);
            // 
            // petsBindingSource
            // 
            petsBindingSource.DataSource = typeof(Pets);
            // 
            // btnNew
            // 
            btnNew.Location = new Point(694, 12);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(94, 29);
            btnNew.TabIndex = 2;
            btnNew.Text = "New Pet";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(597, 13);
            btnEdit.Margin = new Padding(2);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(92, 29);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Edit Pet";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 6);
            label1.Name = "label1";
            label1.Size = new Size(283, 38);
            label1.TabIndex = 4;
            label1.Text = "Porter's Pet List App";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnEdit);
            Controls.Add(btnNew);
            Controls.Add(dgvPets);
            Name = "MainForm";
            Text = "Pet Form";
            ((System.ComponentModel.ISupportInitialize)dgvPets).EndInit();
            ((System.ComponentModel.ISupportInitialize)petsBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)petsBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private DataGridView dgvPets;
        private Button btnNew;
        private BindingSource petsBindingSource;
        private Button btnEdit;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn petNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn animalDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn breedDataGridViewTextBoxColumn;
        private BindingSource petsBindingSource1;
        private Label label1;
    }
}
