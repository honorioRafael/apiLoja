using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;

namespace Application.Arguments
{
    public class BrandOutputHandler : BaseOutputHandler<Brand, BrandOutput>
    {
        public override BrandOutput? ToOutput(Brand? entry)
        {
            return entry == null ? null : new BrandOutput(entry.Id, entry.Name).LoadInternalData(entry.Id, entry.CreationDate, entry.ChangeDate);
        }
    }
}
