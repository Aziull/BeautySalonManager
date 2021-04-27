using System;
using System.Collections.Generic;
using System.Text;
using Utils.Types;

namespace Entities.Abstract
{
    public interface ICosmeticEntity
    {
        int Id { get; set; }
        DateTime ExpirationDate { get; set; }
        double Price { get; set; }
        int Count { get; set; }
        int Volume { get; set; }
        CosmeticType CosmeticType { get; set; }
    }
}
