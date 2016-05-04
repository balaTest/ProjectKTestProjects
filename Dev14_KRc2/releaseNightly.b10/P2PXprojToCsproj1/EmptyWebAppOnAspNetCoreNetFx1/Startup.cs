using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace EmptyWebAppOnAspNetCoreNetFx1
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app)
        {
            ClassLibraryOnNetFx1.Class1 c1 = new ClassLibraryOnNetFx1.Class1();
            PortableClassLibrary1.Class1 c2 = new PortableClassLibrary1.Class1();
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync($"Hello World! {c1.GetHello()} {c2.GetHello()} ");
            });
        }
    }
}
