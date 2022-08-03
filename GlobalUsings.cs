global using System.Text.Json;
global using System.Globalization;

public static class JsonOptions
{
    public static JsonSerializerOptions Options
    {
        get
        {
            return new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
        }
    }
}

