using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nsp1;
namespace Method_overriding_June_120824
{
    internal class temp
    {
                            //ref variable
        public void callShow(classP obj)//objects -->classC,C
        {
            obj.show();// parents show  or child C show() or child D show()
        }
    }
}
