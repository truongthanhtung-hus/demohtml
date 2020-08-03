using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Framework.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace EpiserverSite3.Models.Pages
{
    [ContentType(GUID = "EE3BD195-7CB0-4756-AB5F-E5E223CD9820")]
        public class GenericMedia : MediaData
        {
            public virtual string Description { get; set; }
        }

        [ContentType(GUID = "0A89E464-56D4-449F-AEA8-2BF774AB8730")]
        [MediaDescriptor(ExtensionString = "jpg,jpeg,jpe,ico,gif,bmp,png")]
        public class ImageFile : ImageData
        {
            public virtual string Description { get; set; }
            public virtual string Copyright { get; set; }
        }
    [ContentType(DisplayName = "DemoPage", GUID = "3fe3bc8f-9bd6-4b65-b54b-45e4c79b22ad", Description = "")]
    public class DemoPage : PageData
    {

        [CultureSpecific]
        /*[Display(
            Name = "Main body",
            Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
            GroupName = SystemTabNames.Content,
            Order = 1)] */
        public virtual XhtmlString MainBody { get; set; }

        public virtual XhtmlString Img { get; set; }

        public virtual XhtmlString Text { get; set; }

        public virtual XhtmlString Heading { get; set; }

        public virtual XhtmlString Info { get; set; }

    }
}