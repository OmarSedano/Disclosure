using System.Web.Optimization;

namespace Disclosure.App_Start
{
    public static class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {

            bundles.Add(
                new ScriptBundle("~/bundles/angular").Include(
                    "~/Resources/Scripts/frameworks/angular.min.js",
                    "~/Resources/Scripts/frameworks/angular-ui-router.min.js",
                    "~/Resources/Scripts/frameworks/angular-local-storage.js"
                    ));

            bundles.Add(
                new ScriptBundle("~/bundles/disclosureApp").Include(
                        "~/App/disclosureApp.js",
                        "~/App/controllers/*.js",
                        "~/App/services/*.js"));
            

        }
    }
}