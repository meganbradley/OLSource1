---
title: "How to: Protect a Procedure Argument Against Value Changes (Visual Basic)"
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
  - "procedures, arguments"
  - "procedures, parameters"
  - "procedure arguments"
  - "arguments [Visual Basic], passing by reference"
  - "Visual Basic code, procedures"
  - "arguments [Visual Basic], ByVal"
  - "arguments [Visual Basic], passing by value"
  - "procedure parameters"
  - "procedures, calling"
  - "arguments [Visual Basic], ByRef"
  - "arguments [Visual Basic], changing value"
ms.assetid: d2b7c766-ce16-4d2c-8d79-3fc0e7ba2227
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Protect a Procedure Argument Against Value Changes (Visual Basic)
If a procedure declares a parameter as [ByRef](../vs140/byref--visual-basic-.md), [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] gives the procedure code a direct reference to the programming element underlying the argument in the calling code. This permits the procedure to change the value underlying the argument in the calling code. In some cases the calling code might want to protect against such a change.  
  
 You can always protect an argument from change by declaring the corresponding parameter [ByVal](../vs140/byval--visual-basic-.md) in the procedure. If you want to be able to change a given argument in some cases but not others, you can declare it `ByRef` and let the calling code determine the passing mechanism in each call. It does this by enclosing the corresponding argument in parentheses to pass it by value, or not enclosing it in parentheses to pass it by reference. For more information, see [How to: Force an Argument to Be Passed by Value](../vs140/how-to--force-an-argument-to-be-passed-by-value--visual-basic-.md).  
  
## Example  
 The following example shows two procedures that take an array variable and operate on its elements. The `increase` procedure simply adds one to each element. The `replace` procedure assigns a new array to the parameter `a()` and then adds one to each element. However, the reassignment does not affect the underlying array variable in the calling code.  
  
 [!code[VbVbcnProcedures#35](../vs140/codesnippet/VisualBasic/how-to--protect-a-procedure-argument-against-value-changes--visual-basic-_1.vb)]  
  
 [!code[VbVbcnProcedures#38](../vs140/codesnippet/VisualBasic/how-to--protect-a-procedure-argument-against-value-changes--visual-basic-_2.vb)]  
  
 [!code[VbVbcnProcedures#37](../vs140/codesnippet/VisualBasic/how-to--protect-a-procedure-argument-against-value-changes--visual-basic-_3.vb)]  
  
 The first `MsgBox` call displays "After increase(n): 11, 21, 31, 41". Because the array `n` is a reference type, `replace` can change its members, even though the passing mechanism is `ByVal`.  
  
 The second `MsgBox` call displays "After replace(n): 11, 21, 31, 41". Because `n` is passed `ByVal`, `replace` cannot modify the variable `n` in the calling code by assigning a new array to it. When `replace` creates the new array instance `k` and assigns it to the local variable `a`, it loses the reference to `n` passed in by the calling code. When it changes the members of `a`, only the local array `k` is affected. Therefore, `replace` does not increment the values of array `n` in the calling code.  
  
## Compiling the Code  
 The default in [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] is to pass arguments by value. However, it is good programming practice to include either the [ByVal](../vs140/byval--visual-basic-.md) or [ByRef](../vs140/byref--visual-basic-.md) keyword with every declared parameter. This makes your code easier to read.  
  
## See Also  
 [Procedures in Visual Basic](../vs140/procedures-in-visual-basic.md)   
 [Procedure Parameters and Arguments](../vs140/procedure-parameters-and-arguments--visual-basic-.md)   
 [How to: Pass Arguments to a Procedure](../vs140/how-to--pass-arguments-to-a-procedure--visual-basic-.md)   
 [Argument Passing By Value and By Reference](../vs140/passing-arguments-by-value-and-by-reference--visual-basic-.md)   
 [Differences Between Variable and Nonvariable Arguments](../vs140/differences-between-modifiable-and-nonmodifiable-arguments--visual-basic-.md)   
 [Differences Between Passing an Argument By Value and By Reference](../vs140/differences-between-passing-an-argument-by-value-and-by-reference--visual-basic-.md)   
 [How to: Change the Value of a Procedure Argument](../vs140/how-to--change-the-value-of-a-procedure-argument--visual-basic-.md)   
 [How to: Force an Argument to Be Passed by Value](../vs140/how-to--force-an-argument-to-be-passed-by-value--visual-basic-.md)   
 [Argument Passing by Position and by Name](../vs140/passing-arguments-by-position-and-by-name--visual-basic-.md)   
 [Value Types and Reference Types](../vs140/value-types-and-reference-types.md)