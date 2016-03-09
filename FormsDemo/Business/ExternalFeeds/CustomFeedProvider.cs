using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EPiServer.Forms.Core.ExternalFeed;

namespace FormsDemo.Business.ExternalFeeds
{
    public class CustomFeedProvider : IFeedProvider
    {
        public IEnumerable<IFeedItem> LoadItems(IFeed feedToLoad)
        {
            return feedToLoad.LoadItems();
        }
    }
}