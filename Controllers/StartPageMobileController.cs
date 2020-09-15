using System.Web.Mvc;
using AlloyTraining.Models.Pages;
using EPiServer;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Framework.Web;

namespace AlloyTraining.Controllers
{
    [TemplateDescriptor(Tags = new[] { RenderingTags.Mobile },
        AvailableWithoutTag = false)]
    public class StartPageMobileController : PageControllerBase<StartPage>
    {
        public StartPageMobileController(IContentLoader loader) : base(loader)
        {
        }

        public ActionResult Index(StartPage currentPage)
        {
            /* Implementation of action. You can create your own view model class that you pass to the view or
             * you can pass the page type for simpler templates */

            return View(CreatePageViewModel(currentPage));
        }
    }
}