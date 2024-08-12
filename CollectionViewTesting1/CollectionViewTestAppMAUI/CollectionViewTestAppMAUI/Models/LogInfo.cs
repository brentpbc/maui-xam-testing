namespace CollectionViewTestAppMAUI.Models;

public class LogInfo
{
    public DateTime CreatedDate { get; set; } = DateTime.Now;
    public string Location { get; set; }
    public string Action { get; set; }
    public string ErrorDescription { get; set; }
    public string ExtraData { get; set; } //Store extra serialsed data here that may be app specific e.g. connectionId
    public string CallerMemberName { get; set; } = string.Empty;
    public string CallerFilePath { get; set; } = string.Empty;
    public int CallerLineNumber { get; set; } = 0;

    
    public string TruncatedDescription
    {
        get
        {
            if (ErrorDescription.Length >= 200)
            {
                return ErrorDescription.Substring(0, 200);
            }
            else
            {
                return ErrorDescription.Substring(0, ErrorDescription.Length);
            }

        }
    }

    public static List<LogInfo> CreateTestLogData(string name)
    {
        
        var logs = new List<LogInfo>();
        for (int i = 0; i < 1000; i++)
        {
            logs.Add(new LogInfo()
            {
                Action = $"Test Error log {i}",
                CreatedDate = DateTime.Now,
                ErrorDescription = $"Testing out {name} - Error ID:{i}"
            });
        }

        return logs;
    }
}