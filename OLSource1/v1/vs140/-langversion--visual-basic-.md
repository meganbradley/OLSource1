---
title: "-langversion (Visual Basic)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-visual-basic
ms.tgt_pltfrm: na
ms.topic: article
H1: /langversion (Visual Basic)
dev_langs: 
  - VB
helpviewer_keywords: 
  - /langversion compiler option [Visual Basic]
  - langversion compiler option [Visual Basic]
  - -langversion compiler option [Visual Basic]
ms.assetid: 59b7b0c8-2dde-4e9b-94e7-0237f7e0bafb
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# -langversion (Visual Basic)
Causes the compiler to accept only syntax that is included in the specified Visual Basic language version.  
  
## Syntax  
  
```  
/langversion:version  
```  
  
## Arguments  
 `version`  
 Required. The language version to be used during the compilation. Accepted values are `9`, `9.0`, `10`, and `10.0`.  
  
## Remarks  
 The `/langversion` option specifies what syntax the compiler accepts. For example, if you specify that the language version is 9.0, the compiler generates errors for syntax that is valid only in version 10.0 and later.  
  
 You can use this option when you develop applications that target different versions of the .NET Framework. For example, if you are targeting .NET Framework 3.5, you could use this option to ensure that you do not use syntax from language version 10.0.  
  
 You can set `/langversion` directly only by using the command line. For more information, see [Targeting a Specific .NET Framework](../vs140/targeting-a-specific-.net-framework-version.md).  
  
## Example  
 The following code compiles `sample.vb` for Visual Basic 9.0.  
  
```  
vbc /langversion:9.0 sample.vb  
```  
  
## See Also  
 [Visual Basic Command-Line Compiler](../vs140/visual-basic-command-line-compiler.md)   
 [Sample Compilation Command Lines](../vs140/sample-compilation-command-lines--visual-basic-.md)   
 [Targeting a Specific .NET Framework](../vs140/targeting-a-specific-.net-framework-version.md)