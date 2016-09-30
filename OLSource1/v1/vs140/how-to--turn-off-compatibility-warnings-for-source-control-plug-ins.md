---
title: "How to: Turn Off Compatibility Warnings for Source Control Plug-ins"
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
  - "source control plug-ins, turning off compatibility warnings"
  - "compatibility warnings, turning off"
ms.assetid: ba318e12-921b-4b7a-a8c2-12c712be1dbf
caps.latest.revision: 25
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# How to: Turn Off Compatibility Warnings for Source Control Plug-ins
A user may see several compatibility warnings when employing source control in [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)]. The warnings presented depend on the capabilities of the source control plug-in and can be disabled as detailed here.  
  
### To disable the warning: "To ensure optimal source control integration with Visual Studio…"  
  
-   Set the following registry entry (adding the value if necessary):  
  
     HKEY_CURRENT_USER\Software\Microsoft\VisualStudio\8.0\SourceControl\DontDisplayCheckDotNETCompatible = dword:00000001  
  
     This warning is displayed for all non-[!INCLUDE[vsvss](../vs140/includes/vsvss_md.md)] plug-ins.  
  
### To disable the warning: "The installed source control provider does not support all the capabilities…"  
  
-   Set the following two registry values (adding the values if necessary):  
  
     HKEY_CURRENT_USER\Software\Microsoft\VisualStudio\8.0\SourceControl\WarnedOldMSSCCIProvider = dword:00000000  
  
     HKEY_CURRENT_USER\Software\Microsoft\VisualStudio\8.0\SourceControl\UseOldSCC = dword:00000001  
  
     This warning is displayed if the source control plug-in does not explicitly support reentrancy for multiple projects (that is, if it can check in only one file and project at a time).  
  
     It is best to support reentrancy (<CodeContentPlaceHolder>0\</CodeContentPlaceHolder> capability); doing so will remove this warning. However, if this support is not possible, these registry entries can be set.  
  
## See Also  
 [Capability Flags](../vs140/capability-flags.md)