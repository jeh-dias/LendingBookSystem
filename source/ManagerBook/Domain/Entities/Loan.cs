using ManagerBooks.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    /// <summary>
    /// Classe responsável por dados do empréstimo
    /// </summary>
    public class Loan : Entity
    {
        private DateTime date { get; set; }

        private DateTime dateDevolution { get; set; }

        private int PersonID { get; set; }

        private string Conditions { get; set; }

        private bool Blocked { get; set; }
    }
}
