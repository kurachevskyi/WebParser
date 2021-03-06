﻿using Bll.DTO;
using System.Collections.Generic;

namespace Bll.Interfaces
{
    public interface IParserService
    {
        void Parse(string url);
        List<ProductDTO> GetAllProducts();
        ProductDTO GetProduct(int? id);
        void Dispose();
    }
}
