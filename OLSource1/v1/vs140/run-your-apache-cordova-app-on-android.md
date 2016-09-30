---
title: "Run Your Apache Cordova App on Android"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "tgt-pltfrm-cross-plat"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: a487125b-deb7-4212-a809-dc5ceed6854a
caps.latest.revision: 32
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Run Your Apache Cordova App on Android
[!INCLUDE[cordova_header](../vs140/includes/cordova_header_md.md)]  
  
 There are many options for running your apps built using Visual Studio Tools for Apache Cordova on Android. From Visual Studio, you can run and debug Android apps on the following emulators and devices:  
  
-   [Apache Ripple simulator](../vs140/run-your-apache-cordova-app-on-the-apache-ripple-simulator.md) (discussed in a separate article)  
  
-   [Visual Studio Emulator for Android](#VSAndroid)  
  
-   [Android emulator](#AndEmu)  
  
-   [Genymotion emulator](#GenyMotion)  
  
-   An [Android device](#AndDevice) connected to the machine  
  
 If you run into errors building for Android, see these [tips and workarounds](https://github.com/Microsoft/cordova-docs/tree/master/tips-and-workarounds/android).  
  
##  \<a name="VSAndroid">\</a> Visual Studio Emulator for Android (Hyper-V)  
 Here’s how to run your app on the [Visual Studio Emulator for Android](https://www.visualstudio.com/msft-android-emulator-vs.aspx). For system requirements, see [System Requirements for the Visual Studio Emulator for Android](../vs140/system-requirements-for-the-visual-studio-emulator-for-android.md).  
  
> [!IMPORTANT]
>  The Visual Studio Emulator for Android is only available in Visual Studio 2015.  
  
#### To run your app on the emulator  
  
1.  Make sure that Hyper-V is enabled on your PC. Your PC must meet the [system requirements](../vs140/system-requirements-for-the-visual-studio-emulator-for-android.md) for the Visual Studio Emulator for Android.  
  
    > [!IMPORTANT]
    >  The emulator is not supported in a virtualized environment.  
  
2.  With your app open in Visual Studio, choose **Android** from the **Solution Platforms** list. If you don’t see this list, choose **Solution Platforms** from the **Add/Remove Buttons** list to display it.  
  
3.  Choose one of the emulators, such as **VS Emulator 5” KitKat (4.4) XHDPI Phone**.  
  
4.  Press F5 to start the app.  
  
     Visual Studio starts the emulator and runs the app.  
  
##  \<a name="HAXM">\</a> Configure a high-performance emulator (no Hyper-V)  
 If you have a PC with an Intel processor, you can improve the performance of the Android and Genymotion emulators. To configure a high-performance emulator:  
  
1.  Disable Hyper-V. You can do this from Control Panel or from a command line, as described in the following procedures.  
  
    > [!CAUTION]
    >  Disabling Hyper-V will prevent you from using the Visual Studio Emulator for Android and the Windows Phone emulator. However, you can still deploy to a Windows Phone device while Hyper-V is disabled.  
  
2.  (Android emulator only) Install the high-performance Intel Hardware Accelerated Execution Manager (HAXM) driver, if it isn’t already installed. (More information about the [HAXM driver](https://software.intel.com/android/articles/installation-instructions-for-intel-hardware-accelerated-execution-manager-windows))  
  
3.  Configure the Android emulator to use hardware acceleration.  
  
#### To disable Hyper-V in Control Panel  
  
1.  In the Control Panel, choose **Programs and Features**, and then choose **Turn Windows features on or off**.  
  
2.  Clear the check box for Hyper-V.  
  
     ![Disabling Hyper&#45;V](../vs140/media/cordova_hyperv.png "Cordova_HyperV")  
  
3.  Reboot your PC.  
  
     Now you can install the HAXM driver.  
  
 Alternatively, you can configure Windows to start with Hyper-V automatically enabled or disabled using the command line.  
  
#### To disable Hyper-V using the command line  
  
1.  Open an elevated command prompt (with administrative credentials), and type:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
    > [!WARNING]
    >  The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> commands can prevent your system from booting if not executed correctly; be careful when using these commands.  
  
     If you’re adding this command to a shell script, use the following instead:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
2.  Reboot your PC.  
  
     If you want to re-enable Hyper-V later, use the following command, and then reboot your PC:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 If you’re using the Genymotion emulator, you can skip this procedure. For more information, see [Genymotion emulator](#GenyMotion).  
  
#### To install the high-performance HAXM driver (Android emulator only)  
  
1.  After disabling Hyper-V and rebooting, open the [Android SDK Manager](http://developer.android.com/tools/help/sdk-manager.html). To do this from a command line, go to the location of the SDK and type <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
     On Windows, the Android SDK Manager.exe is installed in the following location: C:\Program Files (x86)\Android\android-sdk.  
  
2.  In the Android SDK Manager, look under **Extras** for the Intel x86 Emulator Accelerator (HAXM Installer). If the status column shows that it isn’t installed, select its check box, and then choose **Install Packages**.  
  
     ![Installing the HAXM driver](../vs140/media/cordova_haxm_driver.png "Cordova_HAXM_Driver")  
  
3.  Install the driver by going to *sdk-path*\extras\intel\Hardware_Accelerated_Execution_Manager and running **intelhaxm.exe**.  
  
    > [!TIP]
    >  If the "intel" portion of the path isn’t present, the driver was not installed.  
  
     Now you can configure an emulator to use the driver. When you create or edit an emulator, you must use an Intel CPU and select the **Use Host GPU** option. For more information, see the next section.  
  
##  \<a name="AndEmu">\</a> Android emulator  
 Before you run your app on the Android emulator in Visual Studio, use the Android Virtual Device (AVD) Manager to create an emulator configuration, and then start the emulator from the AVD Manager. The following steps show how to do this. For more information, see the [AVD Manager documentation](http://developer.android.com/tools/devices/managing-avds.html).  
  
#### To create an instance of the emulator  
  
1.  Open the AVD Manager. To do this from a command line, go the location of the SDK and type <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
     On Windows, the AVD Manager.exe is installed in the following location: C:\Program Files (x86)\Android\android-sdk.  
  
2.  In the AVD Manager, choose **Create**.  
  
3.  Configure the properties for the new emulator.  
  
     The required properties are **AVD Name**, **Device**, **Target**, **CPU/ABI**, and **Skin**. **Target** represents an installed version of the Android SDK version (API set). Set this property to **API Level 19**.  
  
    > [!TIP]
    >  If you want to emulate other Android device versions, you can install the images using the Android SDK Manager.  
  
     ![Creating an Android emulator](../vs140/media/cordova_avdman.png "Cordova_AVDMan")  
  
4.  If you installed the high-performance HAXM driver in the  [previous section](#HAXM) and chose an Intel CPU, select the **Use Host GPU** check box in **Emulation Options**.  
  
    > [!IMPORTANT]
    >  To use the high-performance emulator, you must also choose an Intel processor in the **CPU/ABI** section of the AVD dialog box.  
  
5.  Choose **OK** to close the configuration dialog box, and then choose **OK** again in the dialog box that shows all the emulator settings.  
  
6.  In the AVD Manager, select the new emulator, and then choose **Start**.  
  
#### To run the app on the emulator  
  
1.  With your app open in Visual Studio, choose **Android** from the **Solution Platforms** list. (If you don’t see this option, first choose **Solution Platforms** from the **Add/Remove Buttons** list.)  
  
2.  In the device list, choose **Android Emulator**.  
  
     ![Deploying to the Android emulator](../vs140/media/cordova_android_emu.png "Cordova_Android_Emu")  
  
3.  Press F5 to start the app, or Shift+F5 to start the app without debugging.  
  
     Android 4.4 is required to attach the debugger. Otherwise, the app will run without debugging.  
  
    > [!TIP]
    >  -   If you get an error that indicates you need to install a new version of the Android SDK, use the Android SDK Manager to install it. On Windows, you can open SDK Manager by typing the following command on a command line: <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
    > -   Visual Studio deploys the app to the Android emulator that is currently running. If no emulator is running, Visual Studio starts the last emulator that was created using the AVD Manager, and then deploys the app.  
    > -   If you want to debug your app against Android versions 4.1.2-4.3, see the information about the jsHybugger plugin in the article [Debug Your App Built with Visual Studio Tools for Apache Cordova](../vs140/debug-your-app-built-with-visual-studio-tools-for-apache-cordova.md).  
  
##  \<a name="GenyMotion">\</a> Genymotion emulator  
 The [Genymotion emulator](http://www.genymotion.com/) is a popular alternative to the Android emulator that is included with the Android SDK. Here are a few tips for getting started with the emulator:  
  
-   If you have trouble starting the emulator from a remote connection, try starting it locally, and then reconnect remotely if needed. The emulator requires OpenGL for rendering, and this may result in a conflict when starting the emulator.  
  
-   You need a video card and video card drivers that support OpenGL. You may receive messages that indicate this. (If you connect to your PC remotely, you may also see this message. Try again after connecting locally.)  
  
-   You may receive a message to check your VirtualBox network configuration when you try to start the emulator. Follow the link and instructions to modify or remove the "Host-only Network Adapter" from VirtualBox. (VirtualBox is included with the installation of the emulator.)  
  
-   For high-performance emulation using Genymotion, disable Hyper-V before starting the emulator, as described earlier in [Configure a high-performance emulator](#HAXM).  
  
 Android developer tools see Genymotion as a physical device. When you use Visual Studio to run the app, you instruct Visual Studio to deploy to an Android device.  
  
#### To run your app on the Genymotion emulator  
  
1.  Start the Genymotion emulator.  
  
2.  With your app open in Visual Studio, choose **Android** from the **Solution Platforms** list. If you don’t see this option, choose **Solution Platforms** from the **Add/Remove Buttons** list.  
  
3.  In the device list, choose **Device**.  
  
     ![Deploying to an Android device](../vs140/media/cordova_android_device.png "Cordova_Android_Device")  
  
4.  Press F5 to start the app, or Shift+F5 to start the app without debugging.  
  
##  \<a name="AndDevice">\</a> Android devices  
 Before you can use Visual Studio to run your app on a connected Android device, you must install the required driver:  
  
-   [Device-specific OEM driver](http://developer.android.com/tools/extras/oem-usb.html), or  
  
-   For Google Nexus devices, [Google USB driver](http://developer.android.com/sdk/win-usb.html#top)  
  
 You must also make sure that your device is in developer mode. For instructions, see “Enabling On-device Developer Options” and “Setting up a Device for Development” in the [Using Hardware Devices](http://developer.android.com/tools/device.html) page on the Android website.  
  
 To deploy a Release or Distribution configuration of your app, you must sign your app first. For more information, see [Package your App](https://github.com/Microsoft/cordova-docs/tree/master/tutorial-package-publish#android).  
  
#### To run your app on an Android device  
  
1.  Make sure that you have installed the required OEM or Google USB driver.  
  
2.  Make sure that your Android device is in developer mode (see [Using Hardware Devices](http://developer.android.com/tools/device.html) on the Android website).  
  
3.  Make sure that adb (Android Debug Bridge) sees the device using adb.exe.  
  
    1.  Open a VisualStudio developer prompt in admin mode.  
  
    2.  Type the following command:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
         You should see your device in the list as shown here.  
  
         ![Viewing your device using the Android Debug Bridge](../vs140/media/cordova_android_adb.png "Cordova_Android_ADB")  
  
4.  With your app open in Visual Studio, choose **Android** from the **Solution Platforms** list. (If you don’t see this option, choose **Solution Platforms** from the **Add/Remove Buttons** list.)  
  
5.  In the device list, choose **Device**.  
  
     ![Deploying to an Android device](../vs140/media/cordova_android_device.png "Cordova_Android_Device")  
  
6.  Press F5 to start the app, or Shift+F5 to start the app without debugging.  
  
7.  When prompted, choose **Allow USB Debugging**.  
  
 ![Download the tools](../vs140/media/cordova_install_download.png "Cordova_Install_Download") [Get the Visual Studio Tools for Apache Cordova](http://aka.ms/mchm38) or [learn more](https://www.visualstudio.com/cordova-vs.aspx)  
  
## See Also  
 [Install the Visual Studio Tools for Apache Cordova Extension](../vs140/install-visual-studio-tools-for-apache-cordova.md)   
 [Debug Your App Built with Visual Studio Tools for Apache Cordova](../vs140/debug-your-app-built-with-visual-studio-tools-for-apache-cordova.md)   
 [Package Your App Built with Visual Studio Tools for Apache Cordova](../vs140/package-your-app-built-with-visual-studio-tools-for-apache-cordova.md)   
 [FAQ](http://go.microsoft.com/fwlink/?LinkId=398476)