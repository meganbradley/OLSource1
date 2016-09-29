---
title: "-link (Pass Options to Linker)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/link (Pass Options to Linker)"
f1_keywords: 
  - "/link"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "/link compiler option [C++]"
  - "pass options to linker"
  - "link compiler option [C++]"
  - "linker [C++], passing options to"
  - "-link compiler option [C++]"
  - "cl.exe compiler [C++], passing options to linker"
ms.assetid: 16902a94-c094-4328-841f-3ac94ca04848
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -link (Pass Options to Linker)
Passes one or more linker options to the linker.  
  
## Syntax  
  
```  
/link linkeroptions  
```  
  
## Arguments  
 `linkeroptions`  
 The linker option or options to be passed to the linker.  
  
## Remarks  
 The **/link** option and its linker options must appear after any file names and CL options. A space is required between **/link** and `linkeroptions`. For more information, see [Setting Linker Options](../VS_csharp/setting-linker-options.md).  
  
### To set this compiler option in the Visual Studio development environment  
  
1.  Open the project's **Property Pages** dialog box. For details, see [How to: Open Project Property Pages](../Topic/How%20to:%20Open%20Project%20Property%20Pages.md).  
  
2.  Click the **Linker** folder.  
  
3.  Click a linker property page.  
  
4.  Modify one or more properties.  
  
### To set this compiler option programmatically  
  
-   This compiler option cannot be changed programmatically.  
  
## See Also  
 [Compiler Options](../VS_csharp/compiler-options.md)   
 [Setting Compiler Options](../VS_csharp/setting-compiler-options.md)