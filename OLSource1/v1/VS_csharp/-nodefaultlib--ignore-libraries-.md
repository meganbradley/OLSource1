---
title: "-NODEFAULTLIB (Ignore Libraries)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/NODEFAULTLIB (Ignore Libraries)"
f1_keywords: 
  - "VC.Project.VCLinkerTool.IgnoreAllDefaultLibraries"
  - "VC.Project.VCLinkerTool.IgnoreDefaultLibraryNames"
  - "/nodefaultlib"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "default libraries, removing"
  - "-NODEFAULTLIB linker option"
  - "libraries, ignore"
  - "NODEFAULTLIB linker option"
  - "/NODEFAULTLIB linker option"
  - "ignore libraries linker option"
ms.assetid: 7270b673-6711-468e-97a7-c2925ac2be6e
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -NODEFAULTLIB (Ignore Libraries)
```  
/NODEFAULTLIB[:library]   
```  
  
## Remarks  
 where:  
  
 *library*  
 A library that you want the linker to ignore when it resolves external references.  
  
## Remarks  
 The /NODEFAULTLIB option tells the linker to remove one or more default libraries from the list of libraries it searches when resolving external references.  
  
 To create an .obj file that does not contain references to default libraries, use [/Zl (Omit Default Library Name)](../VS_csharp/-zl--omit-default-library-name-.md).  
  
 By default, /NODEFAULTLIB removes all default libraries from the list of libraries it searches when resolving external references. The optional *library* parameter lets you remove a specified library or libraries from the list of libraries it searches when resolving external references. Specify one /NODEFAULTLIB option for each library you want to exclude.  
  
 The linker resolves references to external definitions by searching first in libraries that you explicitly specify, then in default libraries specified with the /DEFAULTLIB option, and then in default libraries named in .obj files.  
  
 /NODEFAULTLIB:*library* overrides [/DEFAULTLIB:](../VS_csharp/-defaultlib--specify-default-library-.md)*library* when the same *library* name is specified in both.  
  
 If you use /NODEFAULTLIB, for example, to build your program without the C run-time library, you may have to also use [/ENTRY](../VS_csharp/-entry--entry-point-symbol-.md) to specify the entry point (function) in your program. For more information, see [C Run-Time Libraries](../VS_csharp/crt-library-features.md).  
  
### To set this linker option in the Visual Studio development environment  
  
1.  Open the project's **Property Pages** dialog box. For details, see [Setting Visual C++ Project Properties](../VS_csharp/working-with-project-properties.md).  
  
2.  Click the **Linker** folder.  
  
3.  Click the **Input**property page.  
  
4.  Select the **Ignore All Default Libraries** property or specify a list of the libraries you want to ignore in the **Ignore Specific Library** property. The **Command Line** property page will show the effect of the changes you make to these properties.  
  
### To set this linker option programmatically  
  
-   See <xref:Microsoft.VisualStudio.VCProjectEngine.VCLinkerTool.IgnoreDefaultLibraryNames*> and <xref:Microsoft.VisualStudio.VCProjectEngine.VCLinkerTool.IgnoreAllDefaultLibraries*>.  
  
## See Also  
 [Setting Linker Options](../VS_csharp/setting-linker-options.md)   
 [Linker Options](../VS_csharp/linker-options.md)