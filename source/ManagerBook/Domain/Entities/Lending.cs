using ManagerBooks.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain
{
    /// <summary>
    /// Classe responsável por dados do empréstimo
    /// </summary>
    [Table("Lending")]
    public class Lending: Entity
    {
        public DateTime dateLending { get; set; }

        public DateTime dateDevolution { get; set; }

        public int PersonID { get; set; }

        public string Conditions { get; set; }

        public bool Blocked { get; set; }
    }
}
