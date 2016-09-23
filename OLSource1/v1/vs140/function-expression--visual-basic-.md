---
title: "Function Expression (Visual Basic)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-visual-basic
ms.tgt_pltfrm: na
ms.topic: article
dev_langs: 
  - VB
helpviewer_keywords: 
  - Function expression [Visual Basic]
  - functions [Visual Basic], function expressions
  - lambda expressions [Visual Basic], function expression
ms.assetid: e8a47a45-4b8a-4f45-a623-7653625dffbc
caps.latest.revision: 22
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Function Expression (Visual Basic)
Declares the parameters and code that define a function lambda expression.  
  
## Syntax  
  
```  
Function ( [ parameterlist ] ) expression  
- or -  
Function ( [ parameterlist ] )  
  [ statements ]  
End Function  
  
```  
  
## Parts  
  
|||  
|-|-|  
|Term|Definition|  
|`parameterlist`|Optional. A list of local variable names that represent the parameters of this procedure. The parentheses must be present even when the list is empty. See [Parameter List](../vs140/parameter-list--visual-basic-.md).|  
|`expression`|Required. A single expression. The type of the expression is the return type of the function.|  
|`statements`|Required. A list of statements that returns a value by using the `Return` statement. (See [Return Statement (Visual Basic)](../vs140/return-statement--visual-basic-.md).) The type of the value returned is the return type of the function.|  
  
## Remarks  
 A *lambda expression* is a function without a name that calculates and returns a value. You can use a lambda expression anywhere you can use a delegate type, except as an argument to `RemoveHandler`. For more information about delegates, and the use of lambda expressions with delegates, see [Delegate Statement](../vs140/delegate-statement.md) and [Relaxed Delegate Conversion](../vs140/relaxed-delegate-conversion--visual-basic-.md).  
  
## Lambda Expression Syntax  
 The syntax of a lambda expression resembles that of a standard function. The differences are as follows:  
  
-   A lambda expression does not have a name.  
  
-   Lambda expressions cannot have modifiers, such as `Overloads` or `Overrides`.  
  
-   Lambda expressions do not use an `As` clause to designate the return type of the function. Instead, the type is inferred from the value that the body of a single-line lambda expression evaluates to, or the return value of a multiline lambda expression. For example, if the body of a single-line lambda expression is `Where cust.City = "London"`, its return type is `Boolean`.  
  
-   The body of a single-line lambda expression must be an expression, not a statement. The body can consist of a call to a function procedure, but not a call to a sub procedure.  
  
-   Either all parameters must have specified data types or all must be inferred.  
  
-   Optional and Paramarray parameters are not permitted.  
  
-   Generic parameters are not permitted.  
  
## Example  
 The following examples show two ways to create simple lambda expressions. The first uses a `Dim` to provide a name for the function. To call the function, you send in a value for the parameter.  
  
 [!code[VbVbalrLambdas#1](../vs140/codesnippet/VisualBasic/function-expression--visual-basic-_1.vb)]
  
  
 [!code[VbVbalrLambdas#2](../vs140/codesnippet/VisualBasic/function-expression--visual-basic-_2.vb)]
  
  
## Example  
 Alternatively, you can declare and run the function at the same time.  
  
 [!code[VbVbalrLambdas#3](../vs140/codesnippet/VisualBasic/function-expression--visual-basic-_3.vb)]
  
  
## Example  
 Following is an example of a lambda expression that increments its argument and returns the value. The example shows both the single-line and multiline lambda expression syntax for a function. For more examples, see [Lambda Expressions](../vs140/lambda-expressions--visual-basic-.md).  
  
 [!code[VbVbalrLambdas#14](../vs140/codesnippet/VisualBasic/function-expression--visual-basic-_4.vb)]
  
  
## Example  
 Lambda expressions underlie many of the query operators in [!INCLUDE[vbteclinqext](../vs140/includes/vbteclinqext_md.md)], and can be used explicitly in method-based queries. The following example shows a typical [!INCLUDE[vbteclinq](../vs140/includes/vbteclinq_md.md)] query, followed by the translation of the query into method format.  
  
```vb#  
Dim londonCusts = From cust In db.Customers  
                       Where cust.City = "London"  
                       Select cust  
  
' This query is compiled to the following code:  
Dim londonCusts = db.Customers.  
                  Where(Function(cust) cust.City = "London").  
                  Select(Function(cust) cust)  
```  
  
 For more information about query methods, see [Queries (Visual Basic)](../vs140/queries--visual-basic-.md). For more information about standard query operators, see [Standard Query Operators Overview](../vs140/standard-query-operators-overview.md).  
  
## See Also  
 [Function Statement (Visual Basic)](../vs140/function-statement--visual-basic-.md)   
 [Lambda Expressions](../vs140/lambda-expressions--visual-basic-.md)   
 [Operators and Expressions in Visual Basic](../vs140/operators-and-expressions-in-visual-basic.md)   
 [Statements Overview](../vs140/statements-in-visual-basic.md)   
 [Value Comparisons](../vs140/value-comparisons--visual-basic-.md)   
 [Boolean Expressions](../vs140/boolean-expressions--visual-basic-.md)   
 [If Operator](../vs140/if-operator--visual-basic-.md)   
 [Relaxed Delegate Conversion](../vs140/relaxed-delegate-conversion--visual-basic-.md)