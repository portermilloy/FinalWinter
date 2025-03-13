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
            txtAnimal = new TextBox();
            txtBreed = new TextBox();
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
            gbPet.Controls.Add(txtAnimal);
            gbPet.Controls.Add(txtBreed);
            gbPet.Controls.Add(txtName);
            gbPet.Controls.Add(lblBreed);
            gbPet.Controls.Add(lblAnimal);
            gbPet.Controls.Add(lblName);
            gbPet.Location = new Point(20, 19);
            gbPet.Margin = new Padding(5);
            gbPet.Name = "gbPet";
            gbPet.Padding = new Padding(5);
            gbPet.Size = new Size(810, 338);
            gbPet.TabIndex = 3;
            gbPet.TabStop = false;
            gbPet.Text = "New Pet";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(647, 240);
            btnClear.Margin = new Padding(5);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(153, 46);
            btnClear.TabIndex = 7;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(10, 240);
            btnSave.Margin = new Padding(5);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(153, 46);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtAnimal
            // 
            txtAnimal.Location = new Point(133, 107);
            txtAnimal.Margin = new Padding(5);
            txtAnimal.Name = "txtAnimal";
            txtAnimal.Size = new Size(664, 39);
            txtAnimal.TabIndex = 5;
            // 
            // txtBreed
            // 
            txtBreed.Location = new Point(133, 160);
            txtBreed.Margin = new Padding(5);
            txtBreed.Name = "txtBreed";
            txtBreed.Size = new Size(664, 39);
            txtBreed.TabIndex = 4;
            // 
            // txtName
            // 
            txtName.Location = new Point(133, 54);
            txtName.Margin = new Padding(5);
            txtName.Name = "txtName";
            txtName.Size = new Size(664, 39);
            txtName.TabIndex = 3;
            // 
            // lblBreed
            // 
            lblBreed.AutoSize = true;
            lblBreed.Location = new Point(10, 165);
            lblBreed.Margin = new Padding(5, 0, 5, 0);
            lblBreed.Name = "lblBreed";
            lblBreed.Size = new Size(81, 32);
            lblBreed.TabIndex = 2;
            lblBreed.Text = "Breed:";
            // 
            // lblAnimal
            // 
            lblAnimal.AutoSize = true;
            lblAnimal.Location = new Point(10, 112);
            lblAnimal.Margin = new Padding(5, 0, 5, 0);
            lblAnimal.Name = "lblAnimal";
            lblAnimal.Size = new Size(93, 32);
            lblAnimal.TabIndex = 1;
            lblAnimal.Text = "Animal:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(10, 59);
            lblName.Margin = new Padding(5, 0, 5, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(123, 32);
            lblName.TabIndex = 0;
            lblName.Text = "Pet Name:";
            // 
            // NewPetForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(848, 376);
            Controls.Add(gbPet);
            Margin = new Padding(5);
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
        private TextBox txtAnimal;
        private TextBox txtBreed;
        private TextBox txtName;
        private Button btnClear;
        private Button btnSave;
    }
}