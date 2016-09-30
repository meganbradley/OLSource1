---
title: "How to: Brand a VSPackage (C++)"
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
  - "About dialog box"
  - "VSPackages, splash screens"
  - "VSPackages, branding"
ms.assetid: a1b9213f-8702-4716-8623-cd3705d531fa
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Brand a VSPackage (C++)
To appear in the **Help About** dialog box and the splash screen, VSPackages must implement the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsInstalledProduct*> interface. Doing this provides the following information to [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)]:  
  
-   Name  
  
-   ID, such as serial or version number  
  
-   Information  
  
-   Logo icon  
  
 The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> class takes template parameters for that information. Each template parameter is an ID. The first three are IDs of string resources and the fourth is the resource ID of an icon.  
  
## Example  
 The following class declaration for the VSPackage class is from the [Reference.Package Sample (C++)](../vs140/vssdk-samples.md).  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 To test your VSPackage, see [How To: Test the Help About and Splash Screens](../vs140/how-to--test-the-help-about-and-splash-screens.md).  
  
## See Also  
 [VSPackage Branding](../vs140/vspackage-branding.md)