using Models;
using Models.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using Utils.Types;

namespace Services.Abstract
{
    public interface ICosmeticService : ICosmeticService<CosmeticModel>
    {
        List<CosmeticModel> GetByType(CosmeticType Type);
    }
}
