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
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Arguments  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The linker option or options to be passed to the linker.  
  
## Remarks  
 The **/link** option and its linker options must appear after any file names and CL options. A space is required between **/link** and <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. For more information, see [Setting Linker Options](../vs140/setting-linker-options.md).  
  
### To set this compiler option in the Visual Studio development environment  
  
1.  Open the project's **Property Pages** dialog box. For details, see [How to: Open Project Property Pages](../vs140/how-to--open-project-property-pages.md).  
  
2.  Click the **Linker** folder.  
  
3.  Click a linker property page.  
  
4.  Modify one or more properties.  
  
### To set this compiler option programmatically  
  
-   This compiler option cannot be changed programmatically.  
  
## See Also  
 [Compiler Options](../vs140/compiler-options.md)   
 [Setting Compiler Options](../vs140/setting-compiler-options.md)