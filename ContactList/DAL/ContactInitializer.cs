using ContactList.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ContactList.DAL
{
    /// <summary>
    /// Klasa inicjująca dodanie testowych danych (kontaktów) do bazy.
    /// </summary>
    public class ContactInitializer : DropCreateDatabaseAlways<ContactContext>
    {
        /// <summary>
        /// Metoda wstrzykująca dane.
        /// </summary>
        protected override void Seed(ContactContext context)
        {
            var contacts = new List<Contact>
            {
                new Contact() { Name = "Jan", Surname = "Kowalski", Email = "jkowalski@gmail.com", Password = "Ab#12345", Category = Category.Business, PhoneNumber = 123456789, BirthDate = new DateTime(2000, 12, 24) },
                new Contact() { Name = "Stanisław", Surname = "Nowak", Email = "snowak@gmail.com", Password = "Bc#12345", Category = Category.Personal, PhoneNumber = 987654321, BirthDate = new DateTime(1995, 9, 7)},
                new Contact() { Name = "Barbara", Surname = "Gierusz", Email = "bgierusz@gmail.com", Password = "Cd#12345", Category = Category.Other, PhoneNumber = 111222333, BirthDate = new DateTime(1981, 3, 3)}
            };

            contacts.ForEach(e => context.Contacts.Add(e));
            context.SaveChanges();
        }
    }
}