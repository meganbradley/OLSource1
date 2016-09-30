---
title: "@ (C# Compiler Options)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "@"
dev_langs: 
  - "CSharp"
  - "CSharp"
helpviewer_keywords: 
  - "response files, specifying for compilation [C#]"
  - "@ compiler option"
ms.assetid: dda4fa9f-a02c-400f-8b6a-d58834e13d7f
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# @ (C# Compiler Options)
The @ option lets you specify a file that contains compiler options and source code files to compile.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Arguments  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A file that lists compiler options or source code files to compile.  
  
## Remarks  
 The compiler options and source code files will be processed by the compiler just as if they had been specified on the command line.  
  
 To specify more than one response file in a compilation, specify multiple response file options. For example:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 In a response file, multiple compiler options and source code files can appear on one line. A single compiler option specification must appear on one line (cannot span multiple lines). Response files can have comments that begin with the # symbol.  
  
 Specifying compiler options from within a response file is just like issuing those commands on the command line. See [Building from the Command Line](../vs140/how-to--set-environment-variables-for-the-visual-studio-command-line.md) for more information.  
  
 The compiler processes the command options as they are encountered. Therefore, command line arguments can override previously listed options in response files. Conversely, options in a response file will override options listed previously on the command line or in other response files.  
  
 C# provides the csc.rsp file, which is located in the same directory as the csc.exe file. See [/noconfig](../vs140/-noconfig--csharp-compiler-options-.md) for more information on csc.rsp.  
  
 This compiler option cannot be set in the Visual Studio development environment, nor can it be changed programmatically.  
  
## Example  
 The following are a few lines from a sample response file:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [C# Compiler Options](../vs140/csharp-compiler-options.md)