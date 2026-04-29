using System;
class ImageFile : IMediaFile
{
    private string fileName;
    public ImageFile(string name)
    {
        fileName = name;
    }
    public void Play()
    {
        Console.WriteLine($"Просмотр изображения: {fileName}.jpg");
    }
}