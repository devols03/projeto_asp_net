using System;
using System.Collections;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Domain.Entities
{
    public class Client
    {
        public int ClientId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public DateTime DateRegister { get; set; }

        public bool IsActive { get; set; }

        public IEnumerable<Product> Products { get; set; }

        public bool SpecialClient( Client client)
        {
            return client.IsActive && DateTime.Now.Year - client.DateRegister.Year >= 5;
        }

    }
}
