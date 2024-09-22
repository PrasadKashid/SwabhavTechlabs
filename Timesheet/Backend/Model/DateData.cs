namespace Timesheet.Model
{
    public class DateData
    {
        public int DateDataId { get; set; }
        public DateOnly TodaysDate { get; set; }
        public bool OnLeave { get; set; }
        public List<Activity> TimesheetList { get; set; }
    }
}
