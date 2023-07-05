using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppUI.Exceptions
{
    public sealed class ExcelNotInstalledException : Exception
    {
        public ExcelNotInstalledException()
            : base("O Excel não está instalado devidamente!")
        { }
    }
}
