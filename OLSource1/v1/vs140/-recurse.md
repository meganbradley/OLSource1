---
title: "-recurse"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/recurse"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "/recurse compiler option [Visual Basic]"
  - "-recurse compiler option [Visual Basic]"
  - "recurse compiler option [Visual Basic]"
ms.assetid: 84a0b670-33ae-44c4-a46a-b90388809317
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -recurse
Compiles source-code files in all child directories of either the specified directory or the project directory.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Arguments  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Optional. The directory in which you want the search to begin. If not specified, the search begins in the project directory.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Required. The file(s) to search for. Wildcard characters are allowed.  
  
## Remarks  
 You can use wildcards in a file name to compile all matching files in the project directory without using <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. If no output file name is specified, the compiler bases the output file name on the first input file processed. This is generally the first file in the list of files compiled when viewed alphabetically. For this reason, it is best to specify an output file using the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> option.  
  
> [!NOTE]
>  The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> option is not available from within the Visual Studio development environment; it is available only when compiling from the command line.  
  
## Example  
 The following code compiles all [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] files in the current directory.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The following code compiles all [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] files in the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> directory and any directories below it, and then generates <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [Visual Basic Command-Line Compiler](../vs140/visual-basic-command-line-compiler.md)   
 [/out (Visual Basic)](../vs140/-out--visual-basic-.md)   
 [Sample Compilation Command Lines](../vs140/sample-compilation-command-lines--visual-basic-.md)