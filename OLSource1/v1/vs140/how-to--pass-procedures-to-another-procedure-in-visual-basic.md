---
title: "How to: Pass Procedures to Another Procedure in Visual Basic"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "AddressOf operator"
  - "delegates [Visual Basic], passing procedures"
ms.assetid: 5adbba15-5a1d-413f-ab3e-3ff6cc0a4669
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Pass Procedures to Another Procedure in Visual Basic
This example shows how to use delegates to pass a procedure to another procedure.  
  
 A delegate is a type that you can use like any other type in [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)]. The `AddressOf` operator returns a delegate object when applied to a procedure name.  
  
 This example has a procedure with a delegate parameter that can take a reference to another procedure, obtained with the `AddressOf` operator.  
  
### Create the delegate and matching procedures  
  
1.  Create a delegate named `MathOperator`.  
  
     [!code[VbVbalrDelegates#1](../vs140/codesnippet/VisualBasic/how-to--pass-procedures-to-another-procedure-in-visual-basic_1.vb)]  
  
2.  Create a procedure named `AddNumbers` with parameters and return value that match those of `MathOperator`, so that the signatures match.  
  
     [!code[VbVbalrDelegates#2](../vs140/codesnippet/VisualBasic/how-to--pass-procedures-to-another-procedure-in-visual-basic_2.vb)]  
  
3.  Create a procedure named `SubtractNumbers` with a signature that matches `MathOperator`.  
  
     [!code[VbVbalrDelegates#3](../vs140/codesnippet/VisualBasic/how-to--pass-procedures-to-another-procedure-in-visual-basic_3.vb)]  
  
4.  Create a procedure named `DelegateTest` that takes a delegate as a parameter.  
  
     This procedure can accept a reference to `AddNumbers` or `SubtractNumbers`, because their signatures match the `MathOperator` signature.  
  
     [!code[VbVbalrDelegates#4](../vs140/codesnippet/VisualBasic/how-to--pass-procedures-to-another-procedure-in-visual-basic_4.vb)]  
  
5.  Create a procedure named `Test` that calls `DelegateTest` once with the delegate for `AddNumbers` as a parameter, and again with the delegate for `SubtractNumbers` as a parameter.  
  
     [!code[VbVbalrDelegates#5](../vs140/codesnippet/VisualBasic/how-to--pass-procedures-to-another-procedure-in-visual-basic_5.vb)]  
  
     When `Test` is called, it first displays the result of `AddNumbers` acting on `5` and `3`, which is 8. Then the result of `SubtractNumbers` acting on `9` and `3` is displayed, which is 6.  
  
## See Also  
 [Delegates in Visual Basic](../vs140/delegates--visual-basic-.md)   
 [AddressOf Operator](../vs140/addressof-operator--visual-basic-.md)   
 [Delegate Statement](../vs140/delegate-statement.md)   
 [How to: Invoke a Delegate Method](../vs140/how-to--invoke-a-delegate-method--visual-basic-.md)