using System;
using System.Collections.Generic;

namespace BookService
{
    public static class BookListService 
    {
        public static void AddBook(List<Book> list, Book book)
        {
            if (list == null)
            {
                throw new ArgumentNullException(nameof(list));
            }

            list.Add(book);
        }

        public static void RemoveBook(List<Book> list, Book book)
        {
            if (list == null)
            {
                throw new ArgumentNullException(nameof(list));
            }
            if (list.Contains(book))
            {
                list.Remove(book);
            }
            else
            {
                throw new ArgumentException(nameof(book));
            }
        }

        public static void SortBooksByTag(List<Book> list, IComparer<Book> comparer)
        {
            list.Sort(comparer);
        }

        public static Book FindBookByTag(List<Book> list, IFinder finder)
        {
            foreach (Book book in list)
            {
                if (finder.IsMatch(book))
                {
                    return book;
                }
            }

            return null;
        }
    }
}