using System;
class AudioPlayer
{
    private static AudioPlayer instance;
    private string currentTrack;
    private bool isPlaying;
    private AudioPlayer()
    {
        currentTrack = null;
        isPlaying = false;
        Console.WriteLine("Аудиоплеер создан");
    }
    public static AudioPlayer GetInstance()
    {
        if (instance == null)
        {
            instance = new AudioPlayer();
        }
        return instance;
    }
    public void Play(string track)
    {
        if (isPlaying)
        {
            Console.WriteLine($"Остановлен: {currentTrack}");
        }
        currentTrack = track;
        isPlaying = true;
        Console.WriteLine($"Воспроизводится: {track}");
    }
    public void Stop()
    {
        if (isPlaying)
        {
            Console.WriteLine($"Остановлен: {currentTrack}");
            isPlaying = false;
            currentTrack = null;
        }
        else
        {
            Console.WriteLine("Ничего не воспроизводится");
        }
    }
}