namespace CollectionViewTestAppMAUI;

public static class Constant
{
    public static class Date
    {
        public const string FMT_DATEONLY = "dd/MM/yyyy";
        public const string FMT_DATETIME = "dd/MM/yyyy hh:mm tt";
        public const string FMT_DATETIME_LONG = "dd/MM/yyyy hh:mm:ss:fff tt";
        public const string FMT_DATETIME_NAMES_SHORT = "ddd, dd MMM yyyy";
        public const string FMT_TIME_12HOUR = "hh:mm tt";
        public const string FMT_yyyyMMdd_hhmmss_fffff = "yyyyMMdd_HHmmss_fffff";
        public const string FMT_yyyyMMdd = "yyyyMMdd";
    }
    
    public static class ColorKeys
    {
        public const string SUCCESS_LIGHT = "SuccessLight";
        public const string DANGER_LIGHT = "DangerLight";
        public const string PRIMARY = "Primary";
        public const string SECONDARY_DARK = "SecondaryDark";
        public const string TEXT_COLOUR = "TextColor";
        public const string TEXT_COLOUR_SECONDARY = "TextColorSecondary";
        public const string TEXT_COLOUR_DARK = "TextColorDarkBg";
    }
    
    public static class StatusColors
    {
        public static Color SUCCESS = GetAppResourceColor(ColorKeys.SUCCESS_LIGHT);
        public static Color DANGER = GetAppResourceColor(ColorKeys.DANGER_LIGHT);
        public static Color PRIMARY = GetAppResourceColor(ColorKeys.PRIMARY);
        public static Color SECONDARY = GetAppResourceColor(ColorKeys.SECONDARY_DARK);
    }
    
    public static class TextColors
    {
        public static Color PRIMARY = GetAppResourceColor(ColorKeys.TEXT_COLOUR);
        public static Color PRIMARY_LIGHT = GetAppResourceColor(ColorKeys.TEXT_COLOUR_SECONDARY);
        public static Color SECONDARY = GetAppResourceColor(ColorKeys.TEXT_COLOUR_DARK);
    }
    
    static Color GetAppResourceColor(string key)
    {
        return Application.Current.Resources.TryGetValue(key, out object color) ? (Color)color : Microsoft.Maui.Graphics.Colors.Transparent;
    }
}