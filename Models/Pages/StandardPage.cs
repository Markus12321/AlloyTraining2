using System;
using System.ComponentModel.DataAnnotations;
using AlloyTraining.Models.Blocks;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace AlloyTraining.Models.Pages
{
    [ContentType(DisplayName = "Standard", GUID = "e7de5c9b-dd13-445a-8082-37e802c8bddc",
        GroupName = SiteGroupNames.Common,
        Description = "Use this page type unless you need a more specialized one")]
    [SitePageIcon]
    [AvailableContentTypes(Include = new[] { typeof(StandardPage) },
        Exclude = new[] { typeof(ProductPage) })]
    public class StandardPage : SitePageData
    {
        [CultureSpecific]
        [Display(
            Name = "Main body",
            Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
            GroupName = SystemTabNames.Content,
            Order = 310)]
        public virtual XhtmlString MainBody { get; set; }

        public virtual EmployeeBlock Author { get; set; }
    }
}