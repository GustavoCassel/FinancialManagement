using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppUI.Exceptions
{
    public sealed class MoreThanOneWorksheetException : Exception
    {
        public MoreThanOneWorksheetException()
            : base("A planilha possui mais que 1 (uma) página!")
        { }
    }
}
