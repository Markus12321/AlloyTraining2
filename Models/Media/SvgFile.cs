using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAnnotations;
using EPiServer.Framework.Blobs;
using EPiServer.Framework.DataAnnotations;

namespace AlloyTraining.Models.Media
{
    [ContentType(DisplayName = "SVG File",
        GUID = "5e521df0-3922-4360-8b19-60246f6a8232",
        Description = "Use this to upload Scalable Vector Graphic (SVG) images.")]
    [MediaDescriptor(ExtensionString = "svg")]
    public class SvgFile : ImageData
    {
        // instead of generating a smaller bitmap file for thumbnail, use the same binary vector
        // image for thumbnail.
        public override Blob Thumbnail => base.BinaryData;
    }
}