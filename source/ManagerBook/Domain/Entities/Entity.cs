using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ManagerBooks.Domain
{
    /// <summary>
    /// Classe responsável pelo id do tipo guid,
    /// foi definido como guid para o id do banco de dados não ser exposto
    /// </summary>
    public abstract class Entity
    {
        [Key]
        public int id { get; set; }
        public Guid guid { get; set; }
    }
}
