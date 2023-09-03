using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YellowAdvert.Business.Args.Generic
{
    public abstract class CreateArgs<T>
    {
        public abstract T New();
    }
}
