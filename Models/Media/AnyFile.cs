using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace AlloyTraining.Models.Media
{
    [ContentType(DisplayName = "Any File",
        GUID = "455819f6-a426-4d08-9778-db31d61d21d9",
        Description = "Use this to upload any type of file")]
    public class AnyFile : MediaData
    {
    }
}