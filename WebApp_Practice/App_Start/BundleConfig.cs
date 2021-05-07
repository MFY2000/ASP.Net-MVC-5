using System.Web;
using System.Web.Optimization;

namespace WebApp_Practice
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/popper.min.js",
                      "~/Scripts/popper.js",
                      "~/Scripts/custom.js",
                      "~/Scripts/bootstrap.bundle.min.js",
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/*.css",
                      "~/Content/jquery-ui.css",
                      "~/Content/bootstrap.css",
                      "~/Content/jquery.mCustomScrollbar.min.css",
                      "~/Content/meanmenu.css",
                      "~/Content/nice-select.css",
                      "~/Content/normalize.css",
                      "~/Content/owl.carousel.min.css",
                      "~/Content/slick.css",
                      "~/Content/style.css",
                      "~/Content/site.css"));
        }
    }
}
