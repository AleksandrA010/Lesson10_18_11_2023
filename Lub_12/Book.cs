using System;

namespace Lub_12
{
    internal class Book
    {
        public string Title {  get; private set; }      //Название
        public string Author {  get; private set; }     //Автор
        public string Publisher { get; private set; }   //Издательство
        public Book(string title, string author, string publisher)
        {
            Title = title;
            Author = author;
            Publisher = publisher;
        }
        public void BookPrint()
        {
            Console.WriteLine($"Название — {Title}.\nАвтор — {Author}.\nИздательство — {Publisher}.\n");
        }
    }
}
