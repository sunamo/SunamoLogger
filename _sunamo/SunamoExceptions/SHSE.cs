using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunamoLogging;
internal class SHSE
{
    internal static string NullToStringOrDefault(object n)
    {
        //return NullToStringOrDefault(n, null);
        return n == null ? " " + Consts.nulled : AllStrings.space + n;
    }
}
