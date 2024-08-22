using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;

namespace SampleMVC4App.Models.DataProviders
{
    public class ApplicationDataProvider
    {
        const string LargeDatabaseDataContextKey = "SampleOrderDBConnectionString";
        public static ApplicationDbContext DB
        {
            get
            {
                if (HttpContext.Current.Items[LargeDatabaseDataContextKey] == null)
                    HttpContext.Current.Items[LargeDatabaseDataContextKey] = new ApplicationDbContext();
                return (ApplicationDbContext)HttpContext.Current.Items[LargeDatabaseDataContextKey];
            }
        }
        public static IQueryable<ProductModel> Products { get { return DB.Products; } }
    }
}