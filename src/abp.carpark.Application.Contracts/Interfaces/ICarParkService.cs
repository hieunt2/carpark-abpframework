using abp.carpark.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace abp.carpark.Interfaces
{
    public interface ICarParkService : IApplicationService
    {
        Task<List<CarParkData>> GetCarParkAvailabilities();
    }
}
