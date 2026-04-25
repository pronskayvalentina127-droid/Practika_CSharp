using System;
class Program
{
    static void Main()
    {
        UserManager manager = new UserManager();

        try
        {
            manager.DeleteUser("Admin");
        }
        catch (AdminDeletionException ex)
        {
            Console.WriteLine(ex.Message);
        }
        Console.ReadKey();
    }
}

//Задание 1: Создание пользовательского исключения
//Общие требования:
//В каждой задаче необходимо:
//Создать класс пользовательского исключения, наследуемый от Exception, который содержит:
//Конструкторы(по умолчанию и с сообщением).
//Возможность передачи InnerException.
//Создать класс с методом, в котором выбрасывается пользовательское исключение.
//В Main-методе продемонстрировать обработку исключения с помощью try-catch.
//Запрет на удаление главного администратора
//Создать исключение AdminDeletionException, если происходит попытка удалить пользователя с ролью "Admin".
//Класс UserManager должен иметь метод DeleteUser(string role), выполняющий проверку перед удалением.