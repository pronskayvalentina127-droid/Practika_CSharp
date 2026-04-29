using System;
class Program
{
    static void Main()
    {
        MediaFactory audioFactory = new AudioFactory();
        MediaFactory videoFactory = new VideoFactory();
        MediaFactory imageFactory = new ImageFactory();
        IMediaFile song = audioFactory.CreateMediaFile("song");
        IMediaFile movie = videoFactory.CreateMediaFile("movie");
        IMediaFile photo = imageFactory.CreateMediaFile("photo");
        song.Play();
        movie.Play();
        photo.Play();
        Console.ReadKey();
    }
}

/*Задание 1: Реализация паттерна &quot;Фабричный метод&quot;
Фабричный метод применяется для создания объектов без жесткой привязки
к их конкретным классам. Это позволяет делегировать создание объектов
подклассам, обеспечивая гибкость и расширяемость кода.
Общие компоненты:
Абстрактный класс или интерфейс продукта – определяет общий
интерфейс создаваемых объектов.
Конкретные классы продукта – реализуют интерфейс продукта.
Абстрактный класс фабрики – определяет метод создания объектов.
Конкретные классы фабрики – реализуют создание конкретных
объектов.
7. Мультимедийные файлы (аудио, видео, изображение)
Классы и их взаимодействие:
IMediaFile – интерфейс с Play().
AudioFile, VideoFile, ImageFile – классы файлов.
MediaFactory – абстрактная фабрика.
AudioFactory, VideoFactory, ImageFactory – конкретные фабрики.*/