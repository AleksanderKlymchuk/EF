using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public interface IGenericRepository<ReadModel,CommandModel>
    {
        ReadModel Get(int Id);

        void Add(CommandModel obj);

        void AddRange(IEnumerable<ReadModel> objects);

        void Remove(ReadModel obj);

        void RemoveRange(IEnumerable<ReadModel> objects);
    }
}
