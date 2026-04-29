class SensorDecorator : IRobot
{
    private IRobot robot;
    public SensorDecorator(IRobot robot)
    {
        this.robot = robot;
    }
    public string GetStatus()
    {
        return robot.GetStatus() + " + Дополнительные датчики";
    }
}