using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopper.Order.BusinnesLayer.Abstract
{
    public interface IGenericService<T>
    {
        List<T> TGetList();
        T TGetById(int id);
        void TDelete(int id);
        void TUpdate(T entity);
        void TCreate(T entity);
    }
}
