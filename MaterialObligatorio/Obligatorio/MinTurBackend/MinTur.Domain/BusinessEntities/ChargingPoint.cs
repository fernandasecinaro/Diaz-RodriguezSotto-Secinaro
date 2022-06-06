using System.Text.RegularExpressions;
using System.ComponentModel.DataAnnotations;
using MinTur.Exceptions;
using System.Linq;

namespace MinTur.Domain.BusinessEntities
{
    public class ChargingPoint
    {
        private readonly int NAME_MAX_LENGTH = 20;
        private readonly int DESCRIPTION_MAX_LENGTH = 60;
        private readonly int ADDRESS_MAX_LENGTH = 30;

        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public Region Region { get; set; }
        public int RegionId { get; set; }
        [Required]
        public string Description { get; set; }

        public virtual void ValidOrFail()
        {
            ValidateId();
            ValidateName();
            ValidateAddress();
            ValidateDescription();
        }

        private void ValidateId()
        {
            Regex fourDigitRegex = new Regex(@"/^([0-9])$/");

            string id = Id.ToString();
            bool isNumericId = !id.Any(c => c < '0' || c > '9');
            bool hasFourDigitsOnly = fourDigitRegex.IsMatch(id);
            if (!isNumericId || id.Length > 4)
                throw new InvalidRequestDataException("El id debe tener 4 dígitos");
        }

        private void ValidateName()
        {
            Regex nameRegex = new Regex(@"^[a-zA-ZñÑáéíóúü ]+$");

            if (Name == null || !nameRegex.IsMatch(Name) || Name.Length > NAME_MAX_LENGTH)
                throw new InvalidRequestDataException("El nombre debe tener entre 1 y 20 caracteres");
        }

        private void ValidateAddress()
        {
            Regex addressRegex = new Regex(@"^[a-zA-ZñÑáéíóúü ]+$");

            if (Address == null || !addressRegex.IsMatch(Address) || Address.Length > ADDRESS_MAX_LENGTH)
                throw new InvalidRequestDataException("La dirección debe tener entre 1 y 30 caracteres");
        }

        private void ValidateDescription()
        {
            Regex descriptionRegex = new Regex(@"^[a-zA-ZñÑáéíóúü ]+$");

            if (Description == null || !descriptionRegex.IsMatch(Description) || Description.Length > DESCRIPTION_MAX_LENGTH)
                throw new InvalidRequestDataException("La descripción debe tener entre 1 y 60 caracteres");
        }
    }
}
