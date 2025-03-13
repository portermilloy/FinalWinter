namespace FinalWinter
{
    partial class NewPetForm
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
            gbPet = new GroupBox();
            btnClear = new Button();
            btnSave = new Button();
            txtBreed = new TextBox();
            txtAnimal = new TextBox();
            txtName = new TextBox();
            lblBreed = new Label();
            lblAnimal = new Label();
            lblName = new Label();
            gbPet.SuspendLayout();
            SuspendLayout();
            // 
            // gbPet
            // 
            gbPet.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbPet.AutoSize = true;
            gbPet.Controls.Add(btnClear);
            gbPet.Controls.Add(btnSave);
            gbPet.Controls.Add(txtBreed);
            gbPet.Controls.Add(txtAnimal);
            gbPet.Controls.Add(txtName);
            gbPet.Controls.Add(lblBreed);
            gbPet.Controls.Add(lblAnimal);
            gbPet.Controls.Add(lblName);
            gbPet.Location = new Point(12, 12);
            gbPet.Name = "gbPet";
            gbPet.Size = new Size(498, 211);
            gbPet.TabIndex = 3;
            gbPet.TabStop = false;
            gbPet.Text = "New Pet";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(398, 150);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 7;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(6, 150);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtBreed
            // 
            txtBreed.Location = new Point(82, 100);
            txtBreed.Name = "txtBreed";
            txtBreed.Size = new Size(410, 27);
            txtBreed.TabIndex = 5;
            // 
            // txtAnimal
            // 
            txtAnimal.Location = new Point(82, 67);
            txtAnimal.Name = "txtAnimal";
            txtAnimal.Size = new Size(410, 27);
            txtAnimal.TabIndex = 4;
            // 
            // txtName
            // 
            txtName.Location = new Point(82, 34);
            txtName.Name = "txtName";
            txtName.Size = new Size(410, 27);
            txtName.TabIndex = 3;
            // 
            // lblBreed
            // 
            lblBreed.AutoSize = true;
            lblBreed.Location = new Point(6, 103);
            lblBreed.Name = "lblBreed";
            lblBreed.Size = new Size(51, 20);
            lblBreed.TabIndex = 2;
            lblBreed.Text = "Breed:";
            // 
            // lblAnimal
            // 
            lblAnimal.AutoSize = true;
            lblAnimal.Location = new Point(6, 70);
            lblAnimal.Name = "lblAnimal";
            lblAnimal.Size = new Size(59, 20);
            lblAnimal.TabIndex = 1;
            lblAnimal.Text = "Animal:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(6, 37);
            lblName.Name = "lblName";
            lblName.Size = new Size(76, 20);
            lblName.TabIndex = 0;
            lblName.Text = "Pet Name:";
            // 
            // NewPetForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(522, 235);
            Controls.Add(gbPet);
            Name = "NewPetForm";
            Text = "NewPetForm";
            gbPet.ResumeLayout(false);
            gbPet.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbPet;
        private Label lblBreed;
        private Label lblAnimal;
        private Label lblName;
        private TextBox txtBreed;
        private TextBox txtAnimal;
        private TextBox txtName;
        private Button btnClear;
        private Button btnSave;
    }
}