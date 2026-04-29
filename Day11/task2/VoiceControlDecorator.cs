class VoiceControlDecorator : IRobot
{
    private IRobot robot;
    public VoiceControlDecorator(IRobot robot)
    {
        this.robot = robot;
    }
    public string GetStatus()
    {
        return robot.GetStatus() + " + Голосовое управление";
    }
}