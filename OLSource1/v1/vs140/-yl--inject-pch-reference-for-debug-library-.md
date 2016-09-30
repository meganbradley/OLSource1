---
title: "-Yl (Inject PCH Reference for Debug Library)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/Yl (Inject PCH Reference for Debug Library)"
f1_keywords: 
  - "/yi"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "-Yl compiler option [C++]"
  - "Yl compiler option [C++]"
  - "/Yl compiler option [C++]"
ms.assetid: 8e4a396a-6790-4a9f-8387-df015a3220e7
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -Yl (Inject PCH Reference for Debug Library)
Used if creating a debugging library that uses precompiled headers and the build fails.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Arguments  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 An arbitrary symbol to be stored in the object module.  
  
 \-  
 A minus sign (-) that explicitly disables the **/Yl** compiler option.  
  
## Remarks  
 By default, the compiler uses the **/Yl** option (without specifying a *symbol*). The **/Yl** option enables the debugger to get complete information about types. **/Yl-** disables the default behavior.  
  
 When you compile a module with **/Yc** and **/Yl**<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, the compiler creates a symbol similar to __@@_PchSym\_@00@...@<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, where the ellipsis (...) represents a linker-generated character string, and stores it in the object module. Any source file that you compile with this precompiled header refers to the specified symbol, which causes the linker to include the object module and its debugging information from the library.  
  
 Using this option, you may generate LNK1211. When you specify the [/Yc (Create Precompiled Header File)](../vs140/-yc--create-precompiled-header-file-.md) and [/Z7, /Zi, /ZI (Debug Information Format)](../vs140/-z7---zi---zi--debug-information-format-.md) options, the compiler creates a precompiled header file that contains debugging information. An error can occur when you store the precompiled header in a library, use the library to build an object module, and the source code does not refer to any of the functions the precompiled header file defines.  
  
 To solve the problem, specify **/Yl**<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, where <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is the name of an arbitrary symbol in the library, when you create a precompiled header file that does not contain any function definitions. This option directs the compiler to store the debugging information in the precompiled header file.  
  
 For more information on precompiled headers, see:  
  
-   [/Y (Precompiled Headers)](../vs140/-y--precompiled-headers-.md)  
  
-   [Creating Precompiled Header Files](../vs140/creating-precompiled-header-files.md)  
  
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