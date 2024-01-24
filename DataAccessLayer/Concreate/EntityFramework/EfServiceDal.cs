using DataAccessLayer.Abstract;
using DataAccessLayer.Concreate.Repository;
using DataAccessLayer.Contexts;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concreate.EntityFramework
{
    public class EfServiceDal : GenericRepository<Service>, IServiceDal
    {
        public EfServiceDal(AgricultureContext context) : base(context)
        {
        }
        public Service Get(Func<object, bool> value)
        {
            throw new NotImplementedException();
        }
    }
    

}
