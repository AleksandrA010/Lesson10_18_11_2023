using System;

namespace Lub_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account1 = new Account("Dmitry", "CurrentAccount");
            Account account2 = new Account("Gordon", "CurrentAccount");
            Account account3 = new Account("Pool", "BudgetAccount");

            Console.WriteLine($"ac1 == ac2 — {account1 == account2}\nac2 == ac3 — {account2 == account3}\n");
            Console.WriteLine($"ac1 != ac2 — {account1 != account2}\nac2 != ac3 — {account2 != account3}");
            Console.WriteLine("\nac1 ==(Equals) ac3 —" + account1.Equals(account3));
            Console.WriteLine("\nНомер счёта ac1" + account1.GetHashCode());
            Console.WriteLine("\nИнформация о счёте ac1: \n\n" + account1.ToString());

            ComplexNumbers complexNumber1 = new ComplexNumbers(3, 12);
            ComplexNumbers complexNumber2 = new ComplexNumbers(3, 12);
            ComplexNumbers complexNumber3 = new ComplexNumbers(3, -12);
            ComplexNumbers complexNumber4 = new ComplexNumbers(7, 5);

            Console.WriteLine($"\ncN1 == cN2 — {complexNumber1 == complexNumber2}\ncN2 == cN3 — {complexNumber2 == complexNumber3}\n");
            Console.WriteLine($"cN1 != cN2 — {complexNumber1 != complexNumber2}\ncN2 != cN3 — {complexNumber2 != complexNumber3}");
            Console.WriteLine("\ncN4 + cN3 = " + (complexNumber4 + complexNumber3).ToString());

            Book[] books = new Book[3];
            books[0] = new Book("Night Shift", "Stephen King", "ACT");
            books[1] = new Book("Children of Corn", "Stephen King", "The Dark Tower");
            books[2] = new Book("Harry Potter and the Half-Blood Prince", "J.K. Rowling", "Махаон");
            LibraryBooks library1 = new LibraryBooks(books);
            library1.Sort("Title");
            Console.WriteLine("\nПо названию.");
            library1.LibraryBooksPrint();
            library1.Sort("Author");
            Console.WriteLine("\nПо автору");
            library1.LibraryBooksPrint();
            library1.Sort("Publisher");
            Console.WriteLine("\nПо издательству");
            library1.LibraryBooksPrint();
            Console.ReadKey();
        }
    }
}
