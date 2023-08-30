using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YellowAdvert.DataAccess.Abstract;
using YellowAdvert.DataAccess.Concrete.EntityFramework;
using YellowAdvert.Entities.Base;

namespace YellowAdvert.Business.DependencyResolver
{
    public static class GenericDependencyResolver
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<ICategoryDal,EfCategoryDal>();
            services.AddScoped<IProductDal,EfProductDal>();
            services.AddScoped<DbContext,YellowAdvertEfContext>();
        }
    }
}
