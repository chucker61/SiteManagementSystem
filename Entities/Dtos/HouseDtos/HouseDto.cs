﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos.HouseDtos
{
    public record HouseDto
    {
        public int Num { get; init; }
        public int ApartmentId { get; init; }
    }
}
