using MediatR;
using YellowAdvert.Business.Args;
using YellowAdvert.Entities.Models;

namespace YellowAdvert.Cqrs.Command;

public class CreateCategoryCommand:CreateCategoryArgs,IRequest<Category>
{
}
