using System;
class ConfigurationManager
{
    public void LoadConfig(string path)
    {
        try
        {
            ConfigLoader loader = new ConfigLoader();
            loader.LoadConfig(path);
        }
        catch (FileNotFoundException ex)
        {
            throw new ConfigurationException("Ошибка загрузки конфигурации", ex);
        }
    }
}