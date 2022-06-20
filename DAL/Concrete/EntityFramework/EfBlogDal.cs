using Core.DAL.EntityFramework;
using DAL.Abstract;
using ENT.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DAL.Concrete.EntityFramework
{
    public class EfBlogDal : EfEntityRepositoryBase<Blog,GYTDBContext>, IBlogDal
    {
       
    }
}
