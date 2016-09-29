---
title: "-GX (Enable Exception Handling)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/GX (Enable Exception Handling)"
f1_keywords: 
  - "/gx"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "exception handling, enabling"
  - "/GX compiler option [C++]"
  - "-GX compiler option [C++]"
  - "cl.exe compiler, exception handling"
  - "enable exception handling compiler option [C++]"
  - "GX compiler option [C++]"
ms.assetid: 933b43ba-de77-4ff8-a48b-7074de90bc1c
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -GX (Enable Exception Handling)
Deprecated. Enables synchronous exception handling using the assumption that functions declared by using `extern "C"` never throw an exception.  
  
## Syntax  
  
```  
/GX  
```  
  
## Remarks  
 **/GX** is deprecated. Use the equivalent [/EHsc](../vs140/-eh--exception-handling-model-.md) option instead. For a list of deprecated compiler options, see the **Deprecated and Removed Compiler Options** section in [Compiler Options Listed by Category](../vs140/compiler-options-listed-by-category.md).  
  
 By default, **/EHsc**, the equivalent of **/GX**, is in effect when you compile by using the Visual Studio development environment. When using the command line tools, no exception handling is specified. This is the equivalent of **/GX-**.  
  
 For more information, see [C++ Exception Handling](../vs140/c---exception-handling.md).  
  
### To set this compiler option in the Visual Studio development environment  
  
1.  Open the project's **Property Pages** dialog box. For details, see [How to: Open Project Property Pages](../vs140/how-to--open-project-property-pages.md).  
  
2.  In the navigation pane, choose **Configuration Properties**, **C/C++**, **Command Line**.  
  
3.  Type the compiler option in the **Additional Options** box.  
  
### To set this compiler option programmatically  
  
-   See <xref:Microsoft.VisualStudio.VCProjectEngine.VCCLCompilerTool.AdditionalOptions*>.  
  
## See Also  
 [Compiler Options](../vs140/compiler-options.md)   
 [Setting Compiler Options](../vs140/setting-compiler-options.md)   
 [/EH](../vs140/-eh--exception-handling-model-.md)