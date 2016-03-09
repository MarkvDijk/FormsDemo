using System;
using System.Linq;
using EPiServer.Forms.Core.Events;
using EPiServer.Framework;
using EPiServer.Framework.Initialization;

namespace FormsDemo.Business.Initialization
{
    [InitializableModule]
    [ModuleDependency(typeof(EPiServer.Web.InitializationModule))]
    public class FormEventsInitialization : IInitializableModule
    {
        public void Initialize(InitializationEngine context)
        {
            FormsEvents.Instance.FormsSubmitting += OnFormsSubmitting;
            FormsEvents.Instance.FormsStepSubmitted += OnFormsStepSubmitted;
            FormsEvents.Instance.FormsSubmissionFinalized += OnFormSubmissionFinalized;
            FormsEvents.Instance.FormsStructureChange += OnFormsStructureChange;
        }

        private void OnFormsSubmitting(object sender, FormsEventArgs e)
        {
            var args = e as FormsSubmittingEventArgs;

        }

        private void OnFormsStepSubmitted(object sender, FormsEventArgs e)
        {
            var args = e as FormsSubmittedEventArgs;
        }

        private void OnFormSubmissionFinalized(object sender, FormsEventArgs e)
        {
            var args = e as FormsSubmittedEventArgs;
        }

        private void OnFormsStructureChange(object sender, FormsEventArgs e)
        {
            
        }

        public void Uninitialize(InitializationEngine context)
        {
            //Add uninitialization logic
        }
    }
}