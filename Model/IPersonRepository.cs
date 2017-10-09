using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public interface IStudentRepository:IGenericRepository<IStudent,StudentProperties>
    {
        void Update(int studentId, StudentProperties obj);
    }
}
