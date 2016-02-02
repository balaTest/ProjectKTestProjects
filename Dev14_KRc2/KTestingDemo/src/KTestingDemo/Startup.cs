﻿using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpOverrides;

namespace KTestingDemo
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            app.UseIISPlatformHandler();
            app.UseForwardedHeaders(new ForwardedHeadersOptions
            {
                ForwardedHeaders = ForwardedHeaders.All
            });

            app.Run(context =>
            {
                return context.Response.WriteAsync("Hello World!");
            });
        }
    }
}
