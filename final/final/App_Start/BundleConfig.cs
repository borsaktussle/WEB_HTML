using System.Web;
using System.Web.Optimization;

namespace final
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
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/bootstrap.min.js",
                      "~/Scripts/custom.js",
                      "~/Scripts/jquery-1.10.2.intellisense.js",
                      "~/Scripts/jquery-1.10.2.js",
                      "~/Scripts/jquery-1.10.2.min.js",
                      "~/Scripts/jquery-ui.js",
                      "~/Scripts/jquery-ui.min.js",
                      "~/Scripts/jquery.js",
                      "~/Scripts/jquery.validate-vsdoc.js",
                      "~/Scripts/jquery.validate.js",
                      "~/Scripts/jquery.validate.min.js",
                      "~/Scripts/jquery.validate.unobtrusive.js",
                      "~/Scripts/jquery.validate.unobtrusive.min.js",
                      "~/Scripts/login.js",
                      "~/Scripts/modernizr-2.6.2.js",
                      "~/Scripts/npm.js",
                      "~/Scripts/respond.js",
                      "~/Scripts/jquery.paginate.js",
                      "~/Scripts/respond.min.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/bootstrap.min.css",
                      "~/Content/bootstrap-theme.css",
                      "~/Content/bootstrap-theme.min.css",
                      "~/Content/custom.css",
                      "~/Content/jquery-ui.css",
                      "~/Content/jquery-ui.min.css",
                      "~/Content/jquery-ui.structure.css",
                      "~/Content/jquery-ui.structure.min.css",
                      "~/Content/jquery-ui.theme.css",
                      "~/Content/jquery-ui.theme.min.css",
                      "~/Content/style.css",
                      "~/Content/jquery.paginate.css",
                      "~/Content/site.css"));
        }
    }
}
