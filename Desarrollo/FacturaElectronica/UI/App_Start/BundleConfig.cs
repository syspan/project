using System.Web;
using System.Web.Optimization;

namespace Syspan.Admin
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            //bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
            //            "~/Scripts/jquery-{version}.js"));

            //bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
            //            "~/Scripts/jquery.validate*"));

            //// Use the development version of Modernizr to develop with and learn from. Then, when you're
            //// ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            //bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
            //            "~/Scripts/modernizr-*"));

            //bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
            //          "~/Scripts/bootstrap.js",
            //          "~/Scripts/respond.js"));



            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
            "~/Scripts/jquery.validate*"));



            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/assets/css/main.css",
                      "~/Content/assets/css/skins.css"));

            bundles.Add(new StyleBundle("~/Content/css/framework").Include(
                "~/Content/assets/plugins/bootstrap/css/bootstrap.min.css",
                "~/Content/assets/plugins/font-awesome/css/font-awesome.min.css"));

            bundles.Add(new StyleBundle("~/Content/css/plugin").Include(
              "~/Content/assets/plugins/pace/pace-theme-minimal.css",
              "~/Content/assets/plugins/jquery-gritter/css/jquery.gritter.css",
              "~/Content/assets/plugins/bootstrap-datetimepicker/css/bootstrap-datetimepicker.min.css",
               "~/Content/assets/plugins/jquery-jvectormap/jquery-jvectormap-1.2.2.css"
              ));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
            "~/Content/assets/plugins/jquery-2.1.0.min.js",
            "~/Content/assets/plugins/bootstrap/js/bootstrap.min.js"));
            
           bundles.Add(new ScriptBundle("~/bundles/js/plugin").Include(
            "~/Content/assets/plugins/pace/pace.min.js",
            "~/Content/plugins/jquery-totemticker/jquery.totemticker.min.js",
            "~/Content/assets/plugins/jquery-resize/jquery.ba-resize.min.js",
             "~/Content/assets/plugins/jquery-blockui/jquery.blockUI.min.js",
            "~/Content/assets/plugins/jquery-gritter/js/jquery.gritter.min.js",
            "~/Content/assets/plugins/jquery-sparkline/jquery.sparkline.min.js"
            ));

            bundles.Add(new ScriptBundle("~/bundles/js/plugin").Include(
            "~/Content/assets/plugins/jquery-flot/excanvas.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/modalform").Include(
            "~/Scripts/modalform.js"));

            //<!-- BEGIN JS PLUGIN -->
            //<script src="assets/plugins/pace/pace.min.js"></script>
            //<script src="assets/plugins/jquery-totemticker/jquery.totemticker.min.js"></script>
            //<script src="assets/plugins/jquery-resize/jquery.ba-resize.min.js"></script>
            //<script src="assets/plugins/jquery-blockui/jquery.blockUI.min.js"></script>
            //<script src="assets/plugins/jquery-gritter/js/jquery.gritter.min.js"></script>
            //<script src="assets/plugins/jquery-sparkline/jquery.sparkline.min.js"></script>
            //<!--[if lte IE 8]>
            //    <script language="javascript" type="text/javascript" src="assets/plugins/jquery-flot/excanvas.min.js"></script>
            //<![endif]-->
            //<script src="assets/plugins/jquery-flot/jquery.flot.min.js"></script>
            //<script src="assets/plugins/jquery-flot/jquery.flot.labels.min.js"></script>
            //<script src="assets/plugins/jquery-flot/jquery.flot.resize.min.js"></script>
            //<script src="assets/plugins/jquery-flot/jquery.flot.orderBars.min.js"></script>
            //<script src="assets/plugins/jquery-flot/jquery.flot.pie.min.js"></script>
            //<script src="assets/plugins/jquery-flot/curvedLines.js"></script>
            //<script src="assets/plugins/skycons/skycons.js"></script>
            //<script src="assets/plugins/bootstrap-datetimepicker/js/bootstrap-datetimepicker.min.js"></script>
            //<script src="assets/plugins/jquery-jvectormap/jquery-jvectormap-1.2.2.min.js"></script>
            //<script src="assets/plugins/jquery-jvectormap/jquery-jvectormap-us-aea-en.js"></script>
            //<script src="assets/js/dashboard.js"></script>
            //<!-- END JS PLUGIN -->

            //<!-- BEGIN JS TEMPLATE -->
            //<script src="assets/js/main.js"></script>
            //<script src="assets/js/skin-selector.js"></script>
       
        }
    }
}
