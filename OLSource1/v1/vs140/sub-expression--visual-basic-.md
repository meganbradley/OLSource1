---
title: "Sub Expression (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "lambda expressions [Visual Basic], sub expression"
  - "Sub Expression [Visual Basic]"
  - "subroutines [Visual Basic], sub expressions"
ms.assetid: 36b6bfd1-6539-4d8f-a5eb-6541a745ffde
caps.latest.revision: 10
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Sub Expression (Visual Basic)
Declares the parameters and code that define a subroutine lambda expression.  
  
## Syntax  
  
```  
Sub ( [ parameterlist ] ) statement  
- or -  
Sub ( [ parameterlist ] )  
  [ statements ]  
End Sub  
  
```  
  
## Parts  
  
|||  
|-|-|  
|Term|Definition|  
|`parameterlist`|Optional. A list of local variable names that represent the parameters of the procedure. The parentheses must be present even when the list is empty. For more information, see [Parameter List](../vs140/parameter-list--visual-basic-.md).|  
|`statement`|Required. A single statement.|  
|`statements`|Required. A list of statements.|  
  
## Remarks  
 A *lambda expression* is a subroutine that does not have a name and that executes one or more statements. You can use a lambda expression anywhere that you can use a delegate type, except as an argument to `RemoveHandler`. For more information about delegates, and the use of lambda expressions with delegates, see [Delegate Statement](../vs140/delegate-statement.md) and [Relaxed Delegate Conversion](../vs140/relaxed-delegate-conversion--visual-basic-.md).  
  
## Lambda Expression Syntax  
 The syntax of a lambda expression resembles that of a standard subroutine. The differences are as follows:  
  
-   A lambda expression does not have a name.  
  
-   A lambda expression cannot have a modifier, such as `Overloads` or `Overrides`.  
  
-   The body of a single-line lambda expression must be a statement, not an expression. The body can consist of a call to a sub procedure, but not a call to a function procedure.  
  
-   In a lambda expression, either all parameters must have specified data types or all parameters must be inferred.  
  
-   Optional and `ParamArray` parameters are not permitted in lambda expressions.  
  
-   Generic parameters are not permitted in lambda expressions.  
  
## Example  
 Following is an example of a lambda expression that writes a value to the console. The example shows both the single-line and multiline lambda expression syntax for a subroutine. For more examples, see [Lambda Expressions](../vs140/lambda-expressions--visual-basic-.md).  
  
 [!code[VbVbalrLambdas#15](../vs140/codesnippet/VisualBasic/sub-expression--visual-basic-_1.vb)]  
  
## See Also  
 [Sub Statement (Visual Basic)](../vs140/sub-statement--visual-basic-.md)   
 [Lambda Expressions](../vs140/lambda-expressions--visual-basic-.md)   
 [Operators and Expressions in Visual Basic](../vs140/operators-and-expressions-in-visual-basic.md)   
 [Statements Overview](../vs140/statements-in-visual-basic.md)   
 [Relaxed Delegate Conversion](../vs140/relaxed-delegate-conversion--visual-basic-.md)