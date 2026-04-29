using System;
class VideoFile : IMediaFile
{
    private string fileName;
    public VideoFile(string name)
    {
        fileName = name;
    }
    public void Play()
    {
        Console.WriteLine($"Воспроизведение видео: {fileName}.mp4");
    }
}