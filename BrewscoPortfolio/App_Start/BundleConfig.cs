using System.Web;
using System.Web.Optimization;

namespace BrewscoPortfolio
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
                      "~/vendor/bootstrap/js/bootstrap.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/js").Include(
                "~/vendor/jquery/jquery-3.2.1.min.js",
                "~/vendor/animsition/js/animsition.min.js",
                "~/vendor/bootstrap/js/popper.js",
                "~/vendor/bootstrap/js/bootstrap.min.js",
                "~/vendor/select2/select2.min.js",
                "~/vendor/daterangepicker/moment.min.js",
                "~/vendor/daterangepicker/daterangepicker.js",
                "~/vendor/slick/slick.min.js",
                "~/js/slick-custom.js",
                "~/vendor/parallax100/parallax100.js",
                "~/vendor/MagnificPopup/jquery.magnific-popup.min.js",
                "~/vendor/isotope/isotope.pkgd.min.js",
                "~/vendor/sweetalert/sweetalert.min.js",
                "~/vendor/perfect-scrollbar/perfect-scrollbar.min.js",
                "~/js/main.js",
                "~/js/map-custom.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/design-css").Include(
                "~/vendor/bootstrap/css/bootstrap.min.css",
                "~/fonts/font-awesome-4.7.0/css/font-awesome.min.css",
                "~/fonts/iconic/css/material-design-iconic-font.min.css",
                "~/fonts/linearicons-v1.0.0/icon-font.min.css",
                "~/vendor/animate/animate.css",
                "~/vendor/css-hamburgers/hamburgers.min.css",
                "~/vendor/animsition/css/animsition.min.css",
                "~/vendor/select2/select2.min.css",
                "~/vendor/daterangepicker/daterangepicker.css",
                "~/vendor/slick/slick.css",
                "~/vendor/MagnificPopup/magnific-popup.css",
                "~/vendor/perfect-scrollbar/perfect-scrollbar.css",
                "~/css/util.css",
                "~/css/main.css"));
        }
    }
}
