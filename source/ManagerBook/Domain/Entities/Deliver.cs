using ManagerBooks.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain
{
    /// <summary>
    /// Classe responsável por dados da entrega
    /// </summary>
    [Table("Book")]
    public class Deliver : Entity
    {
        public string Feedback { get; set; }
    }
}
