using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(FileDirBrowserServer.Startup))]

namespace FileDirBrowserServer
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {

        }
    }
}
