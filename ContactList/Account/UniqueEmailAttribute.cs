using ContactList.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ContactList.Account
{
    /// <summary>
    /// Atrybut walidacyjny wyszukujący adres email w bazie.
    /// </summary>
    public class UniqueEmailAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            ContactContext db = new ContactContext();

            var emailDuplicate = db.Contacts.SingleOrDefault(c => c.Email == (string)value);
            return emailDuplicate == null;
        }
    }
}