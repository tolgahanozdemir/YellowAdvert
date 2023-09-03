using Amazon.Runtime.Internal;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YellowAdvert.Business.Args;
using YellowAdvert.Entities.Models;

namespace YellowAdvert.Cqrs.Query
{
    public class GetAllCategoriesQuery:GetAllCategoriesArgs,IRequest<List<Category>>
    {
    }
}
