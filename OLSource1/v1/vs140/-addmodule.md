---
title: "-addmodule"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/addmodule"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "/addmodule compiler option [Visual Basic]"
  - "addmodule compiler option [Visual Basic]"
  - "-addmodule compiler option [Visual Basic]"
ms.assetid: fb4b89d4-4926-4f20-868d-427fa28497b2
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -addmodule
Causes the compiler to make all type information from the specified file(s) available to the project you are currently compiling.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Arguments  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Required. Comma-delimited list of files that contain metadata but do not contain assembly manifests. File names containing spaces should be surrounded by quotation marks (" ").  
  
## Remarks  
 The files listed by the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> parameter must be created with the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> option, or with another compiler's equivalent to <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
 All modules added with <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> must be in the same directory as the output file at run time. That is, you can specify a module in any directory at compile time, but the module must be in the application directory at run time. If it is not, you get a \<xref:System.TypeLoadException*> error.  
  
 If you specify (implicitly or explicitly) any[/target (Visual Basic)](../vs140/-target--visual-basic-.md) option other than <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> with <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, the files you pass to <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> become part of the project's assembly. An assembly is required to run an output file that has one or more files added with <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
 Use [/reference (Visual Basic)](../vs140/-reference--visual-basic-.md) to import metadata from a file that contains an assembly.  
  
> [!NOTE]
>  The <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> option is not available from within the Visual Studio development environment; it is available only when compiling from the command line.  
  
## Example  
 The following code creates a module.  
  
 [!code[VbVbalrCompiler#47](../vs140/codesnippet/VisualBasic/-addmodule_1.vb)]  
  
 The following code imports the module's types.  
  
 [!code[VbVbalrCompiler#48](../vs140/codesnippet/VisualBasic/-addmodule_2.vb)]  
  
 When you run <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, it outputs <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
## See Also  
 [Visual Basic Command-Line Compiler](../vs140/visual-basic-command-line-compiler.md)   
 [/target (Visual Basic)](../vs140/-target--visual-basic-.md)   
 [/reference (Visual Basic)](../vs140/-reference--visual-basic-.md)   
 [Sample Compilation Command Lines](../vs140/sample-compilation-command-lines--visual-basic-.md)