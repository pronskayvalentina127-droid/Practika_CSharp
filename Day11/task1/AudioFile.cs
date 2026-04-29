using System;
class AudioFile : IMediaFile
{
    private string fileName;
    public AudioFile(string name)
    {
        fileName = name;
    }
    public void Play()
    {
        Console.WriteLine($"Воспроизведение аудио: {fileName}.mp3");
    }
}