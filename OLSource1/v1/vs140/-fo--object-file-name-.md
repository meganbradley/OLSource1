---
title: "-Fo (Object File Name)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/Fo (Object File Name)"
f1_keywords: 
  - "/Fo"
  - "VC.Project.VCCLCompilerTool.ObjectFile"
  - "VC.Project.VCCLWCECompilerTool.ObjectFile"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Fo compiler option [C++]"
  - "object files, naming"
  - "/Fo compiler option [C++]"
  - "-Fo compiler option [C++]"
ms.assetid: 0e6d593e-4e7f-4990-9e6e-92e1dcbcf6e6
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -Fo (Object File Name)
Specifies an object (.obj) file name or directory to be used instead of the default.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 If you do not use this option, the object file uses the base name of the source file and the .obj extension. You can use any name and extension you want, but the recommended convention is to use .obj.  
  
### To set this compiler option in the Visual Studio development environment  
  
1.  Open the project's **Property Pages** dialog box. For details, see [How to: Open Project Property Pages](../vs140/how-to--open-project-property-pages.md).  
  
2.  Click the **C/C++** folder.  
  
3.  Click the **Output Files** property page.  
  
4.  Modify the **Object File Name** property.  In the development environment, the object file must have an extension of .obj.  
  
### To set this compiler option programmatically  
  
-   See \<xref:Microsoft.VisualStudio.VCProjectEngine.VCCLCompilerTool.ObjectFile*>.  
  
## Example  
 The following command line creates an object file named THIS.obj in an existing directory, \OBJECT, on drive B.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Output-File (/F) Options](../vs140/output-file---f--options.md)   
 [Compiler Options](../vs140/compiler-options.md)   
 [Setting Compiler Options](../vs140/setting-compiler-options.md)   
 [Specifying the Pathname](../vs140/specifying-the-pathname.md)