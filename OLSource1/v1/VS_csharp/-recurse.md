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
  
```  
/recurse:[dir\]file  
```  
  
## Arguments  
 `dir`  
 Optional. The directory in which you want the search to begin. If not specified, the search begins in the project directory.  
  
 `file`  
 Required. The file(s) to search for. Wildcard characters are allowed.  
  
## Remarks  
 You can use wildcards in a file name to compile all matching files in the project directory without using `/recurse`. If no output file name is specified, the compiler bases the output file name on the first input file processed. This is generally the first file in the list of files compiled when viewed alphabetically. For this reason, it is best to specify an output file using the `/out` option.  
  
> [!NOTE]
>  The `/recurse` option is not available from within the Visual Studio development environment; it is available only when compiling from the command line.  
  
## Example  
 The following code compiles all [!INCLUDE[vbprvb](../VS_csharp/includes/vbprvb_md.md)] files in the current directory.  
  
```  
vbc *.vb  
```  
  
 The following code compiles all [!INCLUDE[vbprvb](../VS_csharp/includes/vbprvb_md.md)] files in the `Test\ABC` directory and any directories below it, and then generates `Test.ABC.dll`.  
  
```  
vbc /target:library /out:Test.ABC.dll /recurse:Test\ABC\*.vb  
```  
  
## See Also  
 [Visual Basic Command-Line Compiler](../VS_csharp/visual-basic-command-line-compiler.md)   
 [/out (Visual Basic)](../VS_csharp/-out--visual-basic-.md)   
 [Sample Compilation Command Lines](../VS_csharp/sample-compilation-command-lines--visual-basic-.md)