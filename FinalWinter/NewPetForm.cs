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
        private int PetCount = 0;
        private bool IsEditing;
        private int CurrentSelectionId;

        public NewPetForm(MainForm form)
        {
            InitializeComponent();
            _mainForm = form;
            PetCount++;
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
            if (CheckIfValid(txtBreed))
            {
                MessageBox.Show("Animal is empty, please enter the type of animal your pet is.");
                return;
            }
            if (CheckIfValid(txtAnimal))
            {
                MessageBox.Show("Breed is empty, please enter the breed of your pet.");
                return;
            }

            Pets pet = new Pets
            {
                PetId = PetCount,
                PetName = txtName.Text,
                Animal = txtBreed.Text,
                Breed = txtAnimal.Text
            };

            _mainForm.AddPet(pet);
            PetCount++;
        }

        private bool CheckIfValid(Control control)
        {
            return control.Text == "";
        }

        private void EditPet()
        {
            if (CheckIfValid(txtName))
            {
                MessageBox.Show("The Pet Name is empty, please enter the name of your pet.");
                return;
            }
            if (CheckIfValid(txtBreed))
            {
                MessageBox.Show("Animal is empty, please enter the type of animal your pet is.");
                return;
            }
            if (CheckIfValid(txtAnimal))
            {
                MessageBox.Show("Breed is empty, please enter the breed of your pet.");
                return;
            }

            _mainForm.EditPet(CurrentSelectionId, new Pets
            {
                PetId = CurrentSelectionId,
                PetName = txtName.Text,
                Animal = txtBreed.Text,
                Breed = txtAnimal.Text
            });

            CurrentSelectionId = -1;
            ToggleEdit(false);
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
            txtBreed.Text = "";
            txtAnimal.Text = "";
        }

        public void LoadPet(Pets pet)
        {
            CurrentSelectionId = pet.PetId;
            txtName.Text = pet.PetName;
            txtBreed.Text = pet.Animal;
            txtAnimal.Text = pet.Breed;
        }

        
    }
}
