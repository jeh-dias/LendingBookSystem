using ManagerBooks.Domain;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    /// <summary>
    /// Classe responsável por dados de livro
    /// </summary>
    [Table("Book")]
    public class Book : Entity
    {
        public Book(int isbn, string name, string author)
        {
            this.isbn = isbn;
            this.name = name;
            this.author = author;
            this.guid = System.Guid.NewGuid();
        }

        public Book()
        {

        }
        public int isbn { get; set; }
        public string name { get; set; }
        public string author { get; set; }
    }
}
