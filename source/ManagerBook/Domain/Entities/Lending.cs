using Dapper.Contrib.Extensions;
using ManagerBooks.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    /// <summary>
    /// Classe responsável por dados do empréstimo
    /// </summary>
    [Table("Lending")]
    public class Lending: Entity
    {
        public Lending()
        {
            dateLending = DateTime.Now;
            key = Guid.NewGuid();
        }
        public DateTime dateLending { get; set; }

        public DateTime dateDevolution { get; set; }

        public int PersonID { get; set; }

        public int BookID { get; set; }

        public string Conditions { get; set; }

        public bool Blocked { get; set; }

        public Guid key { get; set; }
    }
}
