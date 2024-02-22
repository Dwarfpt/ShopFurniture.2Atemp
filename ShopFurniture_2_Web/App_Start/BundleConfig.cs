
using System.Web.Optimization;


namespace ShopFurniture_2_Web
{
    public static class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            // Home style +
            bundles.Add(new StyleBundle("~/bundles/bootstrap/css").Include(
                      "~/PackFurni/Css/bootstrap.min.css", new CssRewriteUrlTransform()));

            // tiny-slider +
            bundles.Add(new StyleBundle("~/bundles/tiny-slider/css").Include(
                      "~/PackFurni/Css/tiny-slider.css", new CssRewriteUrlTransform()));

            // PackFurni/Css/style +
            bundles.Add(new StyleBundle("~/bundles/style/css").Include(
                      "~/PackFurni/Css/style.css", new CssRewriteUrlTransform()));


            // js/bootstrap.bundle.min.js +
            bundles.Add(new ScriptBundle("~/bundles/bootstrap_bundle/js").Include(
                       "~/PackFurni/Js/bootstrap.bundle.min.js"));

            // js/tiny-slider.js +
            bundles.Add(new ScriptBundle("~/bundles/tiny-slider/js").Include(
                      "~/PackFurni/Js/tiny-slider.js"));

            // js/custom.js + 
            bundles.Add(new ScriptBundle("~/bundles/custom/js").Include(
                      "~/PackFurni/Js/custom.js"));


        }
    }
}