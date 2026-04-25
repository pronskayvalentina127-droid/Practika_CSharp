class TemperatureSensor
{
    private int temperature;
    public void SetTemperature(int temp)
    {
        if (temp < -50 || temp > 50)
        {
            throw new TemperatureOutOfRangeException(
                $"Температура {temp} вне допустимого диапазона [-50, 50]"
            );
        }
        temperature = temp;
    }
}