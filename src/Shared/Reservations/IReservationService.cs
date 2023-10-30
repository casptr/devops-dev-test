﻿using Foodtruck.Shared.Supplements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foodtruck.Shared.Reservations
{
    public interface IReservationService
    {
        Task<IEnumerable<ReservationDto.Index>> GetAllAsync();
    }
}