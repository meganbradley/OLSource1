---
title: "-Zs (Syntax Check Only)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/Zs (Syntax Check Only)"
f1_keywords: 
  - "/zs"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "-Zs compiler option [C++]"
  - "Syntax Check Only compiler option"
  - "Zs compiler option"
  - "/Zs compiler option [C++]"
ms.assetid: b4b41e6a-3f41-4d09-9cb6-fde5aa2cfecf
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -Zs (Syntax Check Only)
Tells the compiler to check only the syntax of the source files on the command line.  
  
## Syntax  
  
```  
/Zs  
```  
  
## Remarks  
 When using this option, no output files are created, and error messages are written to standard output.  
  
 The **/Zs** option provides a quick way to find and correct syntax errors before you compile and link a source file.  
  
### To set this compiler option in the Visual Studio development environment  
  
1.  Open the project's **Property Pages** dialog box. For details, see [How to: Open Project Property Pages](../vs140/how-to--open-project-property-pages.md).  
  
2.  Click the **C/C++** folder.  
  
3.  Click the **Command Line** property page.  
  
4.  Type the compiler option in the **Additional Options** box.  
  
### To set this compiler option programmatically  
  
-   See <xref:Microsoft.VisualStudio.VCProjectEngine.VCCLCompilerTool.AdditionalOptions*>.  
  
## See Also  
 [Compiler Options](../vs140/compiler-options.md)   
 [Setting Compiler Options](../vs140/setting-compiler-options.md)