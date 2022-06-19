using BLL.Abstract;
using DAL.Abstract;
using ENT.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Concrete
{
    public class RankManager : IRankService
    {
        IRankDal _rankDal;

        public RankManager(IRankDal rankDal)
        {
            _rankDal = rankDal;
        }

        public List<Rank> GetAll()
        {
            return _rankDal.GetAll();
        }
    }
}
