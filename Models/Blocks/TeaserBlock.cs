using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;

namespace AlloyTraining.Models.Blocks
{
    [ContentType(DisplayName = "Teaser", GUID = "a6c10e9c-68b0-495f-8b53-2fe0f7ae774a",
        Description = "Use this for rich text with heading, image and page link that will be reused in multiple places",
        GroupName = SiteGroupNames.Common)]
    [SiteBlockIcon]
    public class TeaserBlock : BlockData
    {
        [CultureSpecific]
        [Display(Name = "Heading", Order = 10)]
        public virtual string TeaserHeading { get; set; }

        [CultureSpecific]
        [Display(Name = "Rich text", Order = 20)]
        public virtual XhtmlString TeaserText { get; set; }

        [Display(Name = "Image", Order = 30)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference TeaserImage { get; set; }

        [Display(Name = "Link", GroupName = SystemTabNames.PageHeader, Order = 40)]
        public virtual PageReference TeaserLink { get; set; }
    }
}