using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies
{
    class VMLocator
    {
        public static MainViewModel MainVM { get; } = new MainViewModel();
        public static LogInViewModel LogInVM { get; } = new LogInViewModel();
    }
}
