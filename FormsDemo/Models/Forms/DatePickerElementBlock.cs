using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Forms.Implementation.Elements.BaseClasses;
using EPiServer.Forms.Implementation.Validation;
using EPiServer.Shell.ObjectEditing;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using EPiServer.Forms.Implementation.Elements;

namespace FormsDemo.Models.Forms
{
    [ContentType(
        GUID = "654095e8-7b8d-4b38-a28a-6f5326a64eef", 
        GroupName = "Basic Elements")]
    public class DatePickerElementBlock : InputElementBlockBase
    {
        [Display(
            Name = "DateFormat",
            GroupName = SystemTabNames.Content,
            Order = 100)]
        [SelectOne(SelectionFactoryType = typeof(DateFormatSelectionFactory))]
        public virtual string DateFormat { get; set; }

        [Ignore]
        public override Type[] ValidatorTypesToBeExcluded
        {
            get
            {
                return new[]
                {
                  typeof (IntegerValidator),
                  typeof (PositiveIntegerValidator),
                  typeof (DateDDMMYYYYValidator),
                  typeof (DateMMDDYYYYValidator),
                  typeof (DateYYYYMMDDValidator),
                  typeof (RegularExpressionValidator),
                  typeof (EmailValidator)
                };
            }
            set
            {
            }
        }

        [ScaffoldColumn(false)]
        public override string PredefinedValue
        {
            get { return base.PredefinedValue; }
            set { base.PredefinedValue = value; }
        }

        public override void SetDefaultValues(ContentType contentType)
        {
            base.SetDefaultValues(contentType);
            DateFormat = new DateFormatSelectionFactory().GetSelections(null).First().Value.ToString();
        }
    }
}