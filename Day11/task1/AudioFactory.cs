class AudioFactory : MediaFactory
{
    public override IMediaFile CreateMediaFile(string fileName)
    {
        return new AudioFile(fileName);
    }
}