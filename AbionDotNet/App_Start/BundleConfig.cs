using System.Web;
using System.Web.Optimization;

namespace AbionDotNet
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-1.4.2.min.js",
                        "~/Scripts/cufon-yui.js",
                        "~/Scripts/cufon-libsans-r-b.js",
                        "~/Scripts/script.js",
                        "~/Scripts/coin-slider.min.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/style.css",
                      "~/Content/coin-slider.css"));
        }
    }
}
