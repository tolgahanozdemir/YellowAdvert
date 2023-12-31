﻿using Microsoft.EntityFrameworkCore;
using YellowAdvert.DataAccess.Abstract;
using YellowAdvert.Entities.Models;

namespace YellowAdvert.DataAccess.Concrete.EntityFramework;

public class EfCategoryDal : EfEntityRepositoryBase<Category, YellowAdvertEfContext>, ICategoryDal
{
    public EfCategoryDal(DbContext context) : base(context)
    {
    }
}
