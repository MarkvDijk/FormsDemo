using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EPiServer.Forms.Core;
using EPiServer.ServiceLocation;

namespace FormsDemo.Business.Rendering
{
    [ServiceConfiguration(ServiceType = typeof(IViewModeExternalResources))]
    public class FormsViewModeExternalResource : IViewModeExternalResources
    {
        public IEnumerable<Tuple<string, string>> Resources
        {
            get
            {
                var arrRes = new List<Tuple<string, string>>
                {
                    new Tuple<string, string>("script", "/ClientResources/ViewMode/FormsValidators.js"),
                };
                return arrRes;
            }
        }
    }
}