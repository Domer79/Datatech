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

            bundles.Add(new ScriptBundle("~/scripts/jqueryui").Include(
                "~/scripts/jquery-ui-1.11.4.min.js"
                ));

            bundles.Add(new ScriptBundle("~/scripts/bootstrap").Include(
                    "~/Scripts/bootstrap.js"
                ));

            bundles.Add(new StyleBundle("~/bootstrap/css").Include(
                "~/Content/bootstrap-theme.min.css",
                "~/Content/bootstrap.min.css"
                ));

            bundles.Add(new StyleBundle("~/content/jquery/ui").Include(
                "~/Content/themes/base/*.css"
                ));

            #region Темы jQuery-UI

            bundles.Add(new StyleBundle("~/Content/themes/black-tie").Include(
                "~/Content/themes/black-tie/jquery-ui.black-tie.min.css"
                ));

            bundles.Add(new StyleBundle("~/Content/themes/blitzer").Include(
                "~/Content/themes/blitzer/jquery-ui.blitzer.min.css"
                ));

            bundles.Add(new StyleBundle("~/Content/themes/smoothness").Include(
                "~/Content/themes/smoothness/jquery-ui.smoothness.min.css"
                ));

            bundles.Add(new StyleBundle("~/Content/themes/redmond").Include(
                "~/Content/themes/redmond/jquery-ui.redmond.min.css"
                ));

            bundles.Add(new StyleBundle("~/Content/themes/ui-lightness").Include(
                "~/Content/themes/ui-lightness/jquery-ui.ui-lightness.min.css"
                ));

            bundles.Add(new StyleBundle("~/Content/themes/overcast").Include(
                "~/Content/themes/overcast/jquery-ui.overcast.min.css"
                ));

            #endregion

        }
    }
}
