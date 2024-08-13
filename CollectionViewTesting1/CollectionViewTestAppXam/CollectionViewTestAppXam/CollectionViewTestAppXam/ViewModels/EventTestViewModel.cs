using System;
using System.Collections.Generic;
using CollectionViewTestAppXam.Models;

namespace CollectionViewTestAppXam.ViewModels
{
    public class EventTestViewModel : BaseViewModel
    {
        List<JobEvent> events = new List<JobEvent>()
    {
        new JobEvent()
        {
            Job = "100020",
            EventNo = "1000",
            Description = "Job Start",
            DueDate = DateTime.Today - TimeSpan.FromDays(50),
            ActDate = DateTime.Today - TimeSpan.FromDays(53),
            RegisterDate = DateTime.Today - TimeSpan.FromDays(53),
            Notes = "Started Job"
        },
        new JobEvent()
        {
            Job = "100020",
            EventNo = "10001",
            Description = "Kick Off Meeting ",
            DueDate = DateTime.Today - TimeSpan.FromDays(50),
            ActDate = DateTime.Today - TimeSpan.FromDays(53),
            RegisterDate = DateTime.Today - TimeSpan.FromDays(53),
            Notes = "Kick Off Meeting"
        },
        new JobEvent()
        {
            Job = "100020",
            EventNo = "1100",
            Description = "Pre-Site Inspection",
            DueDate = DateTime.Today - TimeSpan.FromDays(50),
            ActDate = DateTime.Today - TimeSpan.FromDays(53),
            RegisterDate = DateTime.Today - TimeSpan.FromDays(53),
            Notes = "Pre-Site Inspection"
        },
        new JobEvent()
        {
            Job = "100020",
            EventNo = "6000",
            Description = "Slab Down (early)",
            DueDate = DateTime.Today - TimeSpan.FromDays(50),
            ActDate = DateTime.Today - TimeSpan.FromDays(53),
            RegisterDate = DateTime.Today - TimeSpan.FromDays(53),
            Notes = "Test Note"
        },
        new JobEvent()
        {
            Job = "100020",
            EventNo = "6000",
            Description = "Slab Down (Late)",
            DueDate = DateTime.Today - TimeSpan.FromDays(5),
            ActDate = DateTime.Today,
            RegisterDate = DateTime.Today+ TimeSpan.FromDays(1),
            Notes = "Poured Yesterday"
        },
        new JobEvent()
        {
            Job = "100020",
            EventNo = "6000",
            Description = "Slab Down (Can Unreg)",
            DueDate = DateTime.Today - TimeSpan.FromDays(5),
            ActDate = DateTime.Today,
            RegisterDate = DateTime.Today+ TimeSpan.FromDays(1),
            Notes = "Poured Yesterday",
            RegisterAllowed = true
        },
        new JobEvent()
        {
            Job = "100020",
            EventNo = "6500",
            Description = "Frame Up 1 (Locked)",
            DueDate = DateTime.MinValue,            
            ActDate = DateTime.MinValue,
            RegisterDate = DateTime.MinValue,
            ForecastDate = DateTime.MinValue,
            RegisterAllowed = false,
        },
        new JobEvent()
        {
            Job = "100020",
            EventNo = "6500",
            Description = "Frame Up 2",
            DueDate = DateTime.Today + TimeSpan.FromDays(5),            
            ActDate = DateTime.MinValue,
            RegisterDate = DateTime.MinValue,
            RegisterAllowed = true,
        },
        new JobEvent()
        {
            Job = "100020",
            EventNo = "6500",
            Description = "Frame Up 3 (Overdue No Fdate)",
            DueDate = DateTime.Today - TimeSpan.FromDays(10),            
            ActDate = DateTime.MinValue,
            RegisterDate = DateTime.MinValue,
            RegisterAllowed = true,
        },
        new JobEvent()
        {
            Job = "100020",
            EventNo = "6500",
            Description = "Frame Up 4 (Forecast Late)",
            DueDate = DateTime.Today + TimeSpan.FromDays(5),
            ForecastDate = DateTime.Today + TimeSpan.FromDays(7),
            ActDate = DateTime.MinValue,
            RegisterDate = DateTime.MinValue,
            RegisterAllowed = true,
            Notes = "Test Note"
        },
        new JobEvent()
        {
            Job = "100020",
            EventNo = "6500",
            Description = "Frame Up 5 (No Due Date)",            
            ForecastDate = DateTime.Today + TimeSpan.FromDays(5),
            ActDate = DateTime.MinValue,
            RegisterDate = DateTime.MinValue,
            RegisterAllowed = true,
            Notes = "Test Note",
            HasChildEvents = true
        },
        new JobEvent()
        {
            Job = "100020",
            EventNo = "6500",
            Description = "Frame Up 6 (No Due/Fore Date)",
            DueDate = DateTime.MinValue,
            ForecastDate = DateTime.MinValue,
            ActDate = DateTime.MinValue,
            RegisterDate = DateTime.MinValue,
            RegisterAllowed = true,
            Notes = String.Empty,
            HasChildEvents = false
        },
        new JobEvent()
        {
            Job = "100020",
            EventNo = "6600",
            Description = "Roof On W Checklist",
            DueDate = DateTime.Today + TimeSpan.FromDays(10),
            ActDate = DateTime.MinValue,
            RegisterDate = DateTime.MinValue,
            HasChildEvents = true
        },
        new JobEvent()
        {
            Job = "100020",
            EventNo = "6601",
            Description = "Roof On W Checklist 2",
            DueDate = DateTime.Today + TimeSpan.FromDays(10),
            ForecastDate = DateTime.Today + TimeSpan.FromDays(10),
            ActDate = DateTime.MinValue,
            RegisterDate = DateTime.MinValue,
            HasChildEvents = true
        },
        new JobEvent()
        {
            Job = "100020",
            EventNo = "6000",
            Description = "Roof On W Checklist 3",
            DueDate = DateTime.Today + TimeSpan.FromDays(30),
            ForecastDate = DateTime.Today + TimeSpan.FromDays(20),
            ActDate = DateTime.MinValue,
            RegisterDate = DateTime.MinValue,
            HasChildEvents = true,
            RegisterAllowed = true
        },
        new JobEvent()
        {
            Job = "100020",
            EventNo = "6202",
            Description = "Brickwork Complete",
            DueDate = DateTime.Today + TimeSpan.FromDays(31),
            ForecastDate = DateTime.Today + TimeSpan.FromDays(21),
            ActDate = DateTime.MinValue,
            RegisterDate = DateTime.MinValue,
            HasChildEvents = true,
            RegisterAllowed = true
        },
        new JobEvent()
        {
            Job = "100020",
            EventNo = "6300",
            Description = "Internal Lockup Complete",
            DueDate = DateTime.Today + TimeSpan.FromDays(32),
            ForecastDate = DateTime.Today + TimeSpan.FromDays(22),
            ActDate = DateTime.MinValue,
            RegisterDate = DateTime.MinValue,
            HasChildEvents = true,
            RegisterAllowed = true
        },
        new JobEvent()
        {
            Job = "100020",
            EventNo = "7100",
            Description = "Electrical Fit Off 1",
            DueDate = DateTime.Today + TimeSpan.FromDays(35),
            ForecastDate = DateTime.Today + TimeSpan.FromDays(25),
            ActDate = DateTime.MinValue,
            RegisterDate = DateTime.MinValue,
            HasChildEvents = true,
            RegisterAllowed = true
        },
        new JobEvent()
        {
            Job = "100020",
            EventNo = "7200",
            Description = "Electrical Fit Off 2",
            DueDate = DateTime.Today + TimeSpan.FromDays(40),
            ForecastDate = DateTime.Today + TimeSpan.FromDays(35),
            ActDate = DateTime.MinValue,
            RegisterDate = DateTime.MinValue,
            HasChildEvents = true,
            Notes = "Second Electrical Fit Off",
            RegisterAllowed = true
        },
        new JobEvent()
        {
            Job = "100020",
            EventNo = "7300",
            Description = "Electrical Fit Off 3",
            DueDate = DateTime.Today + TimeSpan.FromDays(45),
            ForecastDate = DateTime.Today + TimeSpan.FromDays(40),
            ActDate = DateTime.MinValue,
            RegisterDate = DateTime.MinValue,
            HasChildEvents = true,
            RegisterAllowed = true
        },
        new JobEvent()
        {
            Job = "100020",
            EventNo = "7300",
            Description = "Electrical Fit Off 3",
            DueDate = DateTime.Today + TimeSpan.FromDays(45),
            ForecastDate = DateTime.Today + TimeSpan.FromDays(40),
            ActDate = DateTime.MinValue,
            RegisterDate = DateTime.MinValue,
            HasChildEvents = true,
            RegisterAllowed = true
        },
        new JobEvent()
        {
            Job = "100020",
            EventNo = "7500",
            Description = "Pre Plaster Inspection",
            DueDate = DateTime.Today + TimeSpan.FromDays(46),
            ForecastDate = DateTime.Today + TimeSpan.FromDays(41),
            ActDate = DateTime.MinValue,
            RegisterDate = DateTime.MinValue,
            HasChildEvents = true,
            RegisterAllowed = true
        },
        new JobEvent()
        {
            Job = "100020",
            EventNo = "7550",
            Description = "Plaster Complete",
            DueDate = DateTime.Today + TimeSpan.FromDays(50),
            ForecastDate = DateTime.Today + TimeSpan.FromDays(45),
            ActDate = DateTime.MinValue,
            RegisterDate = DateTime.MinValue,
            HasChildEvents = true,
            RegisterAllowed = true
        },
        new JobEvent()
        {
            Job = "100020",
            EventNo = "9000",
            Description = "Book Handover",
            DueDate = DateTime.Today + TimeSpan.FromDays(100),
            ForecastDate = DateTime.Today + TimeSpan.FromDays(99),
            ActDate = DateTime.MinValue,
            RegisterDate = DateTime.MinValue,
            HasChildEvents = true,
            RegisterAllowed = true
        },
        new JobEvent()
        {
            Job = "100020",
            EventNo = "9001",
            Description = "Handover Booked",
            DueDate = DateTime.Today + TimeSpan.FromDays(100),
            ForecastDate = DateTime.Today + TimeSpan.FromDays(99),
            ActDate = DateTime.MinValue,
            RegisterDate = DateTime.MinValue,
            HasChildEvents = true,
            RegisterAllowed = true
        },
        new JobEvent()
        {
            Job = "100020",
            EventNo = "9002",
            Description = "Handover Meeting",
            DueDate = DateTime.Today + TimeSpan.FromDays(100),
            ForecastDate = DateTime.Today + TimeSpan.FromDays(99),
            ActDate = DateTime.MinValue,
            RegisterDate = DateTime.MinValue,
            HasChildEvents = true,
            RegisterAllowed = true
        },
        new JobEvent()
        {
            Job = "100020",
            EventNo = "99000",
            Description = "Job Closed",
            DueDate = DateTime.Today - TimeSpan.FromDays(50),
            ActDate = DateTime.Today - TimeSpan.FromDays(53),
            RegisterDate = DateTime.Today - TimeSpan.FromDays(53),
            Notes = "Job Closed"
        },
        new JobEvent()
        {
            Job = "100020",
            EventNo = "99000",
            Description = "Job Closed",
            DueDate = DateTime.Today - TimeSpan.FromDays(200),
            ActDate = DateTime.Today - TimeSpan.FromDays(150),
            RegisterDate = DateTime.Today - TimeSpan.FromDays(145),
            Notes = "Job Closed"
        },
        new JobEvent()
        {
            Job = "100020",
            EventNo = "99999",
            Description = "Job On Hold",
            DueDate = DateTime.Today - TimeSpan.FromDays(200),
            ActDate = DateTime.Today - TimeSpan.FromDays(150),
            RegisterDate = DateTime.Today - TimeSpan.FromDays(145),
            Notes = "Job On Hold"
        },
        new JobEvent()
        {
            Job = "100020",
            EventNo = "99999",
            Description = "Job Cancelled",
            DueDate = DateTime.Today - TimeSpan.FromDays(200),
            ActDate = DateTime.Today - TimeSpan.FromDays(150),
            RegisterDate = DateTime.Today - TimeSpan.FromDays(145),
            Notes = "Job Cancelled"
        },

    };

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

