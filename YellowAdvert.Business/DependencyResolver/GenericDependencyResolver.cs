using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using YellowAdvert.Business.Abstract;
using YellowAdvert.Business.Concrete;
using YellowAdvert.DataAccess.Abstract;
using YellowAdvert.DataAccess.Concrete.EntityFramework;

namespace YellowAdvert.Business.DependencyResolver;

public static class GenericDependencyResolver
{
    public static void ConfigureServices(IServiceCollection services)
    {
        services.AddScoped<ICategoryDal,EfCategoryDal>();
        services.AddScoped<IProductDal,EfProductDal>();
        services.AddScoped<IProductAttributesDal,EfProductAttributesDal>();
        services.AddScoped<DbContext,YellowAdvertEfContext>();

        services.AddScoped<ICategoryService, CategoryService>();
        services.AddScoped<IProductAttributeService, ProductAttributeService>();
        services.AddScoped<IProductService, ProductService>();
    }
}
