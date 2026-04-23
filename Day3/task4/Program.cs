using System;
partial class Book { }
class Library
{
    public Book[] Books;
    public Library(Book[] books)
    {
        Books = books;
    }
    // метод находит книгу с наибольшим количеством страниц
    public Book GetLongestBook()
    {
        if (Books.Length == 0) return null;
        Book longest = Books[0];
        for (int i = 1; i < Books.Length; i++)
        {
            if (Books[i].Pages > longest.Pages)
                longest = Books[i];
        }
        return longest;
    }
    // метод возвращает книги указанного жанра
    public Book[] GetBooksByGenre(string genre)
    {
        int count = 0;
        for (int i = 0; i < Books.Length; i++)
        {
            if (Books[i].Genre == genre)
                count++;
        }

        Book[] result = new Book[count];
        int index = 0;
        for (int i = 0; i < Books.Length; i++)
        {
            if (Books[i].Genre == genre)
            {
                result[index] = Books[i];
                index++;
            }
        }
        return result;
    }
}
class Program
{
    static void Main()
    {
        Book[] books = new Book[]
        {
            new Book { Title = "Война и мир", Author = "Толстой", Pages = 1225, Genre = "Роман" },
            new Book { Title = "Преступление и наказание", Author = "Достоевский", Pages = 672, Genre = "Роман" },
            new Book { Title = "Краткая история времени", Author = "Хокинг", Pages = 256, Genre = "Наука" },
            new Book { Title = "Мастер и Маргарита", Author = "Булгаков", Pages = 480, Genre = "Роман" },
            new Book { Title = "Sapiens", Author = "Харари", Pages = 512, Genre = "Наука" }
        };

        Library lib = new Library(books);
        Console.WriteLine("Все книги в библиотеке:");
        for (int i = 0; i < lib.Books.Length; i++)
        {
            lib.Books[i].DisplayInfo();
        }
        Console.WriteLine("\nКнига с наибольшим количеством страниц: ");
        Book longest = lib.GetLongestBook();
        longest.DisplayInfo();
        Console.WriteLine("\nКниги жанра: Роман: ");
        Book[] byGenre = lib.GetBooksByGenre("Роман");
        for (int i = 0; i < byGenre.Length; i++)
        {
            byGenre[i].DisplayInfo();
        }
        Console.ReadKey();
    }
}

//7. Система учета книг в библиотеке
//Структура классов:
////partial класс Book: 
//В первой части (Book.Data.cs) – Title, Author, Pages, Genre.
//В другой (Book.Methods.cs) – методы работы с книгами.
//Library (модельный класс) с массивом Book[].
//Методы бизнес-логики:
////GetLongestBook() – находит книгу с наибольшим количеством страниц.
////GetBooksByGenre(string genre) – возвращает книги указанного жанра.
