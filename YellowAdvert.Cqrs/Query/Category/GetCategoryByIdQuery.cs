using MediatR;
using YellowAdvert.Business.Args;
using YellowAdvert.Entities.Models;

namespace YellowAdvert.Cqrs.Query;

public class GetCategoryByIdQuery:GetCategoryByIdArgs,IRequest<Category>
{

}
