using System;
class Program
{
    static void Main()
    {
        AudioPlayer player1 = AudioPlayer.GetInstance();
        AudioPlayer player2 = AudioPlayer.GetInstance();
        player1.Play("Song1.mp3");
        player2.Play("Song2.mp3");
        player1.Stop();
        Console.ReadKey();
    }
}

/*Задание 1: Реализация паттерна Singleton
Условие: В каждой задаче необходимо создать один единственный экземпляр класса, ограничив его создание через приватный конструктор и предоставляя доступ через статический метод.
7. Аудиоплеер (AudioPlayer)
Реализовать AudioPlayer, который управляет воспроизведением аудио.
Метод Play(string track): воспроизводит трек.
Метод Stop(): останавливает воспроизведение.
Должен существовать только один аудиоплеер.*/