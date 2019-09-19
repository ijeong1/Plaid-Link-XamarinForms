# Plaid-Link-XamarinForms
Plaid Link on Xamarin Forms

@for iOS, you need to add the NSAllowsArbitaryLoads key to YES in NSAppTransportSecurity dictionary in your info.plist file.

```
 <key>NSAppTransportSecurity</key>
 <dict>
      <key>NSAllowsArbitraryLoads</key>
     <true/>
 </dict>
```
@Things to do
- UIWebview is Deprecated. Need to update this code to WKWebivew compatible code using custom renderer.
