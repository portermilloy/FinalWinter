using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalWinter
{
    public class Pets
    {
        public int PetId { get; set; }
        public string PetName { get; set; }
        public string Animal { get; set; }
        public string Breed { get; set; }

        public override string? ToString()
        {
            return $"{PetId} - {PetName} - {Animal} - {Breed}";
        }
    }
}
