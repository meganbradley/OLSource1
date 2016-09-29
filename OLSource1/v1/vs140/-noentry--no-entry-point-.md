---
title: "-NOENTRY (No Entry Point)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/NOENTRY (No Entry Point)"
f1_keywords: 
  - "VC.Project.VCLinkerTool.ResourceOnlyDLL"
  - "/noentry"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "entry points [C++], linker specifying"
  - "-NOENTRY linker option"
  - "resource-only DLLs [C++], creating"
  - "NOENTRY linker option"
  - "/NOENTRY linker option [C++]"
  - "DLLs [C++], creating"
ms.assetid: 0214dd41-35ad-43ab-b892-e636e038621a
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -NOENTRY (No Entry Point)
```  
/NOENTRY  
```  
  
## Remarks  
 The /NOENTRY option is required for creating a resource-only DLL that contains no executable code. For more information, see [Creating a Resource-Only DLL](../vs140/creating-a-resource-only-dll.md).  
  
 Use this option to prevent LINK from linking a reference to `_main` into the DLL.  
  
### To set this linker option in the Visual Studio development environment  
  
1.  Open the project's **Property Pages** dialog box. For details, see [Setting Visual C++ Project Properties](../vs140/working-with-project-properties.md).  
  
2.  Select the **Linker** folder.  
  
3.  Select the **Advanced** property page.  
  
4.  Modify the **No Entry Point** property.  
  
### To set this linker option programmatically  
  
1.  See <xref:Microsoft.VisualStudio.VCProjectEngine.VCLinkerTool.ResourceOnlyDLL*>.  
  
## See Also  
 [Creating a Resource-Only DLL](../vs140/creating-a-resource-only-dll.md)   
 [Setting Linker Options](../vs140/setting-linker-options.md)   
 [Linker Options](../vs140/linker-options.md)