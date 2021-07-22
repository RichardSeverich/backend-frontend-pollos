using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using PollosAPIREST.Security;
using PollosAPIREST.Settings;
using PollosApplication.Src.UseCases;
using PollosApplication.Src.UseCases.UseCaseCrud;
using PollosCore.Src.Repositories.RepositoryCrud;
using PollosCore.Src.Repositories;
using PollosDatabase.Src.Repositories;
using PollosDatabase.Src.Repositories.RepositoryCrud;
using System.Text;
using PollosCore.Src.Repositories.RepositoryPagination;
using PollosDatabase.Src.Repositories.RepositoryPagination;
using PollosApplication.Src.UseCases.UseCasePagination;
using PollosCore.Src.Repositories.RepositoryPaginationSorting;
using PollosDatabase.Src.Repositories.RepositoryPaginationSorting;
using PollosApplication.Src.UseCases.UseCasePaginationSorting;
using PollosDatabase.Src.Repositories.RepositoryFilter;
using PollosCore.Src.Repositories.RepositoryFilter;
using PollosApplication.Src.UseCases.UseCaseFilter;
using PollosCore.Src.Repositories.RepositoryFilterLike;
using PollosDatabase.Src.Repositories.RepositoryFilterLike;
using PollosApplication.Src.UseCases.UseCaseFilterLike;
using PollosApplication.Src.UseCases.UseCaseFilterSorting;
using PollosCore.Src.Repositories.RepositoryFilterPagSorting;
using PollosDatabase.Src.Repositories.RepositoryFilterLikePagSorting;

namespace PollosAPIREST
{
    public class Startup
    {
        private readonly string _cors = "saleCors";
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //Cors
            services.AddCors(options => 
            {
                options.AddPolicy(name: _cors, 
                    builder => 
                    {
                        builder.WithOrigins("*");
                    });
            });

            //Use Case Login
            services.AddSingleton<IRepositoryLogin, RepositoryLogin>();
            services.AddSingleton<UseCaseLogin>();

            //Use Case Crud
            services.AddSingleton<IRepositoryUser, RepositoryUser>();
            services.AddSingleton<UseCaseCrudUser>();

            services.AddSingleton<IRepositoryClient, RepositoryClient>();
            services.AddSingleton<UseCaseCrudClient>();

            services.AddSingleton<IRepositoryProduct, RepositoryProduct>();
            services.AddSingleton<UseCaseCrudProduct>();

            //Use Case Pagination
            services.AddSingleton<IRepositoryPaginationUser, RepositoryPaginationUser>();
            services.AddSingleton<UseCasePaginationUser>();

            services.AddSingleton<IRepositoryPaginationClient, RepositoryPaginationClient>();
            services.AddSingleton<UseCasePaginationClient>();

            services.AddSingleton<IRepositoryPaginationProduct, RepositoryPaginationProduct>();
            services.AddSingleton<UseCasePaginationProduct>();

            //Use Case Pagination Sorting
            services.AddSingleton<IRepositoryPaginationSortingUser, RepositoryPaginationSortingUser>();
            services.AddSingleton<UseCasePaginationSortingUser>();

            services.AddSingleton<IRepositoryPaginationSortingClient, RepositoryPaginationSortingClient>();
            services.AddSingleton<UseCasePaginationSortingClient>();

            services.AddSingleton<IRepositoryPaginationSortingProduct, RepositoryPaginationSortingProduct>();
            services.AddSingleton<UseCasePaginationSortingProduct>();

            //Use Case Filter
            services.AddSingleton<IRepositoryFilterUser, RepositoryFilterUser>();
            services.AddSingleton<UseCaseFilterUser>();

            services.AddSingleton<IRepositoryFilterClient, RepositoryFilterClient>();
            services.AddSingleton<UseCaseFilterClient>();

            services.AddSingleton<IRepositoryFilterProduct, RepositoryFilterProduct>();
            services.AddSingleton<UseCaseFilterProduct>();

            //Use Case Filter Like
            services.AddSingleton<IRepositoryFilterLikeUser, RepositoryFilterLikeUser>();
            services.AddSingleton<UseCaseFilterLikeUser>();

            services.AddSingleton<IRepositoryFilterLikeClient, RepositoryFilterLikeClient>();
            services.AddSingleton<UseCaseFilterLikeClient>();

            services.AddSingleton<IRepositoryFilterLikeProduct, RepositoryFilterLikeProduct>();
            services.AddSingleton<UseCaseFilterLikeProduct>();

            //Use Case Filter Sorting Like
            services.AddSingleton<IRepositoryFilterLikePagSortingUser, RepositoryFilterLikePagSortingUser>();
            services.AddSingleton<UseCaseFilterLikePagSortingUser>();

            services.AddSingleton<IRepositoryFilterLikePagSortingClient, RepositoryFilterLikePagSortingClient>();
            services.AddSingleton<UseCaseFilterLikePagSortingClient>();

            services.AddSingleton<IRepositoryFilterLikePagSortingProduct, RepositoryFilterLikePagSortingProduct>();
            services.AddSingleton<UseCaseFilterLikePagSortingProduct>();

            services.AddControllers();

            var appSettingsSection = Configuration.GetSection("AppSettings");
            services.Configure<AppSettings>(appSettingsSection);

            //JWT
            var appSettings = appSettingsSection.Get<AppSettings>();
            var key = Encoding.ASCII.GetBytes(appSettings.Secret);
            services.AddAuthentication(d => 
            {
                d.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                d.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
                .AddJwtBearer(d=>
                {
                    d.RequireHttpsMetadata = false;
                    d.SaveToken = true;
                    d.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(key),
                        ValidateIssuer = false,
                        ValidateAudience = false,
                    };
                });

            services.AddScoped<SecurityJWToken>();

            //Swagger
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "PollosAPIREST", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "PollosAPIREST v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors(_cors);

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
