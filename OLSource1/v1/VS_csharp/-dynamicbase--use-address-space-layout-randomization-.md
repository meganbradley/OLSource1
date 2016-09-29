---
title: "-DYNAMICBASE (Use address space layout randomization)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/DYNAMICBASE (Use address space layout randomization)"
f1_keywords: 
  - "VC.Project.VCLinkerTool.RandomizedBaseAddress"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "-DYNAMICBASE linker option"
  - "/DYNAMICBASE linker option"
  - "DYNAMICBASE linker option"
ms.assetid: 6c0ced8e-fe9c-4b63-b956-eb8a55fbceb2
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -DYNAMICBASE (Use address space layout randomization)
Specifies whether to generate an executable image that can be randomly rebased at load time by using the address space layout randomization (ASLR) feature of [!INCLUDE[windowsver](../VS_csharp/includes/windowsver_md.md)].  
  
## Syntax  
  
```  
/DYNAMICBASE[:NO]  
```  
  
## Remarks  
 By default, /DYNAMICBASE is on.  
  
 This option modifies the header of an executable to indicate whether the application should be randomly rebased at load time.  
  
 Address space layout randomization is supported on [!INCLUDE[windowsver](../VS_csharp/includes/windowsver_md.md)].  
  
### To set this linker option in Visual Studio  
  
1.  Open the project **Property Pages** dialog box. For more information, see [How to: Open Project Property Pages](../Topic/How%20to:%20Open%20Project%20Property%20Pages.md).  
  
2.  Expand the **Configuration Properties** node.  
  
3.  Expand the **Linker** node.  
  
4.  Select the **Advanced** property page.  
  
5.  Modify the **Randomized Base Address** property.  
  
### To set this linker option programmatically  
  
1.  See <xref:Microsoft.VisualStudio.VCProjectEngine.VCLinkerTool.RandomizedBaseAddress*>.  
  
## See Also  
 [Setting Linker Options](../VS_csharp/setting-linker-options.md)   
 [Linker Options](../VS_csharp/linker-options.md)