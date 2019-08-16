using ManagerBooks.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain
{
    /// <summary>
    /// Classe responsável por dados da pessoa
    /// </summary>
    [Table("Person")]
    public class Person : Entity
    {
        public Person(string name, string email)
        {
            this.name = name;
            this.email = email;
            this.guid = Guid.NewGuid();
        }

        public Person() { }
        public string name { get; set; }

        public string email { get; set; }
    }
}
