---
title: "User Permissions and Visual Studio"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "Visual Studio, user permissions"
  - "user permissions"
  - "administrative privileges"
  - "permissions"
ms.assetid: 70485ed7-6342-41bf-8250-7a6826e21b98
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# User Permissions and Visual Studio
For reasons of security you should run Visual Studio as a normal user whenever possible.  
  
> [!WARNING]
>  You should also make sure not to compile, launch, or debug any Visual Studio solution that does not come from a trusted person or a trusted location.  
  
 You can do nearly everything in the Visual Studio IDE as a normal user, but, you need administrator permissions to complete the following tasks:  
  
|Area|Task|For more information|  
|----------|----------|--------------------------|  
|Installation|Installing Visual Studio.|[Installing Visual Studio](../VS_csharp/installing-visual-studio-2015.md)|  
||Upgrading from a trial edition of Visual Studio.|[How to: Upgrade from a Trial Edition of Visual Studio](../VS_csharp/how-to--upgrade-from-a-trial-edition-of-visual-studio.md)|  
||Installing, updating, or removing local Help content.|[Install and Manage Local Content](../VS_csharp/install-and-manage-local-content.md)|  
|Application types|Developing solutions for SharePoint 2010.|[Requirements for Developing SharePoint Solutions](assetId:///ae8ff69d-4540-4380-ab0b-845f7108e89c)|  
||Acquiring a developer license for [!INCLUDE[win8_appstore_long](../VS_csharp/includes/win8_appstore_long_md.md)].|[Get a developer license (Windows Store apps)](http://go.microsoft.com/fwlink/?LinkID=241313)|  
|Toolbox|Adding classic COM controls to the **Toolbox**.|[Using the Toolbox](../VS_csharp/using-the-toolbox.md)|  
|Add-ins|Installing and using add-ins that were written by using classic COM in the IDE.|[Creating Add-Ins and Wizards](assetId:///c5a47c21-6668-4de3-898d-afa969317e73)|  
|Building|Using post-build events that register a component.|[Understanding Custom Build Steps and Build Events](../VS_csharp/understanding-custom-build-steps-and-build-events.md)|  
||Including a registration step when you build C++ projects.|[Understanding Custom Build Steps and Build Events](../VS_csharp/understanding-custom-build-steps-and-build-events.md)|  
|Debugging|Debugging applications that run with elevated permissions.|[Debug Settings and Preparation](../VS_csharp/debugger-settings-and-preparation.md)|  
||Debugging applications that a run under a different user account, such as ASP.NET websites.|[Debugging ASP.NET and AJAX Applications](../VS_csharp/debugging-asp.net-and-ajax-applications.md)|  
||Debugging in Zone for XAML Browser Applications (XBAP).|[WPF Host (PresentationHost.exe)](assetId:///3215bfa1-722c-4ac8-a7c5-bdd02d30afbd)|  
||Using the emulator to debug cloud service projects for Microsoft Azure.|[Debugging a Cloud Service in Visual Studio](http://go.microsoft.com/fwlink/?LinkId=266725)|  
||Configuring a firewall for remote debugging.|[How to: Set Up Remote Debugging](../Topic/Set%20Up%20the%20Remote%20Tools%20on%20the%20Device.md)|  
|Performance tools|Profiling an application.|[Beginners Guide to Performance Profiling](../VS_csharp/beginners-guide-to-performance-profiling.md)|  
|Deployment|Deploying a web application to Internet Information Services (IIS) on a local computer.|[Deploying an ASP.NET Web Application to a Hosting Provider using Visual Studio or Visual Web Developer: Deploying to IIS as a Test Environment](http://go.microsoft.com/fwlink/?LinkId=266478)|  
|Providing feedback to Microsoft|Changing how you participate in the Visual Studio Customer Experience Program.|[How to: Send Feedback about Visual Studio](../Topic/How%20to:%20Send%20Feedback%20About%20Visual%20Studio.md)|  
  
## Running Visual Studio as an Administrator  
 You can launch Visual Studio with administrative permissions each time you start the IDE, or you can modify the application shortcut to always run with administrative permissions. For more information, see Windows Help.  
  
#### To run Visual Studio with administrative permissions on [!INCLUDE[win8](../VS_csharp/includes/win8_md.md)], [!INCLUDE[win81](../VS_csharp/includes/win81_md.md)], [!INCLUDE[winserver8](../VS_csharp/includes/winserver8_md.md)], or [!INCLUDE[winblue_server_2](../VS_csharp/includes/winblue_server_2_md.md)]  
  
1.  On the **Start** screen, type **Visual Studio**. You should see the version or versions of Visual Studio you have installed.  
  
2.  Select the version of Visual Studio you want to start, and then bring up the shortcut menu (it appears at the bottom of the screen). Choose **Run as administrator**.  
  
     When Visual Studio starts, **(Administrator)** appears after the product name in the title bar.  
  
#### To run Visual Studio with administrative permissions on [!INCLUDE[win7](../VS_csharp/includes/win7_md.md)] or [!INCLUDE[winsvr08_r2](../VS_csharp/includes/winsvr08_r2_md.md)]  
  
1.  On the **Start** menu, choose **All Programs**.  
  
2.  In the **Microsoft Visual Studio** *Version* folder select  **Visual Studio** *Version* open the shortcut menu, and then choose **Run as administrator**.  
  
     When Visual Studio starts, **(Administrator)** appears after the product name in the title bar.  
  
## See Also  
 [Visual Studio 2013 Compatibility](../VS_csharp/porting--migrating--and-upgrading-visual-studio-projects.md)   
 [Installing Visual Studio](../VS_csharp/installing-visual-studio-2015.md)