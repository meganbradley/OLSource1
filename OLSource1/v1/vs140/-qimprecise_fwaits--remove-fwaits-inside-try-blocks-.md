---
title: "-Qimprecise_fwaits (Remove fwaits Inside Try Blocks)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/Qimprecise_fwaits (Remove fwaits Inside Try Blocks)"
f1_keywords: 
  - "/Qimprecise_fwaits"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "-Qimprecise_fwaits compiler option (C++)"
  - "/Qimprecise_fwaits compiler option (C++)"
ms.assetid: b1501f21-7e08-4fea-95e8-176ec03a635b
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -Qimprecise_fwaits (Remove fwaits Inside Try Blocks)
Removes the `fwait` commands internal to `try` blocks when you use the [/fp:except](../vs140/-fp--specify-floating-point-behavior-.md) compiler option.  
  
## Syntax  
  
```  
/Qimprecise_fwaits  
```  
  
## Remarks  
 This option has no effect if **/fp:except** is not also specified. If you specify the **/fp:except** option, the compiler will insert a `fwait` command around each line of code in a `try` block. In this way, the compiler can identify the specific line of code that produces an exception. **/Qimprecise_fwaits** removes internal `fwait` instructions, leaving only the waits around the `try` block. This improves performance, but the compiler will only be able to say which `try` block causes an exception, not which line.  
  
### To set this compiler option in the Visual Studio development environment  
  
1.  Open the project's **Property Pages** dialog box. For details, see [How to: Open Project Property Pages](../vs140/how-to--open-project-property-pages.md).  
  
2.  Click the **C/C++** folder.  
  
3.  Click the **Command Line** property page.  
  
4.  Type the compiler option in the **Additional Options** box.  
  
### To set this compiler option programmatically  
  
-   See <xref:Microsoft.VisualStudio.VCProjectEngine.VCCLCompilerTool.AdditionalOptions*>.  
  
## See Also  
 [/Q Options (Low-Level Operations)](../vs140/-q-options--low-level-operations-.md)   
 [Compiler Options](../vs140/compiler-options.md)   
 [Setting Compiler Options](../vs140/setting-compiler-options.md)