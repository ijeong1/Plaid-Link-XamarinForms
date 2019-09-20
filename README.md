# Plaid-Link-XamarinForms
Plaid Link on Xamarin Forms

![Image description](https://github.com/ijeong1/Plaid-Link-XamarinForms/blob/master/Screen_Shot.png)

@for iOS, you need to add the NSAllowsArbitaryLoads key to YES in NSAppTransportSecurity dictionary in your info.plist file.

```
 <key>NSAppTransportSecurity</key>
 <dict>
      <key>NSAllowsArbitraryLoads</key>
     <true/>
 </dict>
```
@ UIWebview is despecated from iOS 13. So you need to use wkwebview instead of webview.
add the following code to the AssemblyInfo.cs file in the iOS platform project for the application
```
// Opt-in to using WkWebView instead of UIWebView.
[assembly: ExportRenderer(typeof(WebView), typeof(Xamarin.Forms.Platform.iOS.WkWebViewRenderer))]
```
