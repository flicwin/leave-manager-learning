using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace leave_manager.App_Code
{
    public static class Global
    {
        static string _siteLayout;

        public static string SiteLayout
        {
            get
            {
                return _siteLayout;
            }
            set
            {
                _siteLayout = value;
            }
        }
    }
}
