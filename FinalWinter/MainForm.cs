using System.ComponentModel.Design.Serialization;

namespace FinalWinter
{
    public partial class MainForm : Form
    {
        private NewPetForm _petForm;
        private List<Pets> _petList;
        public MainForm()
        {
            InitializeComponent();
            _petForm = new NewPetForm();
            _petList = new List<Pets>();

            _petList.Add(new Pets
            {
                PetName = "Toasty",
                Animal = "Dog",
                Breed = "Weiner Dog"
            });

            ReloadPage();
        }

        private void ReloadPage()
        {
            dgvPets.DataSource = null;
            dgvPets.DataSource = _petList;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            _petForm.ShowDialog();
        }

        public void AddPet(Pets pet)
        {
            _petList.Add(pet);
            ReloadDataGrid();
        }

        public void EditPet(int id, Pets updPet)
        {
            var pet = _petList.Find(x => x.PetId == id);

            if (pet != null)
            {
                pet.PetName = updPet.PetName;
                pet.Animal = updPet.Animal;
                pet.Breed = updPet.Breed;

                ReloadPage();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Pets pet;

            var index = dgvPets.SelectedRows[0].Index;

            pet = _petList[index];

            _petForm.LoadPet(pet);
        }
    }
}
