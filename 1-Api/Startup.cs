using System.IO;
using _2_Domain.StoreContext.Handlers;
using _2_Domain.StoreContext.Repositories.Interfaces;
using _2_Domain.StoreContext.Services.Interfaces;
using _3_Infra.Context;
using _3_Infra.Repository;
using _3_Infra.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;
using Elmah.Io.AspNetCore;
using System;
using Microsoft.Extensions.Configuration;
using _4_Shared;

namespace _1_Api
{
    public class Startup
    {
     
        public static IConfiguration Configuration { get;set; }
        public object Direc { get; private set; }

        public void ConfigureServices(IServiceCollection services)
        {

            var builder = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json");
            Configuration = builder.Build();

            ///dai para ter acesso a qualquer chave que esta no json do appSettings
            Settings.ConnectionStrings =Configuration["ConnectionStrings"];

            //Para poder publicar dentro de uma aplicação Azure (olhar depois)
            //services.addApplicationInsightsTelemetry(Configuration)

            services.AddMvc();
            //Habilitando a compressao de dados de todas as requisições
            services.AddResponseCompression();
            RegistrandoDependencias(services);
            //adicionando a documentação dos endpoints
            services.AddSwaggerGen(options =>
            {
                options.DescribeAllEnumsAsStrings();
	            options.DescribeAllParametersInCamelCase();
                options.SwaggerDoc("v1", new Info { Title = "My API", Version = "v1" });
            });
        }

        public void RegistrandoDependencias(IServiceCollection services){
            
            //AddScoped = verifica se tem algum aberto em meória e usa  
            services.AddScoped<Store_Context,Store_Context>();

            services.AddTransient<IClienteRepository,ClienteRepository>();
            services.AddTransient<IEmailService,EmailService>();

            //Handlers
            services.AddTransient<ClienteHandler,ClienteHandler>();
            //Elmah
         
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        [Obsolete]
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            //Swagger
            app.UseSwagger();
            //Swagger em formato json
            app.UseSwaggerUI(c =>
	        {
	        	c.SwaggerEndpoint("/swagger/v1/swagger.json", "My First Swagger");
	        });
            app.UseMvc();
            //Habilitando a compressao de dados de todas as requisições
            app.UseResponseCompression();
            //No momento da publicação ira exibir no elmah
            app.UseElmahIo("APIKEY", new Guid("LOG_ID"));
        }
    }
}
