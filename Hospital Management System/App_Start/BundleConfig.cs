using System.Web;
using System.Web.Optimization;

namespace HMS
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                "~/Scripts/jquery-{version}.js",
                "~/Scripts/bootbox.js",
                "~/Scripts/DataTables/media/js/jquery.dataTables.js",
                "~/Scripts/Datatables/media/dataTables.bootstrap.js",
                "~/Scripts/toastr.js",

                "~/Scripts/typeahead.bundle.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/admin-lte/js").Include(
                      "~/admin-lte/js/adminlte.js",
                      "~/admin-lte/js/app.js",
                      "~/admin-lte/js/demo.js",
                      //"~/admin-lte/plugins/bootstrap-wysihtml5/bootstrap3-wysihtml5.all.min.js",
                      "~/admin-lte/plugins/jquery-ui.js",
                      "~/admin-lte/plugins/bootstrap-slider.js",
                      "~/admin-lte/plugins/fastclick/fastclick.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      //"~/Content/bootstrap.lumen.min.css",
                      "~/Content/bootstrap.css",
                      "~/Content/dataTables.bootstrap.min.css",
                      "~/Content/font-awesome.css",
                      "~/Content/toastr.css",
                      //"~/Content/DataTables/media/css/dataTables.bootstrap.min.css",
                      "~/admin-lte/css/AdminLTE.css",
                      "~/admin-lte/css/skins/skin-blue.css",
                      //"~/admin-lte/plugins/bootstrap-wysihtml5/bootstrap3-wysihtml5.min.css",
                      //"~/admin-lte/plugins/slider.css",
                      "~/Content/site.css"));
        }
    }
}
