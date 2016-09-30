---
title: "How to: Force a VSPackage to Load"
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
  - "VSPackages, force loading"
  - "VSPackages, loading"
ms.assetid: 05f4dc3f-3c9a-45ea-96da-986553b5c5f2
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Force a VSPackage to Load
VSPackages are ordinarily loaded only when their accompanying functionality is required to complete a process. Under some circumstances, however, a VSPackage may have to force another VSPackage to be loaded. For example, a lightweight VSPackage might load a larger VSPackage in a programming context that is not available as a CMDUIContext.  
  
 You can use the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsShell.LoadPackage*> method to force a VSPackage to load.  
  
### To force a VSPackage to load  
  
-   Insert this code into the \<xref:Microsoft.VisualStudio.Shell.Package.Initialize*> method of the VSPackage that forces another VSPackage to load:  
  
     [!code[ForceVSPackageLoad#01](../vs140/codesnippet/CSharp/how-to--force-a-vspackage-to-load_1.cs)]  
  
     When the VSPackage is initialized, it will force <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> to load.  
  
## Robust Programming  
 Force loading should not be used for VSPackage communication. Use [Services](../vs140/using-and-providing-services.md) instead.  
  
## See Also  
 [Loading VSPackages](../vs140/managing-vspackages.md)   
 [VSPackages](../vs140/vspackages.md)