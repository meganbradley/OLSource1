---
title: "Debug Your App Built with Visual Studio Tools for Apache Cordova"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - tgt-pltfrm-cross-plat
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: c2a4a1d4-a4e8-47ec-811f-ad207c54f4d1
caps.latest.revision: 35
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Debug Your App Built with Visual Studio Tools for Apache Cordova
[!INCLUDE[cordova_disclaimer](../vs140/includes/cordova_disclaimer_md.md)]  
  
 Visual Studio brings a seamless and common tooling experience for developing Cordova apps across app types and device platforms. However, in this early release, not all device platforms support all Visual Studio debugger and diagnostic capabilities, as shown in the following table.  
  
|Device or operating system|Visual Studio debugger supported?|Console messages supported?|Workaround|  
|--------------------------------|---------------------------------------|---------------------------------|----------------|  
|Android 4.4 or later|Yes|Yes|-|  
|Android versions 2.3.3 to 4.3|No (see [information about jsHybugger](#DbgAndroid) later in this article)|Yes|-|  
|iOS 6, 7, 8|Yes|Yes|-|  
|8.1(Store), Windows Phone 8.1,   Windows 10|Yes|Yes|-|  
|Windows Phone 8|No|No (use the Console plugin)|Use Web Inspector Remote (weinre) or the Console plugin. See [Debug Windows 8 and Windows Phone 8](#DbgWindows) later in this article.|  
  
> [!NOTE]
>  If you are using Windows 7, you can develop apps for Android and iOS, but not for Windows or Windows Phone. To run the app on Windows Server 2012 R2, you must enable the **Desktop Experience** option.  
  
 In this article:  
  
-   [Debug Android and iOS in Apache Ripple](#DbgRipple)  
  
-   [Debug Android on the emulator or a device](#DbgAndroid)  
  
-   [Debug iOS on the emulator or a device](#DbgIOS)  
  
-   [Debug Windows 8 and Windows Phone 8](#DbgWindows)  
  
> [!WARNING]
>  For a video and accompanying tutorial that shows you have to debug using the Visual Studio debugger, DOM Explorer, and the JavaScript Console, see [Video: Debug using Diagnostic Tools](../vs140/video-walkthrough--debug-using-visual-studio-diagnostic-tools-for-cordova.md)  
  
##  <a name="DbgRipple"></a> Debug Android and iOS in Apache Ripple  
 You can attach the Visual Studio debugger to an app that’s running in the Apache Ripple emulator.  
  
#### To debug in Ripple  
  
1.  With your app open in Visual Studio, choose **iOS** or **Android** from the **Solution Platforms** list, and choose one of the deployment targets that specify the Ripple Emulator.  
  
2.  Press F5.  
  
     You can hit breakpoints set in your code, use the DOM Explorer to inspect HTML and CSS, and interact with your page using the JavaScript Console.  
  
     The following illustration shows a breakpoint set in the Code Editor.  
  
     ![Setting a breakpoint while debugging using Ripple](../vs140/media/cordova_debug_breakpoint_set.png "Cordova_Debug_Breakpoint_Set")  
  
     Here, the Visual Studio debugger hits the breakpoint while debugging in the Ripple emulator.  
  
     ![Breakpoint caught by the Visual Studio debugger](../vs140/media/cordova_debug_breakpoint_hit.png "Cordova_Debug_Breakpoint_Hit")  
  
> [!IMPORTANT]
>  The Visual Studio debugger won’t stop at breakpoints that are hit before the first page loads in Ripple. However, the debugger will stop at these breakpoints after you refresh the browser.  
  
 The following cross-platform [JavaScript Console commands](../vs140/javascript-console-commands.md) are currently supported from Ripple:  
  
-   **$**   
     **$$**   
     **$0-$4**   
     **$_**   
     **clear**   
     **console.assert**   
     **console.clear**   
     **console.count**   
     **console.debug**   
     **console.dir**   
     **console.dirxml**   
     **console.error**   
     **console.group**   
     **console.groupCollapsed**   
     **console.groupEnd**   
     **console.info**   
     **console.log**   
     **console.time**   
     **console.timeEnd**   
     **console.warn**   
     **dir**  
  
 The supported set of console commands, and their behavior, is provided by the host browser, not by Visual Studio. For additional commands that may be supported by Ripple, see the browser documentation for Chrome.  
  
> [!TIP]
>  The JavaScript Console in Visual Studio provides IntelliSense information to make easy to identify these commands and other objects on your page.  
  
 The DOM Explorer enables debugging of HTML and CSS. Features available in the **Styles**, **Computed**, and **Layout** tabs of the [DOM Explorer](../vs140/quickstart--debug-html-and-css.md) are supported on Ripple.  
  
> [!NOTE]
>  For detailed information about debugging support, see [Known Issues](http://go.microsoft.com/fwlink/?linkid=398782).  
  
##  <a name="DbgAndroid"></a> Debug Android on the emulator or on a device  
 You can attach the Visual Studio debugger to the Android emulator or to an Android device to debug your app on Android 4.4.  
  
 If you’re using an Android version between 2.3.3 and 4.3, you can install the jsHybugger plugin to enable Android diagnostics (DOM Explorer, console, and debugging). This plugin instruments your code locally to enable remote debugging on Android devices and emulators, and supports Android 2.3.3 and later versions.  
  
#### To debug on Android 4.4  
  
1.  With your project open in Visual Studio, choose **Android** from the **Solution Platforms** list, and choose one of the Android deployment targets.  
  
2.  Press F5.  
  
     If you are using Android 4.4, you can hit breakpoints set in your code, interact with your page using the JavaScript Console, and use the DOM Explorer.  
  
    > [!IMPORTANT]
    >  The Visual Studio debugger won’t stop at breakpoints that are hit before the first page loads in Android 4.4 emulators or in Android devices. However, the debugger will stop at these breakpoints after you execute the following command from the JavaScript Console: **window.location.reload()**  
  
#### To debug on Android versions 2.3.3-4.3 with the jsHybugger plugin  
  
1.  Open your Cordova project in Visual Studio.  
  
2.  In your project, create a **plugins** folder if one doesn’t already exist. (To add a folder, open the shortcut menu for your project in Solution Explorer, choose **Add**, **New Folder**, and then set the folder name to **plugins**.)  
  
3.  [Download the jsHybugger plugin](https://www.jshybugger.com/download?release=Plugin) and extract its contents.  
  
    > [!NOTE]
    >  For more information about this plugin, see the [jsHybugger website](https://www.jshybugger.com/). You can use the plugin without a license, but debugging sessions are limited to two minutes. For unlimited debugging, you must [purchase a jshybugger license](https://www.jshybugger.com/#!/buy). The following instructions assume that you’ve purchased a license and downloaded the license file as jshybugger_license.xml.  
  
4.  Place the unzipped jshybugger-plugin-*x.x.x* folder in your project’s **plugins** folder.  
  
5.  Place the jshybugger_license.xml file in the root of your project.  
  
     Here’s what your project will look like in Solution Explorer.  
  
     ![Project structure after installing jsHybugger](../vs140/media/cordova_debug_jshybugger.png "Cordova_Debug_jsHybugger")  
  
6.  In your project, choose **Android** from the **Solution Platforms** list, and then choose one of the Android deployment targets.  
  
7.  Press F5 to start debugging.  
  
     You can interact with your page using the JavaScript Console, and use the DOM Explorer to inspect HTML and CSS.  
  
> [!IMPORTANT]
>  You must remove the jsHybugger plugin and the license file from your project before you publish your app.  
>   
>  The plugin has no effect when you’re using the Apache Ripple emulator or debugging on Android 4.4 emulators and devices, so there’s no need to remove it when you switch between different Android targets during testing.  
  
 The following cross-platform [JavaScript Console commands](../vs140/javascript-console-commands.md) are currently supported for Android:  
  
-   **$**   
     **$$**   
     **$0-$4**   
     **$_**   
     **clear**   
     **console.assert**   
     **console.clear**   
     **console.count**   
     **console.debug**   
     **console.dir**   
     **console.dirxml**   
     **console.error**   
     **console.group**   
     **console.groupCollapsed**   
     **console.groupEnd**   
     **console.info**   
     **console.log**   
     **console.time**   
     **console.timeEnd**   
     **console.warn**   
     **dir**  
  
 The supported set of console commands, and their behavior, is provided by the host browser, not by Visual Studio. For additional commands that may be supported by Android, see the browser documentation for Chrome for Android.  
  
> [!TIP]
>  The JavaScript Console in Visual Studio provides IntelliSense information to make easy to identify these commands and other objects on your page.  
  
 Features available in the **Styles**, **Computed**, and **Layout** tabs of the [DOM Explorer](../vs140/quickstart--debug-html-and-css.md) are supported on Android.  
  
> [!CAUTION]
>  Other debugging and diagnostic tools available for Windows aren’t currently available for Android. We’ll continue to improve Android debugging support in subsequent releases. For detailed information about debugging support, see [Known Issues](http://go.microsoft.com/fwlink/?linkid=398782).  
  
##  <a name="DbgIOS"></a> Debug iOS on an emulator or a device  
 You can attach the Visual Studio debugger to the iOS Simulator or to an iOS device. iOS 6, 7, and 8 are supported.  
  
> [!NOTE]
>  Currently, attaching the debugger to iOS apps that use the InAppBrowser plugin is not supported. The Azure Mobile Services plugin uses the InAppBrowser plugin and is affected by this limitation.  
  
#### To debug on iOS  
  
1.  Make sure you have [installed the remotebuild agent](https://msdn.microsoft.com/library/dn757054.aspx#ios) on your Mac, started the agent, and configured Visual Studio to connect to the agent.  
  
2.  If you are debugging on an actual device, go to your device and choose **Settings**, **Safari**, **Advanced**, and then enable Web Inspector.  
  
     This allows remote debugging on your device. (This step is not required to debug on the iOS Simulator.)  
  
3.  With your app open in Visual Studio and iOS selected in the **Solution Platforms** list, choose a deployment target.  
  
     To debug for a device connected to the remote agent on your Mac, choose **Remote Device** as your deployment target. For a device connected to your PC, choose **Local Device**.  
  
4.  Press F5.  
  
     You can hit breakpoints set in your code, interact with your page using the JavaScript Console, and use the DOM Explorer to inspect HTML and CSS.  
  
    > [!IMPORTANT]
    >  The Visual Studio debugger won’t stop at breakpoints that are hit before the first page loads in the iOS Simulator or on iOS devices. However, the debugger will stop at these breakpoints after you execute the following command from the JavaScript Console: **window.location.reload()**  
  
 The following cross-platform [JavaScript Console commands](../vs140/javascript-console-commands.md) are currently supported for iOS:  
  
-   **$**   
     **$$**   
     **$0-$4**   
     **$_**   
     **clear**   
     **console.assert**   
     **console.clear**   
     **console.count**   
     **console.debug**   
     **console.dir**   
     **console.dirxml**   
     **console.error**   
     **console.group**   
     **console.groupCollapsed**   
     **console.groupEnd**   
     **console.info**   
     **console.log**   
     **console.time**   
     **console.timeEnd**   
     **console.warn**   
     **dir**  
  
 The supported set of console commands, and their behavior, is provided by the host browser, not by Visual Studio. For additional commands that may be supported by iOS, see the browser documentation for iOS Safari.  
  
> [!TIP]
>  The JavaScript Console in Visual Studio provides IntelliSense information to make easy to identify these commands and other objects on your page.  
  
 Features available in the **Styles**, **Computed**, and **Layout** tabs of the [DOM Explorer](../vs140/quickstart--debug-html-and-css.md) are supported on iOS.  
  
> [!CAUTION]
>  We’ll continue to improve debugging support in subsequent releases. For detailed information about debugging support, see [Known Issues](http://go.microsoft.com/fwlink/?linkid=398782).  
  
##  <a name="DbgWindows"></a> Debug Windows and Windows Phone  
 For Windows 8, Windows 8.1, and Windows Phone 8.1 apps, you can use the same Visual Studio debugging tools that you would use for any Windows Store app built using HTML and JavaScript. For more information, see [Debug Store apps in Visual Studio](http://msdn.microsoft.com/library/windows/apps/hh441472.aspx) in the Windows Dev Center.  
  
 For Windows Phone 8 apps, you cannot attach the Visual Studio debugger. Instead, you can use Web Inspector Remote ([weinre](http://people.apache.org/~pmuellr/weinre/docs/latest/)), which is described in a [Microsoft Open Technologies blog post](http://msopentech.com/blog/2013/05/31/now-on-ie-and-firefox-debug-your-mobile-html5-page-remotely-with-weinre-web-inspector-remote/).  
  
 As an alternative to using weinre for Windows Phone 8 debugging, you can instead add the Console plugin to your app, build your app, and then open the generated native Windows Phone 8 project in Visual Studio. The native project can be found under the platforms\wp8 folder. With the native project open, you can use the Output window to view console output. For more information about accessing the native projects, see [Access a Native Cordova Project](../vs140/access-a-native-cordova-project.md).  
  
> [!CAUTION]
>  Changes you make to the native project will be overwritten when you rebuild the Cordova app.  
  
 ![Download the tools](../vs140/media/cordova_install_download.png "Cordova_Install_Download") [Get the Visual Studio Tools for Apache Cordova](http://aka.ms/mchm38) or [learn more](https://www.visualstudio.com/cordova-vs.aspx)  
  
## See Also  
 [Getting started with Visual Studio Tools for Apache Cordova](../vs140/get-started-with-visual-studio-tools-for-apache-cordova1.md)   
 [FAQ](http://go.microsoft.com/fwlink/?linkid=398476)   
 [Known Issues](http://go.microsoft.com/fwlink/?linkid=398782)