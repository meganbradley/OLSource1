---
title: "Option -win32manifest ignored"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
H1: Option /win32manifest ignored
f1_keywords: 
  - vbc2034
  - bc2034
helpviewer_keywords: 
  - BC2034
ms.assetid: 8009553a-f6ba-4d2b-8ddd-8a9357bc928e
caps.latest.revision: 9
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Option -win32manifest ignored
Option /win32manifest ignored. It can be specified only when the target is an assembly.  
  
 The Visual Basic compiler has been passed the `/win32manifest` compiler option when the `/target` option is set to `module`.  
  
 **Error ID:** BC2034  
  
### To correct this error  
  
1.  Remove the `/win32manifest` compiler option or set the `/target` option to `exe`, `winexe`, or `library`.  
  
## See Also  
 [/target (Visual Basic)](../vs140/-target--visual-basic-.md)   
 [/win32manifest (Visual Basic)](../vs140/-win32manifest--visual-basic-.md)   
 [Visual Basic Compiler](../vs140/visual-basic-command-line-compiler.md)