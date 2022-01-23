using aquarium_calculator.Interface;
using aquarium_calculator.Service;
using Microsoft.OpenApi.Models;

namespace aquarium_calculator
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
        // services.AddDbContext<OTAPPContext>(opts =>opts.UseSqlite(Configuration.GetConnectionString("DefaultConnection")));
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "BackEndOTP", Version = "v1" });
            });
            //services.AddScoped<IUsuarioService, UsuarioService>();
            services.AddScoped<ICalculoLitragemService, CalculoLitragemService>();
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddMvc();
            services.AddCors();
            services.AddControllers();
            services.AddAuthentication();
            services.AddHttpClient();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "BackEndOTP v1"));
            }

            app.UseCors(x => x
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());

            app.UseAuthentication();
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });



            app.UseHttpsRedirection();
            app.UseRouting();
          

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

        
        }
    }
}