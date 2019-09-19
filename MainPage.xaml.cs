using System;
using System.Diagnostics;
using System.Web;
using Foundation;
using Xamarin.Forms;

namespace PlaidLinkXamarinForms
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var publickey = "YOUR_PUBLIC_KEY";
            var env = "Sandbox"; //development, production
	    var product = "auth"; //transactions, auth, identity, income, assets, investments, liabilities
            var clientName = "PlaidLinkXamarinForms"

            var url = "https://cdn.plaid.com/link/v2/stable/link.html?isWebview=true&key=" + publickey + "&env=" + env + "&product=" + product + "&selectAccount=true&clientName=" + clientName + "&isMobile=true";

            webView.Source = url;

            webView.Navigating += async (sender, e) =>
            {
                if (e.Url.ToLower().Contains("plaidlink:"))
                {
                    e.Cancel = true;
                }
                else
                {
                    e.Cancel = false;
                }
                var linkScheme = "plaidlink";
                var scheme = new Uri(e.Url);
                var param = HttpUtility.ParseQueryString(e.Url);

                var actionScheme = scheme.Scheme;
                var actionType = scheme.Host;

                if(actionScheme == linkScheme)
                {
                    switch (actionType)
                    {
                        case "connected":
                            Debug.WriteLine("Successfully Connected");
                            break;
                        case "exit":
	 		    Debug.WriteLine("Exit");
                            break;
                        case "event":
                            Debug.WriteLine($"Event name: {param["event_name"]}");
                            break;
                        default:
                            Debug.WriteLine($"Link action detected: {actionType}");
                            break;
                    }
                }
            };
        }
    }
}
