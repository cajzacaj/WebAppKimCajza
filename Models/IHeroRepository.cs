﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Models
{
    public interface IHeroRepository
    {
        IEnumerable<Hero> GetAllPies();

        Hero GetPieById(int pieId);
    }
}
