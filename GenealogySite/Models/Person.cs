using System;
using System.ComponentModel.DataAnnotations;

namespace GenealogySite.Models
{
    public class Person
    {
        private string fullName = "";
        private string fullFirstName = "";
        private string primaryFirstName = "";
        private string lastName = "";
        private string gender = "";

        public int Id { get; set; }

        // Names
        [Display(Name = "Personnamn")]
        public string FullName { get => fullName; set => fullName = value; }
        [Display(Name = "Förnamn")]
        public string FullFirstName { get => fullFirstName; set => fullFirstName = value; }
        [Display(Name = "Tilltalsnamn")]
        public string PrimaryFirstName { get => primaryFirstName; set => primaryFirstName = value; }
        [Display(Name = "Mellannamn")]
        public string? MiddleName { get; set; }
        [Display(Name = "Efternamn")]
        public string LastName { get => lastName; set => lastName = value; }

        // Gender
        [Display(Name = "Kön")]
        public string Gender { get => gender; set => gender = value; }

        // Date of Birth
        [Display(Name = "Födelsedatum")]
        [DataType(DataType.Date)]
        public DateTime? DateOfBirth { get; set; }

        // Date of Decease
        [Display(Name = "Dödsdatum")]
        [DataType(DataType.Date)]
        public DateTime? DateOfDecease { get; set; }

        // Parental / Ancesteral Relations
        [Display(Name = "Barn")]
        public Person[]? Child { get; set; }

        // Partnerships
        [Display(Name = "Partners")]
        public Person[]? Partner { get; set; }

    }
}