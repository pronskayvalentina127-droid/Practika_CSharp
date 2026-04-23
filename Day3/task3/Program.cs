using System;
abstract class Book
{
    public string Title;
    public string Author;
    public int Pages;
}
sealed class FictionBook : Book { }
sealed class NonFictionBook : Book { }
class Library
{
    public Book[] Books;

    public Book GetMostPagesBook()
    {
        Book max = Books[0];
        for (int i = 1; i < Books.Length; i++)
            if (Books[i].Pages > max.Pages) max = Books[i];
        return max;
    }
    public Book[] GetBooksByAuthor(string author)
    {
        int count = 0;
        for (int i = 0; i < Books.Length; i++)
            if (Books[i].Author == author) count++;
        Book[] result = new Book[count];
        int index = 0;
        for (int i = 0; i < Books.Length; i++)
            if (Books[i].Author == author) result[index++] = Books[i];
        return result;
    }
}
class Program
{
    static void Main()
    {
        Book[] books = new Book[]
        {
            new FictionBook { Title = "Война и мир", Author = "Толстой", Pages = 1225 },
            new FictionBook { Title = "Анна Каренина", Author = "Толстой", Pages = 864 },
            new NonFictionBook { Title = "Sapiens", Author = "Харари", Pages = 512 }
        };
        Library lib = new Library { Books = books };
        Book most = lib.GetMostPagesBook();
        Console.WriteLine("Книга с наибольшим количеством страниц:");
        Console.WriteLine(most.Title + ' ' + most.Author + ' ' + most.Pages + ' ' + " стр.");

        Console.WriteLine("\nКниги автора Толстой:");
        Book[] byAuthor = lib.GetBooksByAuthor("Толстой");
        for (int i = 0; i < byAuthor.Length; i++)
        {
            Console.WriteLine(byAuthor[i].Title + ' ' + byAuthor[i].Pages + " стр.");
        }
        Console.ReadKey();
    }
}

//В этом задании вам предстоит разработать иерархию классов с использованием abstract и sealed классов.
//В каждой задаче у вас должен быть абстрактный класс (родительский), sealed класс (конкретная реализация), модельный класс с массивом объектов, а также два метода бизнес-логики.

//7. Система управления книгами в библиотеке
//Разработайте систему учета книг в библиотеке.
//Структура классов:
////abstract класс Book с полями Title, Author, Pages.
////sealed классы FictionBook и NonFictionBook.
//Library (модельный класс) с массивом Book[].
//Методы бизнес-логики:
////GetMostPagesBook() – находит книгу с наибольшим количеством страниц.
////GetBooksByAuthor(string author) – возвращает все книги указанного автора.
