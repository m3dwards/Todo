using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web.Resources;

namespace Web.Handlers
{
    public class HomeHandler
    {

        public Home Get()
        {
            return new Home
            {
                Title = "Hello, OpenRasta! Time to rock!"
            };
        }

        public Home Post(Home model)
        {
            return Get();
        }

    }
}