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
        /// 
        /// </summary>
        /// <param name="Book"></param>
        /// <returns></returns>
        public bool Delete(Book book)
        {
           return _bookRepository.Delete(book);
        }

        public List<Book> GetAll()
        {
            return _bookRepository.GetAll();
        }

        public Book GetById(Guid guid)
        {
            return _bookRepository.GetById(guid);
        }

        public Book Insert(Book book)
        {
            return _bookRepository.Insert(book);
        }

        public Book Update(Book book)
        {
            return _bookRepository.Update(book);
        }
    }
}
