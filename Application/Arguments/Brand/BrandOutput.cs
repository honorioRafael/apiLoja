using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Arguments
{
    public class BrandOutput : BaseOutput<BrandOutput>
    {
        public long Id { get; set; }
        public string Name { get; set; }

        public BrandOutput() { }

        public BrandOutput(string name, long id)
        {
            Name = name;
            Id = id;
        }
    }
}
