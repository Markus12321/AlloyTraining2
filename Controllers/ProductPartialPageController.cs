using System.Web.Mvc;
using AlloyTraining.Models.Pages;
using AlloyTraining.Models.ViewModels;
using EPiServer;
using EPiServer.Web.Mvc;

namespace AlloyTraining.Controllers
{
    public class ProductPartialPageController : PartialContentController<ProductPage>
    {
        public override ActionResult Index(ProductPage currentPage)
        {
            return PartialView(PageViewModel.Create(currentPage));
            //the main difference between view and partial view
            //is that partialView doesn't run the _ViewStart file,
            //thus does not add a layout.
        }
    }
}