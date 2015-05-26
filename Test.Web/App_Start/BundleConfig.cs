using System.Web.Optimization;

namespace Test.Web
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/scripts/service").Include(
                "~/scripts/service.js"
                ));

            bundles.Add(new ScriptBundle("~/scripts/jquery").Include(
                "~/scripts/jquery-2.1.4.min.js"
                ));

            bundles.Add(new ScriptBundle("~/scripts/bootstrap").Include(
                    "~/Scripts/bootstrap.js"
                ));

            bundles.Add(new StyleBundle("~/bootstrap/css").Include(
                "~/Content/bootstrap-theme.min.css",
                "~/Content/bootstrap.minp.css"
                ));
        }
    }
}
