using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FormsDemo.Models.Pages;

namespace FormsDemo.Models.ViewModels
{
    public class FormResultViewModel : PageViewModel<FormResultPage>
    {
        public FormResultViewModel(FormResultPage currentPage) : base(currentPage)
        {
        }

        public IDictionary<string, object> FormData { get; set; }
    }
}