---
title: "-showIncludes (List Include Files)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/showIncludes (List Include Files)"
f1_keywords: 
  - "VC.Project.VCCLWCECompilerTool.ShowIncludes"
  - "VC.Project.VCCLCompilerTool.ShowIncludes"
  - "/showincludes"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "include files"
  - "/showIncludes compiler option [C++]"
  - "include files, displaying in compilation"
  - "-showIncludes compiler option [C++]"
  - "showIncludes compiler option [C++]"
ms.assetid: 0b74b052-f594-45a6-a7c7-09e1a319547d
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -showIncludes (List Include Files)
Causes the compiler to output a list of the include files. Nested include files are also displayed (files that are included from the files that you include).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 When an include file is encountered during compilation, a message is output, for example:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Nested include files are indicated by an indentation, one space for each level of nesting, for example:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 In this case, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> was included from within <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, hence the indentation.  
  
 The **/showIncludes** option emits to <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, not <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
### To set this compiler option in the Visual Studio development environment  
  
1.  Open the project's **Property Pages** dialog box. For details, see [How to: Open Project Property Pages](../vs140/how-to--open-project-property-pages.md).  
  
2.  Click the **C/C++** folder.  
  
3.  Click the **Advanced** property page.  
  
4.  Modify the **Show Includes** property.  
  
### To set this compiler option programmatically  
  
-   See \<xref:Microsoft.VisualStudio.VCProjectEngine.VCCLCompilerTool.ShowIncludes*>.  
  
## See Also  
 [Compiler Options](../vs140/compiler-options.md)   
 [Setting Compiler Options](../vs140/setting-compiler-options.md)