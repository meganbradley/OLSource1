---
title: "-Zg (Generate Function Prototypes)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/Zg (Generate Function Prototypes)"
f1_keywords: 
  - "/zg"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Zg compiler option [C++]"
  - "/Zg compiler option [C++]"
  - "function prototypes, generate function prototypes compiler option"
  - "-Zg compiler option [C++]"
  - "generate function prototypes compiler option"
ms.assetid: c8df1b46-24ff-46f2-8356-e0a144b21dd2
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -Zg (Generate Function Prototypes)
Removed. Creates a function prototype for each function defined in the source file, but does not compile the source file.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 This compiler option is no longer available. It was removed in Visual C++ 2015. This page remains for users of older versions of Visual C++.  
  
 The function prototype includes the function return type and an argument type list. The argument type list is created from the types of the formal parameters of the function. Any function prototypes already present in the source file are ignored.  
  
 The list of prototypes is written to standard output. You may find this list helpful to verify that actual arguments and formal parameters of a function are compatible. You can save the list by redirecting standard output to a file. Then you can use **#include** to make the list of function prototypes a part of your source file. Doing so causes the compiler to perform argument type checking.  
  
 If you use the **/Zg** option and your program contains formal parameters that have struct, enum, or union type (or pointers to such types), the declaration of each struct, enum, or union type must have a tag (name). In the following sample, the tag name is <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **/Zg** is deprecated. The Visual C++ compiler plans to remove support for older, C-style code. For more information, see [Deprecated Compiler Options in Visual C++ 2005](assetId:///aa59fce3-50b8-4f66-9aeb-ce09a7a84cce).  
  
### To set this compiler option in the Visual Studio development environment  
  
1.  Open the project's **Property Pages** dialog box. For details, see [How to: Open Project Property Pages](../vs140/how-to--open-project-property-pages.md).  
  
2.  Click the **C/C++** folder.  
  
3.  Click the **Command Line** property page.  
  
4.  Type the compiler option in the **Additional Options** box.  
  
### To set this compiler option programmatically  
  
-   See \<xref:Microsoft.VisualStudio.VCProjectEngine.VCCLCompilerTool.AdditionalOptions*>.  
  
## See Also  
 [Compiler Options](../vs140/compiler-options.md)   
 [Setting Compiler Options](../vs140/setting-compiler-options.md)