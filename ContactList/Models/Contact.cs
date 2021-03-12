using ContactList.Account;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ContactList.Models
{
    public enum Category 
    { 
        [Display(Name = "Służbowy")]
        Business,
        [Display(Name = "Prywatny")]
        Personal,
        [Display(Name = "Inny")]
        Other 
    }

    /// <summary>
    /// Klasa modelu dla kontaktu.
    /// </summary>
    public class Contact
    {
        public int ContactId { get; set; }

        [Display(Name = "Imię")]
        public string Name { get; set; }

        [Display(Name = "Nazwisko")]
        public string Surname { get; set; }
        
        [Display(Name = "Email")]
        [EmailAddress]
        [StringLength(30)]
        [Index(IsUnique = true)] //Unikalność w bazie danych
        [UniqueEmail(ErrorMessage = "Taki adres email już istnieje.")] //Walidacja
        public string Email { get; set; }

        [Display(Name = "Hasło")]
        [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[#$^+=!*()@%&]).{8,}$", 
            ErrorMessage = "Hasło musi zawierać: minimum 8 znaków, dużą literę, " +
            "małą literę, cyfrę i znak specjalny.")] 
        public string Password { get; set; }

        [Display(Name = "Kategoria")]
        public Category Category { get; set; }

        [Display(Name = "Telefon")]
        public int PhoneNumber { get; set; }

        [Display(Name = "Data urodzenia")]
        [DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

    }
}