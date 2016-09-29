---
title: "Installing VSPackages With Windows Installer"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "installation [Visual Studio SDK], with Windows Installer"
  - "VSPackages, deploying"
ms.assetid: 41d2c72c-0a97-4fcd-b3aa-33a8d3aa962a
caps.latest.revision: 34
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Installing VSPackages With Windows Installer
Integrating your VSPackage into [!INCLUDE[vsprvs](../VS_csharp/includes/vsprvs_md.md)] requires more than just copying files to a user's computer. Your VSPackage's installer must install the VSPackage and its dependent files, and register and integrate them into [!INCLUDE[vsprvs](../VS_csharp/includes/vsprvs_md.md)]. Your VSPackage can take advantage of integration features such as displaying an icon on the [!INCLUDE[vsprvs](../VS_csharp/includes/vsprvs_md.md)] splash screen and About dialog box.  
  
 Microsoft Windows Installer files are the recommended way to distribute your VSPackages. Easy-to-use Windows Installer packages can run on any Windows operating system supported by [!INCLUDE[vsprvs](../VS_csharp/includes/vsprvs_md.md)]. For more information, see [Windows Installer](assetId:///121be21b-b916-43e2-8f10-8b080516d2a0).  
  
## In This Section  
 [Windows Installer Basics](../VS_csharp/windows-installer-basics.md)  
 Provides an overview of the Windows Installer.  
  
 [VSPackage Setup Scenarios](../VS_csharp/vspackage-setup-scenarios.md)  
 Discusses different ways you can support side-by-side installations of both your VSPackages and [!INCLUDE[vsprvs](../VS_csharp/includes/vsprvs_md.md)].  
  
 [Authoring a Windows Installer Package](../VS_csharp/authoring-a-windows-installer-package.md)  
 Provides an overview of the typical steps installers follow to correctly install and integrate VSPackages into [!INCLUDE[vsprvs](../VS_csharp/includes/vsprvs_md.md)].  
  
 [Detecting System Requirements](../VS_csharp/detecting-system-requirements.md)  
 Describes how an installer can detect [!INCLUDE[vsprvs](../VS_csharp/includes/vsprvs_md.md)] and its components and cancel setup if VSPackage requirements are not met.  
  
 [Component Management](../VS_csharp/component-management.md)  
 Discusses how to develop an installer that will maintain the integrity of previous product versions.  
  
 [Choosing a VSPackage Installation Directory](../VS_csharp/choosing-the-installation-directory-for-a-vspackage.md)  
 Summarizes the options for locating VSPackages.  
  
 [VSPackage Registration](../VS_csharp/vspackage-registration.md)  
 Discusses how VSPackages are registered at installation time and why self-registration is a bad idea.  
  
 [Deploying Managed-Code Project Types](../VS_csharp/deploying-project-types.md)  
 Discusses how to use the new project-type aggregator for managed-code project types.  
  
 [How to: Generate Registry Information for an Installer (C#)](../VS_csharp/how-to--generate-registry-information-for-an-installer.md)  
 Explains how to use RegPkg.exe to generate a registration manifest for a managed VSPackage.  
  
 [Post-install Commands](../VS_csharp/commands-that-must-be-run-after-installation.md)  
 Explains how to run post-installation commands to integrate VSPackages into [!INCLUDE[vsprvs](../VS_csharp/includes/vsprvs_md.md)].  
  
 [Uninstalling Your VSPackage](../VS_csharp/uninstalling-a-vspackage-with-windows-installer.md)  
 Describes the steps your installer must perform when users uninstall your VSPackage.  
  
## Related Sections  
 [Installing VSPackages](../Topic/Installing%20VSPackages.md)  
 Discusses how to build and install VSPackages and how to support users who are running multiple versions of [!INCLUDE[vsprvs](../VS_csharp/includes/vsprvs_md.md)] at the same time.