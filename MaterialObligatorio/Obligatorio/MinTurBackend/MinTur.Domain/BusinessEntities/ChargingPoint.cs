using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MinTur.Exceptions;

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
        public TouristPoint TouristPoint { get; set; }
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
            Regex fourDigitRegex = new Regex(@"/^\d{4}$/");

            if (Id == null || !fourDigitRegex.IsMatch(Id.ToString()))
                throw new InvalidRequestDataException("Invalid id");
        }

        private void ValidateName()
        {
            Regex nameRegex = new Regex(@"^[a-zA-ZñÑáéíóúü ]+$");

            if (Name == null || !nameRegex.IsMatch(Name) || Name.Length > NAME_MAX_LENGTH)
                throw new InvalidRequestDataException("Invalid name");
        }

        private void ValidateAddress()
        {
            Regex addressRegex = new Regex(@"^[a-zA-ZñÑáéíóúü ]+$");

            if (Address == null || !addressRegex.IsMatch(Address) || Address.Length > ADDRESS_MAX_LENGTH)
                throw new InvalidRequestDataException("Invalid address");
        }

        private void ValidateDescription()
        {
            Regex descriptionRegex = new Regex(@"^[a-zA-ZñÑáéíóúü ]+$");

            if (Description == null || !descriptionRegex.IsMatch(Description) || Description.Length > DESCRIPTION_MAX_LENGTH)
                throw new InvalidRequestDataException("Invalid name");
        }
    }
}
