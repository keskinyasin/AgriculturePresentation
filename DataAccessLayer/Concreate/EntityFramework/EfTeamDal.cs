using DataAccessLayer.Abstract;
using DataAccessLayer.Concreate.Repository;
using DataAccessLayer.Contexts;
using EntityLayer.Concrate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concreate.EntityFramework
{
    public class EfTeamDal : GenericRepository<Team>, ITeamDal


    {
        
        private readonly AgricultureContext _context;

        public EfTeamDal(AgricultureContext context):base(context)
        {
            _context = context;
        }
        public Team? Get(Func<Team, bool> predicate)
        {
           
                return _context.Teams?.FirstOrDefault(predicate);
           
        }
    }
}
