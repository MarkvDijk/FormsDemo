using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EPiServer.Forms.Core.ExternalFeed;

namespace FormsDemo.Business.ExternalFeeds
{
    public class ColorFeed : IFeed
    {
        public string EditViewFriendlyTitle { get { return "Friendly title"; } }
        public bool AvailableInEditView { get { return true; } }

        public IEnumerable<IFeedItem> LoadItems()
        {
            var selectItems = new List<IFeedItem>();

            selectItems.Add(new FeedItem { Key = "Blue", Value = "Blue" });
            selectItems.Add(new FeedItem { Key = "Orange", Value = "Orange" });
            selectItems.Add(new FeedItem { Key = "Yellow", Value = "Yellow" });
            selectItems.Add(new FeedItem { Key = "Green", Value = "Green" });
            selectItems.Add(new FeedItem { Key = "Red", Value = "Red" });
            selectItems.Add(new FeedItem { Key = "Pink", Value = "Pink" });

            return selectItems;
        }

        // Required for this to work. Seems to be used to identify the feed on the saved form. 
        // If this changes, your dropdown loses it's possible values.
        public string ID
        {
            get { return "9BC5243C-AC09-4E67-AAAB-78D111F57AF8"; }
            set { }
        }

        public string Description
        {
            get { return "Color data source"; }
            set { }
        }

        public Type ProviderType
        {
            get { return typeof(CustomFeedProvider); }
            set { }
        }

        public string Url { get; set; }
        public string ProviderKey { get; set; }
        public string ProviderSecret { get; set; }
        public string KeyXPath { get; set; }
        public string ValueXPath { get; set; }
        public int CacheTimeout { get; set; }
        public string ExtraConfiguration { get; set; }
        public IFeedProvider AssociatedProvider { get; set; }
    }
}