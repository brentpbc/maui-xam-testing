using System;
using CollectionViewTestAppXam.Models;
using System.Collections.Generic;

namespace CollectionViewTestAppXam.ViewModels
{
    public class BasicCollectionViewViewModel : BaseViewModel
    {
        List<LogInfo> logs = LogInfo.CreateTestLogData("Collection View");
        public List<LogInfo> Logs
        {
            get { return logs; }
            set { SetProperty(ref logs, value); }
        }
    }
}

