using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EPiServer.Framework.Localization;
using EPiServer.Shell.ObjectEditing;

namespace FormsDemo.Models.Forms
{
    public class DateFormatSelectionFactory : ISelectionFactory
    {
        public IEnumerable<ISelectItem> GetSelections(ExtendedMetadata metadata)
        {
            var items = new List<ISelectItem>
            {
                new SelectItem() {Value = "d-m-yy", Text = "Short (d-m-yyyy)"},
                new SelectItem() {Value = "d-M-yy", Text = "Default (d-M-yyyy)"},
                new SelectItem() {Value = "DD, d MM yy", Text = "Long (DD, d MM yyyy)"}
            };

            return items;
        }
    }
}