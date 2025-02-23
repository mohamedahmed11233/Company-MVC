using LinkDev.Company.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkDev.Company.BLL.Services.Interfaces
{
    public interface IGeneracRepositor<T>where T : BaseModel
    {
        IEnumerable<T> GetAll();
        T Get(int id);
        int Add(T Tentity);
        int Delete(T Tentity);
        int Update(T TEntity);
    }
}
