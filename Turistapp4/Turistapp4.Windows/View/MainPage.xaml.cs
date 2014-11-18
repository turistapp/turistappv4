using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;
// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238
using Search;
using Turistapp4.ViewModel;
using Turistapp4.Model;

namespace Turistapp4.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private MainViewModel vm;

        public MainPage()
        {
            this.InitializeComponent();
            vm = new MainViewModel();
            DataContext = vm;
            SelectionBox.SelectedIndex = 0;


            Windows.UI.ApplicationSettings.SettingsPane.GetForCurrentView().CommandsRequested +=
                MainPage_CommandsRequested;

        }

        private void MainPage_CommandsRequested(Windows.UI.ApplicationSettings.SettingsPane sender,
            Windows.UI.ApplicationSettings.SettingsPaneCommandsRequestedEventArgs args)
        {
            Windows.UI.ApplicationSettings.SettingsCommand logindcCommand =
                new Windows.UI.ApplicationSettings.SettingsCommand("OpacitySettings", "Opacity", (handler) =>
                {
                    SettingsFlyout1 opacitySettingsFlyout = new SettingsFlyout1();
                    opacitySettingsFlyout.Show();

                });

            args.Request.ApplicationCommands.Add(logindcCommand);

        }


        private void Afslut_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Exit();
        }

        private void SearchBox_QuerySubmitted(SearchBox sender, SearchBoxQuerySubmittedEventArgs args)
        {
            Frame.Navigate(typeof (SearchResultsPage), args.QueryText);
        }

        private readonly string[] _suggestions = {"Beatles", "Skib", "Mad"};
        
        private void SearchBox_SuggestionsRequested(SearchBox sender, SearchBoxSuggestionsRequestedEventArgs args)
        {
            var request = args.Request;
            foreach (var suggestion in _suggestions)
            {
                if (suggestion.StartsWith(args.QueryText, StringComparison.CurrentCultureIgnoreCase))
                {
                    request.SearchSuggestionCollection.AppendQuerySuggestion(suggestion);

                }
            }

        }

        private void opretbruger_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof (SettingsFlyout1));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage2));
          
        }

        private void Selector_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MainViewModel.SelectedKategori = vm.Kategoriviser[SelectionBox.SelectedIndex];
           // SelectedImage.Source = new BitmapImage(new Uri(MainViewModel.SelectedKategori.Billede1));

        }

    
        }  


    
      
    }

