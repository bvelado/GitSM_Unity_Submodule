using System;

public static class Clock {

    public static string GetMinutes()
    {
        return DateTime.Now.ToString("mm");
    }

    public static string GetHours()
    {
        return DateTime.Now.ToString("HH");
    }
}
