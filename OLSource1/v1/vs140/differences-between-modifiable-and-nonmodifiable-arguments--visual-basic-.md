---
title: "Differences Between Modifiable and Nonmodifiable Arguments (Visual Basic)"
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
  - "procedure arguments"
  - "arguments [Visual Basic], nonmodifiable"
  - "Visual Basic code, procedures"
  - "arguments [Visual Basic], modifiable"
ms.assetid: 87b2df69-e1f7-4657-9caf-b3f48d693428
caps.latest.revision: 20
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Differences Between Modifiable and Nonmodifiable Arguments (Visual Basic)
When you call a procedure, you typically pass one or more arguments to it. Each argument corresponds to an underlying programming element. Both the underlying elements and the arguments themselves can be either modifiable or nonmodifiable.  
  
## Modifiable and Nonmodifiable Elements  
 A programming element can be either a *modifiable element*, which can have its value changed, or a *nonmodifiable element*, which has a fixed value once it has been created.  
  
 The following table lists modifiable and nonmodifiable programming elements.  
  
|Modifiable elements|Nonmodifiable elements|  
|-------------------------|----------------------------|  
|Local variables (declared inside procedures), including object variables, except for read-only|Read-only variables, fields, and properties|  
|Fields (member variables of modules, classes, and structures), except for read-only|Constants and literals|  
|Properties, except for read-only|Enumeration members|  
|Array elements|Expressions (even if their elements are modifiable)|  
  
## Modifiable and Nonmodifiable Arguments  
 A *modifiable argument* is one with a modifiable underlying element. The calling code can store a new value at any time, and if you pass the argument [ByRef](../vs140/byref--visual-basic-.md), the code in the procedure can also modify the underlying element in the calling code.  
  
 A *nonmodifiable argument* either has a nonmodifiable underlying element or is passed [ByVal](../vs140/byval--visual-basic-.md). The procedure cannot modify the underlying element in the calling code, even if it is a modifiable element. If it is a nonmodifiable element, the calling code itself cannot modify it.  
  
 The called procedure might modify its local copy of a nonmodifiable argument, but that modification does not affect the underlying element in the calling code.  
  
## See Also  
 [Procedures in Visual Basic](../vs140/procedures-in-visual-basic.md)   
 [Procedure Parameters and Arguments](../vs140/procedure-parameters-and-arguments--visual-basic-.md)   
 [How to: Pass Arguments to a Procedure](../vs140/how-to--pass-arguments-to-a-procedure--visual-basic-.md)   
 [Argument Passing By Value and By Reference](../vs140/passing-arguments-by-value-and-by-reference--visual-basic-.md)   
 [Differences Between Passing an Argument By Value and By Reference](../vs140/differences-between-passing-an-argument-by-value-and-by-reference--visual-basic-.md)   
 [How to: Change the Value of a Procedure Argument](../vs140/how-to--change-the-value-of-a-procedure-argument--visual-basic-.md)   
 [How to: Protect a Procedure Argument Against Value Changes](../vs140/how-to--protect-a-procedure-argument-against-value-changes--visual-basic-.md)   
 [How to: Force an Argument to Be Passed by Value](../vs140/how-to--force-an-argument-to-be-passed-by-value--visual-basic-.md)   
 [Argument Passing by Position and by Name](../vs140/passing-arguments-by-position-and-by-name--visual-basic-.md)   
 [Value Types and Reference Types](../vs140/value-types-and-reference-types.md)