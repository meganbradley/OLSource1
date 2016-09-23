---
title: "Call Statement (Visual Basic)"
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
  - vb.Call
dev_langs: 
  - VB
helpviewer_keywords: 
  - procedures, Call statement
  - Call statement
  - procedures, calling
ms.assetid: e5b31571-6867-406f-b8e7-a3f9aae4723a
caps.latest.revision: 17
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Call Statement (Visual Basic)
Transfers control to a `Function`, `Sub`, or dynamic-link library (DLL) procedure.  
  
## Syntax  
  
```  
[ Call ] procedureName [ (argumentList) ]  
```  
  
## Parts  
 `procedureName`  
 Required. Name of the procedure to call.  
  
 `argumentList`  
 Optional. List of variables or expressions representing arguments that are passed to the procedure when it is called. Multiple arguments are separated by commas. If you include `argumentList`, you must enclose it in parentheses.  
  
## Remarks  
 You can use the `Call` keyword when you call a procedure. For most procedure calls, you aren’t required to use this  keyword.  
  
 You typically use the `Call` keyword when the called expression doesn’t start with an identifier. Use of the `Call` keyword for other uses isn’t recommended.  
  
 If the procedure returns a value, the `Call` statement discards it.  
  
## Example  
 The following code shows two examples where the `Call` keyword is necessary to call a procedure. In both examples, the called expression doesn't start with an identifier.  
  
 [!code[VbVbalrStatements#97](../vs140/codesnippet/VisualBasic/call-statement--visual-basic-_1.vb)]
  
  
## See Also  
 [Function Statement](../vs140/function-statement--visual-basic-.md)   
 [Sub Statement](../vs140/sub-statement--visual-basic-.md)   
 [Declare Statement](../vs140/declare-statement.md)   
 [Lambda Expressions (Visual Basic)](../vs140/lambda-expressions--visual-basic-.md)