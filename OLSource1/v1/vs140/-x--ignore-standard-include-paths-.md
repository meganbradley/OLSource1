---
title: "-X (Ignore Standard Include Paths)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/X (Ignore Standard Include Paths)"
f1_keywords: 
  - "/x"
  - "VC.Project.VCCLCompilerTool.IgnoreStandardIncludePath"
  - "VC.Project.VCCLWCECompilerTool.IgnoreStandardIncludePath"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "/X compiler option [C++]"
  - "include files, ignore standard path"
  - "-X compiler option [C++]"
  - "include directories, ignore standard"
  - "X compiler option"
  - "Ignore Standard Include Paths compiler option"
ms.assetid: 16bdf2cc-c8dc-46e4-bdcc-f3caeba5e1ef
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -X (Ignore Standard Include Paths)
Prevents the compiler from searching for include files in directories specified in the PATH and INCLUDE environment variables.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 You can use this option with the [/I (Additional Include Directories)](../vs140/-i--additional-include-directories-.md) (**/I**<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>) option.  
  
### To set this compiler option in the Visual Studio development environment  
  
1.  Open the project's **Property Pages** dialog box. For details, see [How to: Open Project Property Pages](../vs140/how-to--open-project-property-pages.md).  
  
2.  Click the **C/C++** folder.  
  
3.  Click the **Preprocessor** property page.  
  
4.  Modify the **Ignore Standard Include Path** property.  
  
### To set this compiler option programmatically  
  
-   See \<xref:Microsoft.VisualStudio.VCProjectEngine.VCCLCompilerTool.IgnoreStandardIncludePath*>.  
  
## Example  
 In the following command, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> tells the compiler to ignore locations specified by the PATH and INCLUDE environment variables, and <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> specifies the directory in which to look for include files:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Compiler Options](../vs140/compiler-options.md)   
 [Setting Compiler Options](../vs140/setting-compiler-options.md)