﻿using FEP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FEP.Core.Interfaces.IData
{
    public interface IHelperData
    {
        List<City> GetCities();
        List<District> GetDistricts();
        List<Ward> GetWards();
    }
}