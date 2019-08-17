
using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ManagerBooks.Domain
{
    /// <summary>
    /// Classe responsável pelo id do tipo guid,
    /// foi definido como guid para o id do banco de dados não ser exposto teste
    /// </summary>
    public abstract class Entity
    {
        public int id { get; set; }
        [Key]
        public Guid key { get; set; }
    }
}
