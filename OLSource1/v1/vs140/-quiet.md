---
title: "-quiet"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-visual-basic
ms.tgt_pltfrm: na
ms.topic: article
H1: /quiet
f1_keywords: 
  - /quiet
  - quiet
dev_langs: 
  - VB
helpviewer_keywords: 
  - -quiet compiler option [Visual Basic]
  - /quiet compiler option [Visual Basic]
  - quiet compiler option [Visual Basic]
ms.assetid: 5d77fa23-4c50-4708-8535-649912b098e8
caps.latest.revision: 15
translation.priority.ht: 
  - de-de
  - ja-jp
---
# -quiet
Prevents the compiler from displaying code for syntax-related errors and warnings.  
  
## Syntax  
  
```  
/quiet  
```  
  
## Remarks  
 By default, `/quiet` is not in effect. When the compiler reports a syntax-related error or warning, it also outputs the line from source code. For applications that parse compiler output, it may be more convenient for the compiler to output only the text of the diagnostic.  
  
 In the following example, `Module1` outputs an error that includes source code when compiled without `/quiet`.  
  
```  
Module Module1  
    Sub Main()  
        x()  
    End Sub  
End Module  
```  
  
 Output:  
  
 `E:\test\t2.vb(3) : error BC30451: Name 'x' is not declared.`  
  
 `x`  
  
 `~`  
  
 Compiled with `/quiet`, the compiler outputs only the following:  
  
 `E:\test\t2.vb(3) : error BC30451: Name 'x' is not declared.`  
  
> [!NOTE]
>  The `/quiet` option is not available from within the Visual Studio development environment; it is available only when compiling from the command line.  
  
## Example  
 The following code compiles `T2.vb` and does not display code for syntax-related compiler diagnostics:  
  
```  
vbc /quiet t2.vb  
```  
  
## See Also  
 [Visual Basic Command-Line Compiler](../vs140/visual-basic-command-line-compiler.md)   
 [Sample Compilation Command Lines](../vs140/sample-compilation-command-lines--visual-basic-.md)