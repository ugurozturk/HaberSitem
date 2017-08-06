using System.Web;
using System.Web.Optimization;

namespace HaberSitem.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/css/tether.min.css", 
                      "~/Content/css/bootstrap.min.css",
                      "~/Content/css/custom.css",
                      "~/Content/css/responsive-style.css",
                      "~/Content/css/weather-icons.min.css",
                      "~/Content/css/font-awesome.min.css",
                      "~/Content/css/lightbox.min.css",
                      "~/Content/css/loaders.css"
                      ));
            bundles.Add(new ScriptBundle("~/Content/js").Include(
                      "~/Content/js/jquery.min.js",
                      "~/Content/js/tether.min.js",
                      "~/Content/js/bootstrap.min.js",
                      "~/Content/js/core.js",
                      "~/Content/js/lightbox-plus-jquery.min.js"
                      ));
        }
    }
}
