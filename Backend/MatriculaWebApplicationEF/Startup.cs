using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MatriculaWebApplicationEF.ApplicationServices;
using MatriculaWebApplicationEF.DataContext;
using MatriculaWebApplicationEF.DomainServices;

namespace MatriculaWebApplicationEF
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<EstudianteDomainService>();
            services.AddScoped<ProfesorDomainService>();
            services.AddScoped<MateriaDomainService>();
            services.AddScoped<CursoDomainService>();
            services.AddScoped<PaisDomainService>();
            services.AddScoped<UsuarioDomainService>();

            services.AddScoped<UsuarioAppService>();
            services.AddScoped<EstudianteAppService>();
            services.AddScoped<ProfesorAppService>();
            services.AddScoped<MateriaAppService>();
            services.AddScoped<CursoAppService>();
            services.AddScoped<PaisAppService>();

            services.AddDbContext<UniversidadDataContext>();
            
            services.AddMvc().AddNewtonsoftJson(option => option.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_3_0);
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors(builder =>
            {
                builder
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader();
            });

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}