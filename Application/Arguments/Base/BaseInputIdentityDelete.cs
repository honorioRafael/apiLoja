using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Arguments
{
    public abstract class BaseInputIdentityDelete<TInpuIdentityDelete> where TInpuIdentityDelete : BaseInputIdentityDelete<TInpuIdentityDelete>
    {
        protected long Id { get; set; }

        public BaseInputIdentityDelete(long id)
        {
            Id = id;
        }
    }
}
