using Timesheet.Model;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Timesheet.Services
{
    public interface IDateService
    {
        IEnumerable<DateData> GetDateService();
        void PostDateService(DateData date);

        bool DeleteDateService(int id);
    }
}
