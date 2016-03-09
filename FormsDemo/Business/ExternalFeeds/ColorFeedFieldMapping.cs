using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EPiServer.Forms.Core.ExternalFeed;
using EPiServer.Forms.Core.ExtraFieldMapping;

namespace FormsDemo.Business.ExternalFeeds
{
    public class ColorFeedFieldMapping : IExternalSystemFieldMapping
    {
        public Guid Guid
        {
            get { return Guid.Parse("107FF759-53C3-48CD-9A96-0CE0C1B82235"); }
        }

        public string Code { get { return "Code"; } }

        public IFeed FeedForMapping
        {
            get { return new ColorFeed(); }
        }
    }
}