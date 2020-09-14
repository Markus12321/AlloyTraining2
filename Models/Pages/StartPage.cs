using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;
using AlloyTraining.Models.Media;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace AlloyTraining.Models.Pages
{
    [ContentType(DisplayName = "StartPage", GUID = "2cb36957-9837-4fca-b76a-0cd089c34fe8",
        GroupName = SiteGroupNames.Specialized, Order = 10,
        Description = "The home page for a website with an area for blocks and partial pages.")]
    [SiteStartIcon]
    public class StartPage : SitePageData
    {
        [CultureSpecific]
        [Display(Name = "Main content area",
            Description = "Drag and drop images, blocks, folders, and pages with partial templates.",
            GroupName = SystemTabNames.Content,
            Order = 30)]
        [AllowedTypes(typeof(StandardPage), typeof(BlockData),
            typeof(ImageData), typeof(ContentFolder), typeof(PdfFile))]
        public virtual ContentArea MainContentArea { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Heading",
            Description = "If the Heading is not set, the page falls back to showing the Name.",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        public virtual string Heading { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Main body",
            Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
            GroupName = SystemTabNames.Content,
            Order = 20)]
        public virtual XhtmlString MainBody { get; set; }

        [CultureSpecific]
        [Display(Name = "Footer text",
            Description = "The footer text will be shown at the bottom of every page.",
            GroupName = SiteTabNames.SiteSettings,
            Order = 10)]
        public virtual string FooterText { get; set; }
    }
}