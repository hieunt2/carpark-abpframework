using abp.carpark.Dto;
using abp.carpark.Helper;
using abp.carpark.Interfaces;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abp.carpark.Services
{
    public class CarParkService : carparkAppService, ICarParkService
    {
        private readonly HttpHelper<CarParkAvailabilityDto> httpHelper;
        public CarParkService()
        {
            httpHelper = new HttpHelper<CarParkAvailabilityDto>();
        }

        [Authorize]
        public async Task<List<CarParkData>> GetCarParkAvailabilities()
            => (await httpHelper.SendGetRequestAsync($"{CarPark.Constansts.CarParkAvailabilityAPI}?date_time={DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss")}")).Items.FirstOrDefault()?.CarParkData.Take(20).ToList();
    }
}
