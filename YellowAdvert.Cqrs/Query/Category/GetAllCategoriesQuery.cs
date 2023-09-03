using MediatR;
using YellowAdvert.Business.Args;
using YellowAdvert.Entities.Models;

namespace YellowAdvert.Cqrs.Query;

public class GetAllCategoriesQuery:GetAllCategoriesArgs,IRequest<List<Category>>
{
}
