class NavigationDecorator : IRobot
{
    private IRobot robot;
    public NavigationDecorator(IRobot robot)
    {
        this.robot = robot;
    }
    public string GetStatus()
    {
        return robot.GetStatus() + " + Улучшенная навигация";
    }
}