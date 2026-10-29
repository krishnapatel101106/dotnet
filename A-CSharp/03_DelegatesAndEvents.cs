using System;

class TemperatureSensor
{
    public event Action<int>? TemperatureChanged;

    public void SetTemperature(int temperature)
    {
        Console.WriteLine($"Temperature set to {temperature}°C");
        TemperatureChanged?.Invoke(temperature);
    }
}

class Program
{
    static void ShowAlert(int temperature)
    {
        if (temperature > 35)
            Console.WriteLine("Warning: High temperature!");
        else
            Console.WriteLine("Temperature is normal.");
    }

    static void Main()
    {
        TemperatureSensor sensor = new TemperatureSensor();
        sensor.TemperatureChanged += ShowAlert;
        sensor.SetTemperature(28);
        sensor.SetTemperature(40);
    }
}
