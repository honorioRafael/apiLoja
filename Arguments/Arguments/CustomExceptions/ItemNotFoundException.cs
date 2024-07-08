using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arguments.Arguments
{
    public class ItemNotFoundException : Exception
    {
        public ItemNotFoundException(string message = "Não foi localizado nenhum item com esse ID.") : base(message)
        { }
    }
}
