using Core.ENT;
using System;
using System.Collections.Generic;
using System.Text;

namespace ENT.Concrete
{
    public class Blog : IEntity
    {
        public int BlogId { get; set; }
        public string BlogTitle { get; set; }
        public string BlogSubTitle { get; set; }
        public string BlogText { get; set; }
        public bool BlogStatus { get; set; }
        public DateTime CreateDate { get; set; }
        public int TotalView { get; set; }
        public int CategoryId { get; set; }

    }
}
