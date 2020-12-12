using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using VehicleTracking.Common.Exceptions;
using VehicleTracking.Common.Query;
using VehicleTracking.Common.ViewModels;

namespace VehicleTracking.Domain.LocationTracking.Queries
{
    public class SessionViewModel : BaseViewModel
    {
        public Guid VehicleId { get; set; }

        public DateTimeOffset StartTime { get; set; }

        public DateTimeOffset? EndTime { get; set; }
    }

    public class GetSesssionByIdQuery : IQuery<Guid, Task<SessionViewModel>>
    {
        Task<SessionViewModel> IQuery<Guid, Task<SessionViewModel>>.Execute(Guid parameter)
        {
            throw new NotImplementedException();
        }
    }
}
