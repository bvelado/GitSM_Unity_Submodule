using System;

public static class Clock {

    public static string GetMinutes(string format = "mm")
    {
        return DateTime.Now.ToString(format);
    }

    public static string GetHours(string format ="HH")
    {
        return DateTime.Now.ToString(format);
    }
}
