using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentDate
{
    public interface IDateQantifier
    {
        bool Before(DateTime dateTime);
        bool After(DateTime dateTime);
        bool Ago {get;}
        bool FromNow { get; }
        bool FromToday { get; }
    }
}
