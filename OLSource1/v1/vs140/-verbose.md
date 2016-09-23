---
title: "-verbose"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-visual-basic
ms.tgt_pltfrm: na
ms.topic: article
H1: /verbose
dev_langs: 
  - VB
helpviewer_keywords: 
  - verbose compiler option [Visual Basic]
  - -verbose compiler option [Visual Basic]
  - /verbose compiler option [Visual Basic]
ms.assetid: d1aec0c1-0261-421d-9adc-5b13756100be
caps.latest.revision: 15
translation.priority.ht: 
  - de-de
  - ja-jp
---
# -verbose
Causes the compiler to produce verbose status and error messages.  
  
## Syntax  
  
```  
/verbose[+ | -]  
```  
  
## Arguments  
 `+` &#124; `-`  
 Optional. Specifying `/verbose` is the same as specifying `/verbose+`, which causes the compiler to emit verbose messages. The default for this option is `/verbose-`.  
  
## Remarks  
 The `/verbose` option displays information about the total number of errors issued by the compiler, reports which assemblies are being loaded by a module, and displays which files are currently being compiled.  
  
> [!NOTE]
>  The `/verbose` option is not available from within the Visual Studio development environment; it is available only when compiling from the command line.  
  
## Example  
 The following code compiles `In.vb` and directs the compiler to display verbose status information.  
  
```  
vbc /verbose in.vb  
```  
  
## See Also  
 [Visual Basic Command-Line Compiler](../vs140/visual-basic-command-line-compiler.md)   
 [Sample Compilation Command Lines](../vs140/sample-compilation-command-lines--visual-basic-.md)