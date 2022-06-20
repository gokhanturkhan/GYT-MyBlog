using ENT.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Abstract
{
    public interface IBlogService
    {
        List<Blog> GetAll();
    }
}
