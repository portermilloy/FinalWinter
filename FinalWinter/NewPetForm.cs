using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalWinter
{
    public partial class NewPetForm : Form
    {
        private MainForm _mainForm;
        private int CustomerCount = 0;
        private bool IsEditing;
        private int CurrentSelectionId;

        public NewPetForm(MainForm form)
        {
            InitializeComponent();
            _mainForm = form;
            CustomerCount++;
            IsEditing = false;
            CurrentSelectionId = -1;
        }

        public void ToggleEdit(bool editing)
        {
            IsEditing = editing;
        }

        private void CreatePet()
        {
            if (CheckIfValid(txtName))
            {
                MessageBox.Show("The Pet Name is empty, please enter the name of your pet.");
                return;
            }
            if (CheckIfValid(txtAnimal))
            {
                MessageBox.Show("Animal is empty, please enter the type of animal your pet is.");
                return;
            }
            if (CheckIfValid(txtBreed))
            {
                MessageBox.Show("Breed is empty, please enter the breed of your pet.");
                return;
            }

            Pets pet = new Pets
            {
                PetId = PetId,
                PetName = txtName.Text,

            }


        }

        private bool CheckIfValid(Control control)
        {
            return control.Text == "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsEditing)
            {
                EditPet();
            }
            else
            {
                CreatePet();
            }
            ClearForm();
            Hide();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtName.Text = "";
            txtAnimal.Text = "";
            txtBreed.Text = "";
        }

        public void LoadPet(Pets pet)
        {
            CurrentSelectionId = pet.PetId;
            txtName.Text = pet.PetName;
            txtAnimal.Text = pet.Animal;
            txtBreed.Text = pet.Breed;
        }

        
    }
}
