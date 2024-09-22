using Timesheet.Model;
using Timesheet.Repository;

namespace Timesheet.Services
{
    public class DateService : IDateService
    {
        private readonly IDateRepository _dateRepository;

        public DateService(IDateRepository dateRepository) { 
            _dateRepository = dateRepository;
        }

        public IEnumerable<DateData> GetDateService()
        {
            return _dateRepository.Get();
        }

        public void PostDateService(DateData date)
        {
           _dateRepository.Post(date);
        }

        public bool DeleteDateService(int id)
        {
            var dateData = _dateRepository.GetById(id);
            if (dateData != null)
            {
                _dateRepository.Delete(dateData);
                return true;
            }
            return false;
        }
    }
}
