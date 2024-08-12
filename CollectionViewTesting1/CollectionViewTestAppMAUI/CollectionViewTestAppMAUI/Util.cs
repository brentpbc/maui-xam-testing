namespace CollectionViewTestAppMAUI;

public static class Util
{
    public static bool HasDate(DateTime date)
    {
        return date.Date > DateTime.MinValue.Date;
    }

    public static bool HasTime(TimeSpan time)
    {
        return time > TimeSpan.MinValue;
    }
}