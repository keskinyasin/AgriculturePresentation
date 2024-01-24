using BussinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Concrete
{
    public class TeamManager : ITeamService
    {
        private readonly ITeamDal _teamDal;

        public TeamManager(ITeamDal teamDal)
        {
            _teamDal = teamDal;
        }

        public void Insert(Team entity)
        {
            _teamDal.Insert(entity);
        }

        public void Delete(Team entity)
        {
            _teamDal.Delete(entity);
        }

        public void Update(Team entity)
        {
            _teamDal.Update(entity);
        }

        public Team Get(int id)
        {
            return _teamDal.Get(x => x.TeamID == id);
        }

        public List<Team> GetAll()
        {
            return _teamDal.GetAll();

        }
    }
}

