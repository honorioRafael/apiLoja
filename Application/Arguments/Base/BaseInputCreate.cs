using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Arguments
{
    public abstract class BaseInputCreate<TInputCreate> where TInputCreate : BaseInputCreate<TInputCreate>
    {
    }
}
