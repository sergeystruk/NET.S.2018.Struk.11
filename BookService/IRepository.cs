using System.Collections.Generic;

namespace BookService
{
    public interface IRepository
    {
        List<Book> GetBooks();
        void SetBooks(List<Book> list);
    }
}