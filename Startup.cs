using Microsoft.EntityFrameworkCore;
using ProductCatalogAPI.Database;

namespace ProductCatalogAPI
{
    public class Startup
    {
        public IConfiguration Configuration { get; }


        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddDbContext<ProductContext>(opt =>
              opt.UseSqlServer(Configuration.GetConnectionString("urlConnection")));

            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();

            app.UseSwagger();
            app.UseSwaggerUI();
            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.UseRouting();
            app.UseEndpoints(map => { map.MapControllers(); });

        }
    }
}
