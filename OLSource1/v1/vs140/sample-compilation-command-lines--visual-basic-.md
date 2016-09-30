---
title: "Sample Compilation Command Lines (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "command line, compilers"
  - "compilation, command-line"
  - "command-line compilers"
  - "compiling source code, from command line"
  - "Visual Basic compiler, sample command lines"
ms.assetid: 5bfbb487-5f47-4267-969a-39dfb917beeb
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Sample Compilation Command Lines (Visual Basic)
As an alternative to compiling [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] programs from within [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)], you can compile from the command line to produce executable (.exe) files or dynamic-link library (.dll) files.  
  
 The [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] command-line compiler supports a complete set of options that control input and output files, assemblies, and debug and preprocessor options. Each option is available in two interchangeable forms: <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>. This documentation shows only the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> form.  
  
 The following table lists some sample command lines you can modify for your own use.  
  
|To|Use|  
|--------|---------|  
|Compile File.vb and create File.exe|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|  
|Compile File.vb and create File.dll|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|  
|Compile File.vb and create My.exe|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|  
|Compile all [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] files in the current directory, with optimizations on and the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> symbol defined, producing File2.exe|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|  
|Compile all [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] files in the current directory, producing a debug version of File2.dll without displaying the logo or warnings|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|  
|Compile all [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] files in the current directory to Something.dll|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|  
  
 When compiling from the command line, you must explicitly reference the Microsoft [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] run-time library through the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> compiler option.  
  
> [!TIP]
>  When you build a project by using the Visual Studio IDE, you can display information about the associated **vbc** command with its compiler options in the output window. To display this information, open the [Build and Run, Projects and Solutions, Options Dialog Box](../vs140/options-dialog-box---projects-and-solutions--build-and-run.md), and then set the **MSBuild project build output verbosity** to **Normal** or a higher level of verbosity. For more information, see [How to: View, Save, and Configure Build Log Files](../vs140/how-to--view--save--and-configure-build-log-files.md).  
  
## See Also  
 [Visual Basic Command-Line Compiler](../vs140/visual-basic-command-line-compiler.md)   
 [Conditional Compilation](../vs140/conditional-compilation-in-visual-basic.md)