---
title: "-D (Preprocessor Definitions)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/D (Preprocessor Definitions)"
f1_keywords: 
  - "VC.Project.VCNMakeTool.PreprocessorDefinitions"
  - "VC.Project.VCCLCompilerTool.PreprocessorDefinitions"
  - "/d"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "preprocessor definition symbols"
  - "constants, defining"
  - "macros, compiling"
  - "/D compiler option [C++]"
  - "-D compiler option [C++]"
  - "D compiler option [C++]"
ms.assetid: b53fdda7-8da1-474f-8811-ba7cdcc66dba
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -D (Preprocessor Definitions)
Defines a preprocessing symbol for a source file.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 You can use this symbol together with <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> to compile source code conditionally. The symbol definition remains in effect until it is redefined in the code or is undefined in the code by the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> directive.  
  
 **/D** has the same effect as the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> directive at the beginning of a source code file, except that **/D** strips quotation marks on the command line and <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> retains them.  
  
 By default, the value associated with a symbol is 1. For example, **/D**<CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is equivalent to **/D**<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>**=1**. In the example at the end of this article, the definition of **TEST** is shown to print <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
 Compiling by using **/D**<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>**=** causes the symbol to have no associated value. Although the symbol can still be used to conditionally compile code, it otherwise evaluates to nothing. In the example, if you compile by using **/DTEST=**, an error occurs. This behavior resembles the use of <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> with or without a value.  
  
 This command defines the symbol DEBUG in TEST.c:  
  
 **CL /DDEBUG  TEST.C**  
  
 This command removes all occurrences of the keyword <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> in TEST.c:  
  
 **CL /D__far=  TEST.C**  
  
 The **CL** environment variable cannot be set to a string that contains the equal sign. To use **/D** together with the **CL** environment variable, you must specify the number sign instead of the equal sign:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 When you define a preprocessing symbol at the command prompt, consider both compiler parsing rules and shell parsing rules. For example, to define a percent-sign preprocessing symbol (%) in your program, specify two percent-sign characters (%%) at the command prompt: If you specify only one, a parsing error is emitted.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### To set this compiler option in the Visual Studio development environment  
  
1.  Open the project **Property Pages** dialog box. For more information, see [How to: Open Project Property Pages](../vs140/how-to--open-project-property-pages.md).  
  
2.  In the left pane, select **Configuration Properties**, **C/C++**, **Preprocessor**.  
  
3.  In the right pane, in the right-hand column of the **Preprocessor Definitions** property, open the drop-down menu and choose **Edit**.  
  
4.  In the **Preprocessor Definitions** dialog box, add (one per line), modify, or delete one or more definitions. Choose **OK** to save your changes.  
  
### To set this compiler option programmatically  
  
-   See \<xref:Microsoft.VisualStudio.VCProjectEngine.VCCLCompilerTool.PreprocessorDefinitions*>.  
  
## Example  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 **TEST defined 1**   
## See Also  
 [Compiler Options](../vs140/compiler-options.md)   
 [Setting Compiler Options](../vs140/setting-compiler-options.md)   
 [/U, /u (Undefine Symbols)](../vs140/-u---u--undefine-symbols-.md)   
 [#undef Directive (C/C++)](../vs140/sharpundef-directive--c-c---.md)   
 [#define Directive (C/C++)](../vs140/sharpdefine-directive--c-c---.md)