using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentDate
{
    public interface IDatePositioner
    {
        IDateQantifier Seconds { get; }
        IDateQantifier Minutes { get; }
        IDateQantifier Hours { get; }
        IDateQantifier Days { get;  }
        IDateQantifier Weeks { get;  }
        IDateQantifier Months { get; }
        IDateQantifier Years { get; }
    }
}
