using Komis.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace Komis
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)  //w tej metodzie rejestruje się usługi 
        {                                                           //framework'u które potrzebujemy i własne usługi
            services.AddTransient<ISamochodRepository, MockSamochodRepository>();
            services.AddMvc();                                      //i tu mamy dostęp do kontenra wstrzykiwania zależności ASP.NET Core
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {          //w tej metodzie konfigurujemy potok żądań i tu dodamy komponenty oprogramowania pośredniego które potrzebujemy w naszym potoku żądań
            app.UseDeveloperExceptionPage();        // dodaje obsł. strony ExceptionPage(błędu)  (używamy podczas pisania apki)  
            app.UseStatusCodePages();               // info o statusie żądania
            app.UseStaticFiles();                   // obsługa plików statycznych, np: obraz, javascript, cs
            app.UseMvcWithDefaultRoute();           // mvc z domyślnym routingiem
        }                                                        
    }
}
