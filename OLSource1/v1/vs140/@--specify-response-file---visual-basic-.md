---
title: "@ (Specify Response File) (Visual Basic)"
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
  - "@ (Specify Response File) compiler option [Visual Basic]"
ms.assetid: a6847eaa-e5f9-4303-9421-45b55484b9ca
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# @ (Specify Response File) (Visual Basic)
Specifies a file that contains compiler options and source-code files to compile.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Arguments  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Required. A file that lists compiler options or source-code files to compile. Enclose the file name in quotation marks (" ") if it contains a space.  
  
## Remarks  
 The compiler processes the compiler options and source-code files specified in a response file as if they had been specified on the command line.  
  
 To specify more than one response file in a compilation, specify multiple response-file options, such as the following.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 In a response file, multiple compiler options and source-code files can appear on one line. A single compiler-option specification must appear on one line (cannot span multiple lines). Response files can have comments that begin with the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> symbol.  
  
 You can combine options specified on the command line with options specified in one or more response files. The compiler processes the command options as it encounters them. Therefore, command-line arguments can override previously listed options in response files. Conversely, options in a response file override options listed previously on the command line or in other response files.  
  
 Visual Basic provides the Vbc.rsp file, which is located in the same directory as the Vbc.exe file. The Vbc.rsp file is included by default, unless the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> option is used. For more information, see [/noconfig](../vs140/-noconfig.md).  
  
> [!NOTE]
>  The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> option is not available from within the Visual Studio development environment; it is available only when compiling from the command line.  
  
## Example  
 The following lines are from a sample response file.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Example  
 The following example demonstrates how to use the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> option with the response file named <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## See Also  
 [Visual Basic Command-Line Compiler](../vs140/visual-basic-command-line-compiler.md)   
 [/noconfig](../vs140/-noconfig.md)   
 [Sample Compilation Command Lines](../vs140/sample-compilation-command-lines--visual-basic-.md)