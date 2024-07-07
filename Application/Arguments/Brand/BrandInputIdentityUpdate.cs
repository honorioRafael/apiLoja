using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Arguments
{
    public class BrandInputIdentityUpdate : BaseInputIdentityUpdate<BrandInputUpdate>
    {
        public BrandInputIdentityUpdate(long id, BrandInputUpdate inputUpdate) : base(id, inputUpdate)
        { }
    }
}
