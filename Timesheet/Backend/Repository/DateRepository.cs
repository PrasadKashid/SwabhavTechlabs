using Microsoft.EntityFrameworkCore;
using Timesheet.Data;
using Timesheet.Model;

namespace Timesheet.Repository
{
    public class DateRepository : IDateRepository
    {
        private readonly TimesheetDbContext _dbContext = new TimesheetDbContext();
        //public DateRepository(TimesheetDbContext dbContext)
        //{
        //    _dbContext = dbContext;
        //}

        public IEnumerable<DateData> Get()
        {
           return _dbContext.DatesTable.Include(x => x.TimesheetList).ToList();
        }

        public void Post(DateData date)
        {
            _dbContext.DatesTable.Add(date);
           _dbContext.SaveChanges();
        }
        public DateData GetById(int id)
        {
            return _dbContext.DatesTable.Include(x => x.TimesheetList).FirstOrDefault(d => d.DateDataId == id);
        }
        public bool Delete(DateData date) { 
            _dbContext.DatesTable.Remove(date);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
