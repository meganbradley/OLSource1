---
title: "-nologo (Visual Basic)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-visual-basic
ms.tgt_pltfrm: na
ms.topic: article
H1: /nologo (Visual Basic)
dev_langs: 
  - VB
helpviewer_keywords: 
  - -nologo compiler option [Visual Basic]
  - banners, suppressing startup
  - nologo compiler option [Visual Basic]
  - /nologo compiler option [Visual Basic]
ms.assetid: 25ef54b6-d676-4639-a2d2-a747a158bc07
caps.latest.revision: 20
translation.priority.ht: 
  - de-de
  - ja-jp
---
# -nologo (Visual Basic)
Suppresses display of the copyright banner and informational messages during compilation.  
  
## Syntax  
  
```  
/nologo  
```  
  
## Remarks  
 If you specify `/nologo`, the compiler does not display a copyright banner. By default, `/nologo` is not in effect.  
  
> [!NOTE]
>  The `/nologo` option is not available from within the Visual Studio development environment; it is available only when compiling from the command line.  
  
## Example  
 The following code compiles `T2.vb` and does not display a copyright banner.  
  
```  
vbc /nologo t2.vb  
```  
  
## See Also  
 [Visual Basic Command-Line Compiler](../vs140/visual-basic-command-line-compiler.md)   
 [Sample Compilation Command Lines](../vs140/sample-compilation-command-lines--visual-basic-.md)