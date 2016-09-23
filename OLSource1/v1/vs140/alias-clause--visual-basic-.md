---
title: "Alias Clause (Visual Basic)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-visual-basic
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - vb.Alias
dev_langs: 
  - VB
helpviewer_keywords: 
  - Alias keyword
ms.assetid: 58c06b11-465d-4d87-906a-73200a3d7f19
caps.latest.revision: 15
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Alias Clause (Visual Basic)
Indicates that an external procedure has another name in its DLL.  
  
## Remarks  
 The `Alias` keyword can be used in this context:  
  
 [Declare Statement](../vs140/declare-statement.md)  
  
 In the following example, the `Alias` keyword is used to provide the name of the function in advapi32.dll, `GetUserNameA`, that `getUserName` is used in place of in this example. Function `getUserName` is called in sub `getUser`, which displays the name of the current user.  
  
 [!code[VbVbalrStatements#15](../vs140/codesnippet/VisualBasic/alias-clause--visual-basic-_1.vb)]
  
  
## See Also  
 [Keywords (Visual Basic)](../vs140/keywords--visual-basic-.md)