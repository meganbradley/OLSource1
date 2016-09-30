---
title: "Product Release Essentials"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "deployment, essentials"
  - "installation [Visual Studio SDK], essentials"
ms.assetid: 28370bc8-f3a7-4c5e-9b35-8331cda14ff4
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Product Release Essentials
A pleasant and robust setup experience forms a lasting impression in your users’ minds about your [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] integration product. An unpleasant setup experience also forms a lasting impression, so following best practices in setup development and testing is worth the investment.  
  
## Developing Windows Installer Setup Packages  
 Windows Installer is the recommended installation and configuration service for Windows and for [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] integration products.  
  
> [!NOTE]
>  The [!INCLUDE[vsipsdk](../vs140/includes/vsipsdk_md.md)] documentation on installing [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] integration products builds on Windows Installer concepts, but it does not cover Windows Installer itself. For links to relevant sections of the Windows Installer documentation, refer to the table below.  
  
 In the context of setup, *component* refers to a Windows Installer component. Components contain resources like files and registry entries, and are installed and removed as a unit.  
  
|Task|For more information, see|  
|----------|-------------------------------|  
|Learn more about Windows Installer.|[Windows Installer](http://msdn.microsoft.com/library/aa372866.aspx)|  
|Determine your VSPackage's system requirements.|-   [Detecting System Requirements](../vs140/detecting-system-requirements.md)|  
|Learn how to register a VSPackage in a setup package.|-   [VSPackage Registration](../vs140/vspackage-registration.md)\<br />-   [Post-install Commands](../vs140/commands-that-must-be-run-after-installation.md)|  
|See a sample installation package.|-   IronPython Integration Setup Sample|  
  
## Supporting Side-by-Side Products  
 Side-by-side (sometimes shortened to *SxS*) refers to the ability to have multiple versions of the same product installed, and even running, simultaneously. For [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] integration products, it also refers to the fact that [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] itself supports side-by-side execution.  
  
|Task|For more information, see|  
|----------|-------------------------------|  
|Learn about supporting multiple versions of [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] in your [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] integration product.|-   [Side-By-Side Implementation Strategies](../vs140/choosing-between-shared-and-versioned-vspackages.md)\<br />-   [Component Management &#91;Visual Studio SDK&#93;](../vs140/component-management.md)|  
|Learn about supporting multiple versions of your [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] integration product.|-   [Side-By-Side Implementation Strategies](../vs140/choosing-between-shared-and-versioned-vspackages.md)\<br />-   [Registering File Extensions for Side-By-Side Deployments](../vs140/registering-file-name-extensions-for-side-by-side-deployments.md)\<br />-   [Detecting System Requirements](../vs140/detecting-system-requirements.md)\<br />-   [Post-install Commands](../vs140/commands-that-must-be-run-after-installation.md)|  
  
## Testing Your Visual Studio Integration Product  
 The [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] Integration Test (VSIT) suite is a series of tests that verifies that a VSPackage correctly integrates into [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)]. VSIT does not test a VSPackage’s functionality, but helps ensure that a VSPackage does not adversely affect other [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] functionality. For more information, see [Visual Studio Integration Tests](assetId:///8d741735-7d93-46c2-ab93-01da7a0e016d).