class ImageFactory : MediaFactory
{
    public override IMediaFile CreateMediaFile(string fileName)
    {
        return new ImageFile(fileName);
    }
}