using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ClassLibraryOnNetFx1
{
    public class Class1
    {
        public string GetHello()
        {
            return JsonConvert.SerializeObject("Hello from ClassLibraryOnNetFx1, using Newtonsoft.Json package");
        }
    }
}
