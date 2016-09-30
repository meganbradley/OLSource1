---
title: "-LARGEADDRESSAWARE (Handle Large Addresses)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/LARGEADDRESSAWARE (Handle Large Addresses)"
f1_keywords: 
  - "VC.Project.VCLinkerTool.LargeAddressAware"
  - "/largeaddressaware"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "LARGEADDRESSAWARE linker option"
  - "-LARGEADDRESSAWARE linker option"
  - "/LARGEADDRESSAWARE linker option"
ms.assetid: a29756c8-e893-47a9-9750-1f0d25359385
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -LARGEADDRESSAWARE (Handle Large Addresses)
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The /LARGEADDRESSAWARE option tells the linker that the application can handle addresses larger than 2 gigabytes. In the 64-bit compilers, this option is enabled by default. In the 32-bit compilers, /LARGEADDRESSAWARE:NO is enabled if /LARGEADDRESSAWARE is not otherwise specified on the linker line.  
  
 If an application was linked with /LARGEADDRESSAWARE, DUMPBIN [/HEADERS](../vs140/-headers.md) will display information to that effect.  
  
### To set this linker option in the Visual Studio development environment  
  
1.  Open the project's **Property Pages** dialog box. For details, see [Setting Visual C++ Project Properties](../vs140/working-with-project-properties.md).  
  
2.  Click the **Linker** folder.  
  
3.  Click the **System** property page.  
  
4.  Modify the **Enable Large Addresses** property.  
  
### To set this linker option programmatically  
  
-   See \<xref:Microsoft.VisualStudio.VCProjectEngine.VCLinkerTool.LargeAddressAware*>.  
  
## See Also  
 [Setting Linker Options](../vs140/setting-linker-options.md)   
 [Linker Options](../vs140/linker-options.md)