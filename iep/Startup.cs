﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(iep.Startup))]
namespace iep
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
            ConfigureAuth(app);
        }
    }
}
