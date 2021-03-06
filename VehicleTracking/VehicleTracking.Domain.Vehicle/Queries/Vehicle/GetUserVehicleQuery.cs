﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using VehicalTracking.Domain.ApplicationUser.Infrastructure;
using VehicleTracking.Common.Exceptions;
using VehicleTracking.Common.Query;
using VehicleTracking.Common.ViewModels;

namespace VehicleTracking.Domain.Vehicle.Queries
{
    public class GetUserVehicleViewModel
    {
        public Guid UserId { get; set; }

        [Required]
        public string Code { get; set; }
    }

    public class GetUserVehicleQuery : IQuery<GetUserVehicleViewModel, Task<VehicleViewModel>>
    {
        private readonly VehicleContext _context;
        private readonly ILogger<GetUserVehicleQuery> _logger;

        public GetUserVehicleQuery(VehicleContext context, ILogger<GetUserVehicleQuery> logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<VehicleViewModel> Execute(GetUserVehicleViewModel parameters)
        {
            var vehicle = await _context.Vehicles.Where(v => v.Code == parameters.Code
                && v.UserId == parameters.UserId
                && v.IsActive).FirstOrDefaultAsync();

            if (vehicle == null)
            {
                throw new CustomException(ErrorCodes.EC_Vehicle_001, parameters.Code);
            }

            return new VehicleViewModel()
            {
                Id = vehicle.Id,
                UserId = vehicle.UserId,
                Code = vehicle.Code
            };
        }
    }
}
