﻿using GraphQL;
using GraphQL.Server;
using GraphQL.Server.Ui.Playground;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProductBacklog.Api.Data.Context;
using ProductBacklog.Api.Data.Repository;
using ProductBacklog.Api.GraphQL;
using ProductBacklog.Api.GraphQL.Messaging;

namespace ProductBacklog.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc()
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            
            services.AddDbContext<ProductBacklogContext>
                (options => options.UseSqlServer(@"Data Source=localhost;Initial Catalog=ProductBacklog;Integrated Security=True"), ServiceLifetime.Singleton);

            services.AddSingleton<IProjectRepository, ProjectRepository>();
            services.AddSingleton<IRequirementRepository, RequirementRepository>();

            services.AddScoped<IDependencyResolver>(s => new FuncDependencyResolver(s.GetRequiredService));
            services.AddScoped<ProductBacklogSchema>();
            services.AddSingleton<ProjectMessageService>();

            services.AddGraphQL(x => { x.ExposeExceptions = true; })
                .AddGraphTypes(ServiceLifetime.Scoped)
                .AddDataLoader()
                .AddWebSockets();

            services.AddCors();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors(builder => builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());

            app.UseWebSockets();
            app.UseGraphQLWebSockets<ProductBacklogSchema>("/graphql");

            app.UseGraphQL<ProductBacklogSchema>();
            app.UseGraphQLPlayground(new GraphQLPlaygroundOptions());
        }
    }
}
