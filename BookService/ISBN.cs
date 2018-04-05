using System;

namespace BookService
{
    public struct ISBN
    {
        #region Fields

        public static int Prefix = 978;
        public readonly int CountryCode;
        public readonly int PublishingHouseCode;
        public readonly int NumberOfBook;
        public readonly int ControlNumber;

        #endregion

        #region Constructions

        public ISBN(int countrycode, int publishinghousecode, int numberOfBook,
            int controlNumber)
        {
            CountryCode = countrycode;
            PublishingHouseCode = publishinghousecode;
            NumberOfBook = numberOfBook;
            ControlNumber = controlNumber;
        }

        #endregion

        #region Methods

        public bool Equals(ISBN isbn)
        {
            return (CountryCode == isbn.CountryCode && PublishingHouseCode == isbn.PublishingHouseCode &&
                    NumberOfBook == isbn.NumberOfBook && ControlNumber == isbn.ControlNumber);
        }

        #endregion

        #region Overrided objects methods

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj.GetType() != GetType())
            {
                return false;
            }

            ISBN isbn = (ISBN)obj;
            return Equals(isbn);
        }

        public override string ToString()
        {
            return $"{Prefix}-{CountryCode}-{PublishingHouseCode}-{NumberOfBook}-{ControlNumber}";
        }

        #endregion
        
        #region Overloaded operators

        public static bool operator ==(ISBN left, ISBN right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(ISBN left, ISBN right)
        {
            return !left.Equals(right);
        }

        #endregion


    }
}