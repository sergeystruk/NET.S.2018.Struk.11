using System.Collections.Generic;

namespace BookService
{
    public interface IFinder
    {
        bool IsMatch(Book book);
    }
}