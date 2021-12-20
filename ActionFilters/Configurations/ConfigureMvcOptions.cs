using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace ActionFilters.Configurations
{
 
        internal class ConfigureMvcOptions : IConfigureOptions<MvcOptions>
        {
            private readonly IHostingEnvironment _env;
            public ConfigureMvcOptions(IHostingEnvironment env)
            {
                _env = env;
            }

            public void Configure(MvcOptions options)
            {
                if (_env.IsDevelopment())
                {
                    options.SslPort = 44523;
                }
                else
                {
                    options.Filters.Add(new RequireHttpsAttribute());
                }
            }
        }
    }

