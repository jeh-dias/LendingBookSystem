using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace ManagerBooks.Services.Interfaces
{
    /// <summary>
    /// Este é o contrato dos serviços disponíveis para a entidade livros
    /// </summary>
    public interface IBookServices
    {
        bool Delete(Book book);
        List<Book> GetAll();
        Book GetById(int guid);
        Book Insert(Book book);
        Book Update(Book book);

    }
}
