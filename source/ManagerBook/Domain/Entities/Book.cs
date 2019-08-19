using Dapper.Contrib.Extensions;
using ManagerBooks.Domain;
using System;

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
        }

        public Book()
        {
            this.key = Guid.NewGuid();
        }
        public int isbn { get; set; }
        public string name { get; set; }
        public string author { get; set; }
    }
}
