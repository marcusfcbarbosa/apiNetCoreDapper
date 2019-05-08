using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _2_Domain.StoreContext.Handlers;
using _2_Domain.StoreContext.Repositories;
using _2_Domain.StoreContext.Repositories.Interfaces;
using _2_Domain.StoreContext.Services;
using _2_Domain.StoreContext.Services.Interfaces;
using _3_Infra.Context;
using _3_Infra.Repository;
using _3_Infra.Repository;
using _3_Infra.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace _1_Api
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            RegistrandoDependencias(services);
        }

        public void RegistrandoDependencias(IServiceCollection services){
            
            //AddScoped = verifica se tem algum aberto em meória e usa  
            services.AddScoped<Store_Context,Store_Context>();

            services.AddTransient<IClienteRepository,ClienteRepository>();
            services.AddTransient<IEmailService,EmailService>();

            //Handlers
            services.AddTransient<ClienteHandler,ClienteHandler>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            
            app.UseMvc();
            // app.Run(async (context) =>
            // {
            //     await context.Response.WriteAsync("Hello World!");
            // });
        }
    }
}
