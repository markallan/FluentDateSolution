using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentDate
{
    public interface IDatePositioner
    {
        IDateQantifier Days { get;  }
        IDateQantifier Weeks { get;  }
    }
}
