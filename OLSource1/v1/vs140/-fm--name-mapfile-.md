---
title: "-Fm (Name Mapfile)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/Fm (Name Mapfile)"
f1_keywords: 
  - "/fm"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "-Fm compiler option [C++]"
  - "mapfiles [C++], creating linker"
  - "files [C++], creating map"
  - "Fm compiler option [C++]"
  - "/Fm compiler option [C++]"
ms.assetid: 8154448a-93a7-4546-8e4c-5c44d0aff45d
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -Fm (Name Mapfile)
Tells the linker to produce a mapfile containing a list of segments in the order in which they appear in the corresponding .exe file or DLL.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 By default, the mapfile is given the base name of the corresponding C or C++ source file with a .MAP extension.  
  
 Specifying **/Fm** has the same effect as if you had specified the [/MAP (Generate Mapfile)](../vs140/-map--generate-mapfile-.md) linker option.  
  
 If you specify [/c (Compile Without Linking)](../vs140/-c--compile-without-linking-.md) to suppress linking, **/Fm** has no effect.  
  
 Global symbols in a mapfile usually have one or more leading underscores because the compiler adds a leading underscore to variable names. Many global symbols that appear in the mapfile are used internally by the compiler and the standard libraries.  
  
### To set this compiler option in the Visual Studio development environment  
  
1.  Open the project's **Property Pages** dialog box. For details, see [How to: Open Project Property Pages](../vs140/how-to--open-project-property-pages.md).  
  
2.  Click the **C/C++** folder.  
  
3.  Click the **Command Line** property page.  
  
4.  Type the compiler option in the **Additional Options** box.  
  
### To set this compiler option programmatically  
  
-   See \<xref:Microsoft.VisualStudio.VCProjectEngine.VCCLCompilerTool.AdditionalOptions*>.  
  
## See Also  
 [Output-File (/F) Options](../vs140/output-file---f--options.md)   
 [Compiler Options](../vs140/compiler-options.md)   
 [Setting Compiler Options](../vs140/setting-compiler-options.md)   
 [Specifying the Pathname](../vs140/specifying-the-pathname.md)