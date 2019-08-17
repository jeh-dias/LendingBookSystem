using Domain;
using ManagerBooks.Services.Interfaces;
using Repository.Interfaces;
using System;
using System.Collections.Generic;

namespace Services
{
    /// <summary>
    /// Esta classe é responsável por receber dados de livro que estão na camada de aplicação
    /// e enviar para a camada de negócios
    /// </summary>
    public class BookServices : IBookServices
    {
        private readonly IBookRepository _bookRepository;
        public BookServices(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }
        /// <summary>
        /// Este método é responsável por interagir com o repositório e chamar o 
        /// método para remover o livro
        /// </summary>
        /// <param name="Book"></param>
        /// <returns></returns>
        public bool Delete(Book book)
        {
           return _bookRepository.Delete(book);
        }

        /// <summary>
        //Este método é responsável por interagir com o repositório e chamar o
        /// método para atualizar o livro
        /// </summary>
        /// <returns></returns>
        public List<Book> GetAll()
        {
            return _bookRepository.GetAll();
        }

        /// <summary>
        //  Este método é responsável por interagir com o repositório e chamar o
        /// método para buscar um livro de acordo com a key 
        /// </summary>
        /// <returns></returns>
        public Book GetByKey(Guid key)
        {
            return _bookRepository.GetByKey(key);
        }

        /// <summary>
        ///  Este método é responsável por interagir com o repositório e chamar o
        ///  método para inserir um livro
        /// </summary>
        /// <param name="book"></param>
        /// <returns></returns>
        public Book Insert(Book book)
        {
            book.key = Guid.NewGuid();
            return _bookRepository.Insert(book);
        }

        /// <summary>
        ///  Este método é responsável por interagir com o repositório e chamar o
        ///  método para atualizar um livro
        /// </summary>
        /// <param name="book"></param>
        /// <returns></returns>
        public Book Update(Book book)
        {
            return _bookRepository.Update(book);
        }
    }
}
