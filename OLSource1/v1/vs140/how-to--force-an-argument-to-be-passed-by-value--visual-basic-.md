---
title: "How to: Force an Argument to Be Passed by Value (Visual Basic)"
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
  - "Visual Basic code, procedures"
  - "arguments [Visual Basic], ByVal"
  - "arguments [Visual Basic], passing by value"
  - "procedure parameters"
  - "procedures, calling"
  - "arguments [Visual Basic], in parentheses"
  - "procedure arguments, in parentheses"
  - "arguments [Visual Basic], changing value"
ms.assetid: 77b4f2d2-1055-4c2f-a521-874d1db86946
caps.latest.revision: 20
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Force an Argument to Be Passed by Value (Visual Basic)
The procedure declaration determines the passing mechanism. If a parameter is declared [ByRef](../vs140/byref--visual-basic-.md), [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] expects to pass the corresponding argument by reference. This allows the procedure to change the value of the programming element underlying the argument in the calling code. If you wish to protect the underlying element against such change, you can override the `ByRef` passing mechanism in the procedure call by enclosing the argument name in parentheses. These parentheses are in addition to the parentheses enclosing the argument list in the call.  
  
 The calling code cannot override a [ByVal](../vs140/byval--visual-basic-.md) mechanism.  
  
### To force an argument to be passed by value  
  
-   If the corresponding parameter is declared `ByVal` in the procedure, you do not need to take any additional steps. [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] already expects to pass the argument by value.  
  
-   If the corresponding parameter is declared `ByRef` in the procedure, enclose the argument in parentheses in the procedure call.  
  
## Example  
 The following example overrides a `ByRef` parameter declaration. In the call that forces `ByVal`, note the two levels of parentheses.  
  
 [!code[VbVbcnProcedures#39](../vs140/codesnippet/VisualBasic/how-to--force-an-argument-to-be-passed-by-value--visual-basic-_1.vb)]  
  
 [!code[VbVbcnProcedures#40](../vs140/codesnippet/VisualBasic/how-to--force-an-argument-to-be-passed-by-value--visual-basic-_2.vb)]  
  
 When `str` is enclosed in extra parentheses within the argument list, the `setNewString` procedure cannot change its value in the calling code, and `MsgBox` displays "Cannot be replaced if passed ByVal". When `str` is not enclosed in extra parentheses, the procedure can change it, and `MsgBox` displays "This is a new value for the inString argument."  
  
## Compiling the Code  
 When you pass a variable by reference, you must use the `ByRef` keyword to specify this mechanism.  
  
 The default in [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] is to pass arguments by value. However, it is good programming practice to include either the [ByVal](../vs140/byval--visual-basic-.md) or [ByRef](../vs140/byref--visual-basic-.md) keyword with every declared parameter. This makes your code easier to read.  
  
## Robust Programming  
 If a procedure declares a parameter [ByRef](../vs140/byref--visual-basic-.md), the correct execution of the code might depend on being able to change the underlying element in the calling code. If the calling code overrides this calling mechanism by enclosing the argument in parentheses, or if it passes a nonmodifiable argument, the procedure cannot change the underlying element. This might produce unexpected results in the calling code.  
  
## .NET Framework Security  
 There is always a potential risk in allowing a procedure to change the value underlying an argument in the calling code. Make sure you expect this value to be changed, and be prepared to check it for validity before using it.  
  
## See Also  
 [Procedures in Visual Basic](../vs140/procedures-in-visual-basic.md)   
 [Procedure Parameters and Arguments](../vs140/procedure-parameters-and-arguments--visual-basic-.md)   
 [How to: Pass Arguments to a Procedure](../vs140/how-to--pass-arguments-to-a-procedure--visual-basic-.md)   
 [Argument Passing By Value and By Reference](../vs140/passing-arguments-by-value-and-by-reference--visual-basic-.md)   
 [Differences Between Modifiable and Nonmodifiable Arguments](../vs140/differences-between-modifiable-and-nonmodifiable-arguments--visual-basic-.md)   
 [Differences Between Passing an Argument By Value and By Reference](../vs140/differences-between-passing-an-argument-by-value-and-by-reference--visual-basic-.md)   
 [How to: Change the Value of a Procedure Argument](../vs140/how-to--change-the-value-of-a-procedure-argument--visual-basic-.md)   
 [How to: Protect a Procedure Argument Against Value Changes](../vs140/how-to--protect-a-procedure-argument-against-value-changes--visual-basic-.md)   
 [Argument Passing by Position and by Name](../vs140/passing-arguments-by-position-and-by-name--visual-basic-.md)   
 [Value Types and Reference Types](../vs140/value-types-and-reference-types.md)