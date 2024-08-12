using CollectionViewTestAppMAUI.Models;

namespace CollectionViewTestAppMAUI.ViewModels;

public class CollectionViewViewModel:BaseViewModel
{
    List<LogInfo> logs = LogInfo.CreateTestLogData("Collection View");
    public List<LogInfo> Logs
    {
        get { return logs; }
        set { SetProperty(ref logs, value); }
    }
}