using Timesheet.Model;

namespace Timesheet.Repository
{
    public interface IDateRepository
    {
        IEnumerable<DateData> Get();
        DateData GetById(int id);
        void Post(DateData date);
        bool Delete(DateData date);
    }
}
