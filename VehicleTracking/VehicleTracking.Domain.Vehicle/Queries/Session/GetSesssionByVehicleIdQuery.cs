using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Threading.Tasks;
using VehicleTracking.Common.Exceptions;
using VehicleTracking.Common.Query;

namespace VehicleTracking.Domain.LocationTracking.Queries
{
    public class GetSesssionByVehicleIdQuery : IQuery<Guid, Task<SessionViewModel>>
    {
        public Task<SessionViewModel> Execute(Guid parameter)
        {
            throw new NotImplementedException();
        }
    }
}
