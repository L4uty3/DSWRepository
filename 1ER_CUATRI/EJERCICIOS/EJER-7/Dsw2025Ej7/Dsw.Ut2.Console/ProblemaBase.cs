using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dsw.Ut2.Library;

namespace Dsw.Ut2
{
    public abstract class ProblemaBase: IEvaluador
    {
        public void MostrarError(string mensaje)
        {
            Debug.WriteLine(mensaje, "DSW2025");
        }
    }
}
