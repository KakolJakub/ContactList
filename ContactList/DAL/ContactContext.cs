using ContactList.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ContactList.DAL
{
    public class ContactContext : DbContext
    {
        /// <summary>
        /// Konstruktor bezparametrowy, dzięki któremu Entity Framework będzie korzystał 
        /// z bazy, dla której odpowiada connection string o kluczu "ExpressConnection", 
        /// znajdujący się w pliku web.config.
        /// </summary>
        public ContactContext() : base("ExpressConnection")
        {

        }

        /// <summary>
        /// Właściwość reprezentująca encję dla kontaktu w bazie danych.
        /// </summary>
        public DbSet<Contact> Contacts { get; set; }
    }
}