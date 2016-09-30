---
title: "-AI (Specify Metadata Directories)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/AI (Specify Metadata Directories)"
f1_keywords: 
  - "VC.Project.VCCLCompilerTool.AdditionalUsingDirectories"
  - "VC.Project.VCNMakeTool.AssemblySearchPath"
  - "/AI"
  - "VC.Project.VCCLWCECompilerTool.AdditionalUsingDirectories"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "/AI compiler option [C++]"
  - "AI compiler option [C++]"
  - "-AI compiler option [C++]"
ms.assetid: fb9c1846-504c-4a3b-bb39-c8696de32f6f
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -AI (Specify Metadata Directories)
Specifies a directory that the compiler will search to resolve file references passed to the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> directive.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Arguments  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The directory or path for the compiler to search.  
  
## Remarks  
 Only one directory can be passed to an **/AI** invocation. Specify one **/AI** option for each path you want the compiler to search. For example, to add both C:\Project\Meta and C:\Common\Meta to the compiler search path for <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> directives, add <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> to the compiler command line or add each directory to the **Additional #using Directories** property in Visual Studio.  
  
### To set this compiler option in the Visual Studio development environment  
  
1.  Open the project's **Property Pages** dialog box. For details, see [How to: Open Project Property Pages](../vs140/how-to--open-project-property-pages.md).  
  
2.  In the navigation pane, select **Configuration Properties**, **C/C++**, **General**.  
  
3.  Modify the **Additional #using Directories** property.  
  
### To set this compiler option programmatically  
  
-   See \<xref:Microsoft.VisualStudio.VCProjectEngine.VCCLCompilerTool.AdditionalUsingDirectories*>.  
  
## See Also  
 [Compiler Options](../vs140/compiler-options.md)   
 [Setting Compiler Options](../vs140/setting-compiler-options.md)   
 [The #using Directive](../vs140/sharpusing-directive--c---.md)