using ManagerBooks.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    /// <summary>
    /// Classe responsável por dados da entrega
    /// </summary>
    public class Deliver : Entity
    {
        public string Feedback { get; set; }
    }
}
