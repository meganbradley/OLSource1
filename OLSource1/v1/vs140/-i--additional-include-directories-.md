---
title: "-I (Additional Include Directories)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/I (Additional Include Directories)"
f1_keywords: 
  - "VC.Project.VCCLWCECompilerTool.AdditionalIncludeDirectories"
  - "VC.Project.VCCLCompilerTool.AdditionalIncludeDirectories"
  - "/I"
  - "VC.Project.VCNMakeTool.IncludeSearchPath"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "/I compiler option [C++]"
  - "Additional Include Directories compiler option"
  - "I compiler option [C++]"
  - "-I compiler option [C++]"
  - "set include directories"
  - "include directories, compiler option [C++]"
ms.assetid: 3e9add2a-5ed8-4d15-ad79-5b411e313a49
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -I (Additional Include Directories)
Adds a directory to the list of directories searched for include files.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Arguments  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The directory to be added to the list of directories searched for include files.  
  
## Remarks  
 To add more than one directory, use this option more than once. Directories are searched only until the specified include file is found.  
  
 You can use this option with the Ignore Standard Include Paths ([/X (Ignore Standard Include Paths)](../vs140/-x--ignore-standard-include-paths-.md)) option.  
  
 The compiler searches for directories in the following order:  
  
1.  Directories containing the source file.  
  
2.  Directories specified with the **/I** option, in the order that CL encounters them.  
  
3.  Directories specified in the **INCLUDE** environment variable.  
  
### To set this compiler option in the Visual Studio development environment  
  
1.  Open the project's **Property Pages** dialog box. For details, see [How to: Open Project Property Pages](../vs140/how-to--open-project-property-pages.md).  
  
2.  Click the **C/C++** folder.  
  
3.  Click the **General** property page.  
  
4.  Modify the **Additional Include Directories** property.  
  
### To set this compiler option programmatically  
  
-   See \<xref:Microsoft.VisualStudio.VCProjectEngine.VCCLCompilerTool.AdditionalIncludeDirectories*>.  
  
## Example  
 The following command looks for the include files requested by MAIN.c in the following order: first in the directory containing MAIN.c, then in the \INCLUDE directory, then in the \MY\INCLUDE directory, and finally in the directories assigned to the INCLUDE environment variable.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Compiler Options](../vs140/compiler-options.md)   
 [Setting Compiler Options](../vs140/setting-compiler-options.md)