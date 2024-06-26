﻿using AspProjekat2024.Application.DTO;
using AspProjekat2024.Application.DTO.Searches;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspProjekat2024.Application.UseCases.Queries
{
    public interface IGetBrandsQuery : IQuery<BaseSearch, IEnumerable<BrandDto>>
    {
    }
}
