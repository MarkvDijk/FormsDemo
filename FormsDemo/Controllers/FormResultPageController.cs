using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.Forms.Core;
using EPiServer.Forms.Core.Data;
using EPiServer.Forms.Core.Models;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Search.Queries.Lucene;
using EPiServer.ServiceLocation;
using EPiServer.Web.Mvc;
using FormsDemo.Models.Pages;
using FormsDemo.Models.ViewModels;

namespace FormsDemo.Controllers
{
    public class FormResultPageController : PageControllerBase<FormResultPage>
    {
        private readonly IFormDataRepository _formDataRepository;

        public FormResultPageController(IFormDataRepository formDataRepository)
        {
            _formDataRepository = formDataRepository;
        }

        public ActionResult Index(FormResultPage currentPage, Guid __FormGuid)
        {
            var formData = _formDataRepository.GetSubmissionData(new FormIdentity(__FormGuid, currentPage.LanguageID),
                DateTime.MinValue,
                DateTime.MaxValue);

            //Unreliable, another user might have submitted the form at the same time
            //We can never be sure we have the actual submitted data here
            var latest = formData.FirstOrDefault(); 
            
            var model = new FormResultViewModel(currentPage);
            model.FormData = latest.Data;

            return View(model);
        }
    }
}