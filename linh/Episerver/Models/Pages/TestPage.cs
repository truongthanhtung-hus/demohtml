using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using EpiserverSite.Models;
using EpiserverSite.Models.Pages;
using System;
using System.ComponentModel.DataAnnotations;

namespace EpiserverSite.Models.Pages
{
    [SiteContentType(DisplayName = "Test Page", GUID = "0e3d4805-69ae-4e14-942e-e83e094ac71e", Description = "")]
    public class TestPage : StandardPage
    {
        [Display(
            GroupName = SystemTabNames.Content,
            Order = 325)]
        [CultureSpecific]

        public virtual XhtmlString Heading
        {
            get; set;
        }

        public virtual XhtmlString Avatar
        {
            get; set;
        }

        public virtual XhtmlString Information
        {
            get; set;
        }

        public virtual XhtmlString Details1
        {
            get; set;
        }

        public virtual XhtmlString Image1
        {
            get; set;
        }

        public virtual XhtmlString Details2
        {
            get; set;
        }

        public virtual XhtmlString Image2
        {
            get; set;
        }

        public virtual XhtmlString Details3
        {
            get; set;
        }

        public virtual XhtmlString Image3
        {
            get; set;
        }
    }
}