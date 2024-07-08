using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Arguments
{
    public class BaseOutputHandler<TEntry, TOutput> 
        where TOutput : BaseOutput<TOutput>
        where TEntry : BaseEntry<TEntry>
    {
        public virtual TOutput? ToOutput(TEntry? entry)
        {
            throw new NotImplementedException();
        }
    }
}
