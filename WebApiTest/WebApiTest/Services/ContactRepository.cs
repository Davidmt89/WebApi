using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiTest.Models;

namespace WebApiTest.Services
{
    public class ContactRepository
    {
        public ContactModel[] GetAllContacts()
        {
            return new ContactModel[]
            {
                new ContactModel()
                {
                    Id = 1,
                    Name = "David",
                },
                new ContactModel()
                {
                    Id = 2,
                    Name = "Juan",
                },
            };
        }
    }
}