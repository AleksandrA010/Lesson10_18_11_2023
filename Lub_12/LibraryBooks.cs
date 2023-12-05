using System;

namespace Lub_12
{
    internal class LibraryBooks
    {
        delegate void SortLibrary();
        private Book[] Books;
        public LibraryBooks(Book[] books)
        {
            Books = books;
        }
        SortLibrary sort;
        public void LibraryBooksPrint()
        {
            for (int i = 0; i < Books.Length; i++)
            {
                Books[i].BookPrint();
            }
        }
        public void Sort(string typeSort)
        {
            switch (typeSort)
            {
                case "Title":
                    sort = SortTitle;
                    sort();
                    break;
                case "Author":
                    sort = SortAuthor;
                    sort();
                    break;
                case "Publisher":
                    sort = SortPublisher;
                    sort();
                    break;
            }
        }
        private void SortTitle()
        {
            for (int i = 0, j = 1; j < Books.Length; i++, j++)
            {
                char char1 = Convert.ToChar(Books[i].Title[0]);
                char char2 = Convert.ToChar(Books[j].Title[0]);
                if (char1 > char2)
                {
                    (Books[i], Books[j]) = (Books[j], Books[i]);
                    i = 0;
                    j = 1;
                }
            }
        }
        private void SortAuthor()
        {
            for (int i = 0, j = 1; j < Books.Length; i++, j++)
            {
                char char1 = Convert.ToChar(Books[i].Author[0]);
                char char2 = Convert.ToChar(Books[j].Author[0]);
                if (char1 > char2)
                {
                    (Books[i], Books[j]) = (Books[j], Books[i]);
                    i = 0;
                    j = 1;
                }
            }
        }
        private void SortPublisher()
        {
            for (int i = 0, j = 1; j < Books.Length; i++, j++)
            {
                char char1 = Convert.ToChar(Books[i].Publisher[0]);
                char char2 = Convert.ToChar(Books[j].Publisher[0]);
                if (char1 > char2)
                {
                    (Books[i], Books[j]) = (Books[j], Books[i]);
                    i = 0;
                    j = 1;
                }
            }
        }
    }
}
