using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Abstract
{
    public interface ICosmeticService<TModel> where TModel : class
    {
        void Insert(TModel item);
        TModel Get(int id);
        List<TModel> GetAll();
        void Delete(TModel item);
    }
}
