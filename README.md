# Plaid Link Xamarin Forms
Plaid Link on Xamarin Forms - Updated for iOS 13.5 and also works with 13.6

![Image description](https://github.com/ijeong1/Plaid-Link-XamarinForms/blob/master/Screen_Shot.png)

@for iOS, you need to add the NSAllowsArbitaryLoads key to YES in NSAppTransportSecurity dictionary in your info.plist file.

```
 <key>NSAppTransportSecurity</key>
 <dict>
      <key>NSAllowsArbitraryLoads</key>
     <true/>
 </dict>
```
@ UIWebview is despecated from iOS 13.
If you try to publish to the App Store, it will be failed with the following email.

ITMS-90809: Deprecated API Usage - New apps that use UIWebView are no longer accepted. Instead, use WKWebView for improved security and reliability. Learn more (https://developer.apple.com/documentation/uikit/uiwebview).

to solve this problem,
![Image description](https://github.com/ijeong1/Plaid-Link-XamarinForms/blob/master/BuildOption.png)
Change your build option. change your build option for your Xamarin Forms project by referring to the figure above.
