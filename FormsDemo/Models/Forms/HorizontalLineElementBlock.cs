using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Forms.Core;

namespace FormsDemo.Models.Forms
{
    [ContentType(
        DisplayName = "HorizontalLineElementBlock", 
        GUID = "f8265027-49f1-4d4a-80ea-a1e45132a873", 
        Description = "")]
    public class HorizontalLineElementBlock : ElementBlockBase
    {
        // No properties here. This element type will just show a horizontal line
    }
}