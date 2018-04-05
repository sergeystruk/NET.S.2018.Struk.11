using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookService 
{
    public class Book : IEquatable<Book>, IFormattable
    {
        #region Fields

        private readonly ISBN isbn;
        private string author;
        private string name;
        private string publishingHouse;
        private DateTime publishmentYear;
        private int pagesNumber;
        private decimal price;

        #endregion

        #region Constructions

        public Book(ISBN exactISBN, string exactAuthor, string exactName, string exactPublishingHouse,
            DateTime exactPublishmentYear, int exactPagesNumber, decimal exactPrice)
        {
            isbn = exactISBN;
            author = exactAuthor;
            name = exactName;
            publishingHouse = exactPublishingHouse;
            publishmentYear = exactPublishmentYear;
            pagesNumber = exactPagesNumber;
            price = exactPrice;
        }

        #endregion

        #region Methods

        public bool Equals(Book book)
        {
            if (ReferenceEquals(null, book))
            {
                return false;
            }

            if (ReferenceEquals(this, book))
            {
                return true;
            }

            if (isbn != book.isbn)
            {
                return false;
            }

            if (author != book.author)
            {
                return false;
            }

            if (name != book.name)
            {
                return false;
            }

            if (publishingHouse != book.publishingHouse)
            {
                return false;
            }

            if (publishmentYear != book.publishmentYear)
            {
                return false;
            }

            if (pagesNumber != book.pagesNumber)
            {
                return false;
            }

            if (price != book.price)
            {
                return false;
            }

            return true;
        }

        public string ToString(string format, IFormatProvider provider)
        {
            if (String.IsNullOrEmpty(format))
            {
                format = "G";
            }

            switch (format.ToUpperInvariant())
            {
                case "G":
                {
                    return $"ISBN 13:{isbn}, {author}, {name}, \"{publishingHouse}\", {publishmentYear}, " +
                           $"P:{pagesNumber}, {price.ToString("C", CultureInfo.CreateSpecificCulture("en-US"))}";
                }

                case "S":
                {
                    return $"{author}, {name}";
                }

                case "M":
                {
                    return $"{author}, {name}, \"{publishingHouse}\", {publishmentYear}"
                }

                case "F":
                {
                    return $"ISBN 13:{isbn}, {author}, {name}, \"{publishingHouse}\", {publishmentYear}, P:{pagesNumber}";
                }
            }

            return null;
        }

        public string ToString(string format)
        {
            if (format == null)
            {
                format = "G";
            }

            return ToString(format, null);
        }

        #endregion

        #region Overrided objects method

        public override int GetHashCode()
        {
            return isbn.ControlNumber + 10 * isbn.NumberOfBook + 10000 * isbn.PublishingHouseCode;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(obj, null))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            Book book = obj as Book;
            if (!ReferenceEquals(book, null))
            {
                return this.Equals(book);
            }

            return false;
        }
        
        #endregion
    }
}
