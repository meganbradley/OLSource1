---
title: "Run Your Apache Cordova App on Windows"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "tgt-pltfrm-cross-plat"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: df61ac45-f0fb-4c4c-bbb4-ad596357e3ff
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Run Your Apache Cordova App on Windows
[!INCLUDE[cordova_header](../vs140/includes/cordova_header_md.md)]  
  
 Visual Studio provides these three options for deploying an app built using Visual Studio Tools for Apache Cordova on Windows:  
  
-   Local machine, to run the app on your PC.  
  
-   Simulator, to run your app on the Windows Simulator.  
  
-   Remote machine, to run your app on a remote device. To use this option, follow [these instructions](http://msdn.microsoft.com/library/windows/apps/hh441469.aspx) from the Windows Dev Center to install and use Visual Studio Remote Tools.  
  
 Windows 8, Windows 8.1, or Windows Server 2012 R2 (with Desktop Experience enabled) is required to deploy and run your app on Windows.  
  
 You can configure your Windows app to target either Windows 8 or Windows 8.1 using the configuration designer. For more information, see [Configure your App](../vs140/configure-your-app-built-with-visual-studio-tools-for-apache-cordova.md).  
  
## Run your app on the local machine or simulator  
 Follow these instructions to run your app on your computer or on the Windows Simulator.  
  
#### To run your app  
  
1.  With your app open in Visual Studio, choose a Windows platform such as **Windows-x64** from the **Solution Platforms** list. If you don’t see this list, choose **Solution Platforms** from the **Add/Remove Buttons** list to display it.  
  
2.  In the deployment target list, choose **Local Machine** or **Simulator**.  
  
3.  Press F5 to start the app, or Shift+F5 to start the app without attaching the debugger.  
  
     Visual Studio runs the app on your computer or in the Windows Simulator, as shown here.  
  
     ![Running an app on the Windows Simulator](../vs140/media/cordova_windows_simulator.png "Cordova_Windows_Simulator")  
  
 ![Download the tools](../vs140/media/cordova_install_download.png "Cordova_Install_Download") [Get the Visual Studio Tools for Apache Cordova](http://aka.ms/mchm38) or [learn more](https://www.visualstudio.com/cordova-vs.aspx)  
  
## See Also  
 [Install the Visual Studio Tools for Apache Cordova Extension](../vs140/install-visual-studio-tools-for-apache-cordova.md)   
 [Debug Your App Built with Visual Studio Tools for Apache Cordova](../vs140/debug-your-app-built-with-visual-studio-tools-for-apache-cordova.md)   
 [Package Your App Built with Visual Studio Tools for Apache Cordova](../vs140/package-your-app-built-with-visual-studio-tools-for-apache-cordova.md)