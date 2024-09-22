using System.ComponentModel.DataAnnotations.Schema;

namespace Timesheet.Model
{
    public class Activity
    {
        public int ActivityId { get; set; }
        public string Project { get; set; }
        public string SubProject { get; set; }
        public string Batch { get; set; }
        public int HoursNeeded { get; set; }
        public string ActivityDone { get; set; }

        [ForeignKey(nameof(Activity))]
        public int DateDataId { get; set; }
    }
}
