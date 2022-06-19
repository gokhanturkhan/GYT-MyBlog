using ENT.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ENT.Concrete
{
    public class Rank : IEntity
    {
        public int RankId { get; set; }
        public string RankName { get; set; }
    }
}
