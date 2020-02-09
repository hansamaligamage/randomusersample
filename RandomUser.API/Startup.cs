using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using RandomUser.Data;
using RandomUser.Data.Entities;
using RandomUser.Data.Persistence;
using RandomUser.Data.Repository;
using RandomUser.Data.Repository.Services;

namespace RandomUser.API
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
            services.AddControllers();
          
            ConfigureDataService(services);
            ConfigureAPIService(services);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/error");
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }

        #region Private Methods

        private void ConfigureDataService(IServiceCollection services)
        {
            services.AddScoped<IRepository<User>, Repository<User>>();
            services.AddScoped<IUserPersistenceService, UserPersistenceService>();
            services.AddDbContext<UserDbContext>(options => options.UseInMemoryDatabase("UserDb").UseLazyLoadingProxies());
        }

        private void ConfigureAPIService(IServiceCollection services)
        {
            services.AddScoped<IUserApiService, UserAPIService>();
            services.AddHttpClient();
        }

        #endregion
    }
}
