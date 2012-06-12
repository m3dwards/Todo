using System;
using OpenRasta.Configuration;
using Web.Resources;
using Web.Handlers;
using OpenRasta.Codecs.Razor;
//using OpenRasta.Hosting.AspNet;

namespace OpenRastaSample
{
    public class Configuration : IConfigurationSource
    {
        public void Configure()
        {
            using (OpenRastaConfiguration.Manual)
            {
                ResourceSpace.Has.ResourcesOfType<Home>()
                .AtUri("/home")
                .HandledBy<HomeHandler>()
                .RenderedByRazor("/views/Home.cshtml");
            }
        }
    }
}