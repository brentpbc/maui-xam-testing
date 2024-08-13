using System;
using Xamarin.Forms;

namespace CollectionViewTestAppXam.Models
{
    public class JobEvent
    {
        public string Job { get; set; }
        public string EventNo { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }

        public string DueDateEventText
        {
            get
            {
                if (DueDate.Date != DateTime.MinValue.Date)
                {
                    return DueDate.ToString("dd/MM/yy");
                }

                return "";
            }
        }
        public DateTime ActDate { get; set; }
        public DateTime ForecastDate { get; set; }
        public DateTime RegisterDate { get; set; }
        public bool HasChildEvents { get; set; } = false;
        public bool RegisterAllowed { get; set; } = false;
        public string Notes { get; set; }

        public bool ShowDueDate { get { return Util.HasDate(DueDate); } }

        public int DueDays
        {
            get
            {
                if (!Util.HasDate(DueDate))
                    return 0;

                double diff = 0;
                var finishDate = IsCompleted ? ActDate : ForecastDate;
                if (finishDate == DateTime.MinValue.Date)
                {
                    diff = (DueDate.Date - DateTime.Today.Date).TotalDays;
                }
                else
                {

                    diff = (finishDate - DueDate).TotalDays;
                }

                return (int)Math.Round(Math.Abs(diff));
            }
        }

        public bool IsCompleted
        {
            get
            {
                return Util.HasDate(ActDate);
            }
        }

        public string DisplayDate
        {
            get
            {
                if (IsCompleted)
                    return ActDate.ToString(Constant.Date.FMT_DATEONLY);

                if (Util.HasDate(ForecastDate))
                    return ForecastDate.ToString(Constant.Date.FMT_DATEONLY);
                else
                    return (CanRegister) ? "Register..." : "Locked";
            }
        }

        public bool CanRegister
        {
            get
            {
                if (IsCompleted || !RegisterAllowed)
                    return false;

                return true;
            }
        }

        public Color EventDateOutlineColor
        {
            get
            {
                if (Util.HasDate(DueDate))
                    return IsLate ? Constant.StatusColors.DANGER : Constant.StatusColors.SUCCESS;
                else
                    return Constant.StatusColors.SUCCESS;
            }
        }

        public bool IsLate
        {
            get
            {
                if (!Util.HasDate(DueDate))
                    return false;

                var finishDate = IsCompleted ? ActDate : ForecastDate;

                if (!Util.HasDate(finishDate))
                    finishDate = DateTime.Today;

                return finishDate.Date > DueDate.Date;
            }
        }

        public Color EventDateBackgroundColor
        {
            get
            {
                if (IsCompleted)
                    return IsLate ? Constant.StatusColors.DANGER : Constant.StatusColors.SUCCESS;
                else
                    return Xamarin.Forms.Color.White;
            }
        }

        public Color ForeDateBackgroundColor
        {
            get
            {
                if (IsCompleted)
                    return Constant.StatusColors.SECONDARY;
                else
                    return Xamarin.Forms.Color.White;
            }
        }

        public Color ForeDateTextColor
        {
            get
            {
                if (IsCompleted)
                    return Constant.TextColors.SECONDARY;
                else
                    return Constant.TextColors.PRIMARY;
            }
        }

        public Color DueTextColor
        {
            get
            {
                return IsLate ? Constant.StatusColors.DANGER : Constant.StatusColors.SUCCESS;
            }
        }

        public Color EventDateTextColor
        {
            get
            {
                if (IsCompleted)
                    return Constant.TextColors.SECONDARY;
                else
                    return IsLate ? Constant.StatusColors.DANGER : Constant.StatusColors.SUCCESS;
            }
        }
    }
}

