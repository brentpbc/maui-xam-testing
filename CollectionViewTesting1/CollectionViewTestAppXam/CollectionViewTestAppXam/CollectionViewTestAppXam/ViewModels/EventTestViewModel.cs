using System;
using System.Collections.Generic;
using CollectionViewTestAppXam.Models;

namespace CollectionViewTestAppXam.ViewModels
{
    public class EventTestViewModel : BaseViewModel
    {        
        List<JobEvent> events = JobEvent.GenerateData();
        public List<JobEvent> Events
        {
            get { return events; }
            set { SetProperty(ref events, value); }
        }

        public EventTestViewModel()
        {

        }
    }
}

