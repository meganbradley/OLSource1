---
title: "-PROFILE (Performance Tools Profiler)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/PROFILE (Performance Tools Profiler)"
f1_keywords: 
  - "VC.Project.VCLinkerTool.Profile"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "-PROFILE linker option"
  - "/PROFILE linker option"
ms.assetid: e676baa1-5063-47a3-a357-ba0d1f0d1699
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -PROFILE (Performance Tools Profiler)
Produces an output file that can be used with the Performance Tools profiler.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 /PROFILE implies the following linker options:  
  
-   [/OPT:REF](../vs140/-opt--optimizations-.md)  
  
-   /OPT:NOICF  
  
-   [/INCREMENTAL:NO](../vs140/-incremental--link-incrementally-.md)  
  
-   [/FIXED:NO](../vs140/-fixed--fixed-base-address-.md)  
  
 /PROFILE causes the linker to generate a relocation section in the program image.  A relocation section allows the profiler to transform the program image to get profile data.  
  
 **/PROFILE** is only available only in Enterprise (team development) versions.  For more information on PREfast, see [PREfast Overview](../vs140/code-analysis-for-c-c---overview.md).  
  
### To set this linker option in the Visual Studio development environment  
  
1.  Open the project's **Property Pages** dialog box. For details, see [How to: Open Project Property Pages](../vs140/how-to--open-project-property-pages.md).  
  
2.  Expand the **Configuration Properties** node.  
  
3.  Expand the **Linker** node.  
  
4.  Select the **Advanced** property page.  
  
5.  Modify the **Profile** property.  
  
### To set this linker option programmatically  
  
1.  See \<xref:Microsoft.VisualStudio.VCProjectEngine.VCLinkerTool.Profile*>.  
  
## See Also  
 [Setting Linker Options](../vs140/setting-linker-options.md)   
 [Linker Options](../vs140/linker-options.md)