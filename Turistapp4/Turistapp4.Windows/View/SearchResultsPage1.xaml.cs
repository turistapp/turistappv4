using System.Linq;
using Windows.UI.Xaml;
using System;
using System.Collections.Generic;
using Windows.UI.Xaml.Navigation;
using Turistapp4.Common;

namespace Search
{
    public sealed partial class SearchResultsPage
    {
        private readonly NavigationHelper _navigationHelper;
        public NavigationHelper NavigationHelper { get { return _navigationHelper; } }
        public List<DataItem> Results { get; set; }
        public string QueryText { get; set; }

        public SearchResultsPage()
        {
            InitializeComponent();
            _navigationHelper = new NavigationHelper(this);
            _navigationHelper.LoadState += navigationHelper_LoadState;
        }

        private void navigationHelper_LoadState(object sender, LoadStateEventArgs e)
        {
            QueryText = e.NavigationParameter as String;
            Results = new List<DataItem>();
            var matchingItems = Data.Type.Where(item => item.Title.Contains(QueryText));
            Results.AddRange(matchingItems);
            VisualStateManager.GoToState(this, Results.Count > 0 ? "ResultsFound" : "NoResultsFound", true);
        }

        #region NavigationHelper registration
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            _navigationHelper.OnNavigatedTo(e);
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            _navigationHelper.OnNavigatedFrom(e);
        }

        #endregion

        private void pageTitle_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }
    }

}

namespace Search
{
    public static class Data
    {
        public static IEnumerable<DataItem> Type = new List<DataItem>
        {
            new DataItem(){Description = "Musik og larm",Title = "Koncerter",UniqueId = "%123"},
            new DataItem(){Description = "Hard ROCK HALLELUJA",Title = "Lordi",UniqueId = "%556"},
            new DataItem(){Description = "Kedeligt",Title = "Kirke",UniqueId = "%768"},
            new DataItem(){Description = "Menneskeligt",Title = "Damer",UniqueId = "%4892"},
        };
    }

    public class DataItem
    {
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Description { get; set; }
        public string UniqueId { get; set; }
    }
}