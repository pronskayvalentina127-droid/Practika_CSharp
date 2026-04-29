class VideoFactory : MediaFactory
{
    public override IMediaFile CreateMediaFile(string fileName)
    {
        return new VideoFile(fileName);
    }
}