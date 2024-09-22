using Microsoft.EntityFrameworkCore;
using Timesheet.Model;

namespace Timesheet.Data
{
    public class TimesheetDbContext : DbContext
    {
        public DbSet<DateData> DatesTable {  get; set; }
        public DbSet<Activity> ActivitiesTable { get; set; }

        private string _ConnectionString { get; set; }
        public TimesheetDbContext()
        {
            _ConnectionString = "Data Source=DELL1528;Initial Catalog = TimeSheet ;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;";
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_ConnectionString);
        }
    }
}
