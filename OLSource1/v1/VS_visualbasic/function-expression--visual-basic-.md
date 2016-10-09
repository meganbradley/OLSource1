---
title: "Function Expression (Visual Basic)"
ms.custom: na
ms.date: "10/03/2016"
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
  - "Function expression [Visual Basic]"
  - "functions [Visual Basic], function expressions"
  - "lambda expressions [Visual Basic], function expression"
ms.assetid: e8a47a45-4b8a-4f45-a623-7653625dffbc
caps.latest.revision: 18
ms.author: "shoag"
manager: "wpickett"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
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
|`parameterlist`|Optional. A list of local variable names that represent the parameters of this procedure. The parentheses must be present even when the list is empty. See [Parameter List](../VS_visualbasic/parameter-list--visual-basic-.md).|  
|`expression`|Required. A single expression. The type of the expression is the return type of the function.|  
|`statements`|Required. A list of statements that returns a value by using the `Return` statement. (See [Return Statement](../VS_visualbasic/return-statement--visual-basic-.md).) The type of the value returned is the return type of the function.|  
  
## Remarks  
 A *lambda expression* is a function without a name that calculates and returns a value. You can use a lambda expression anywhere you can use a delegate type, except as an argument to `RemoveHandler`. For more information about delegates, and the use of lambda expressions with delegates, see [Delegate Statement](../VS_visualbasic/delegate-statement.md) and [Relaxed Delegate Conversion](../VS_visualbasic/relaxed-delegate-conversion--visual-basic-.md).  
  
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
  
 [!code[VbVbalrLambdas#1](../VS_visualbasic/codesnippet/VisualBasic/function-expression--visual-basic-_1.vb)]  
  
 [!code[VbVbalrLambdas#2](../VS_visualbasic/codesnippet/VisualBasic/function-expression--visual-basic-_2.vb)]  
  
## Example  
 Alternatively, you can declare and run the function at the same time.  
  
 [!code[VbVbalrLambdas#3](../VS_visualbasic/codesnippet/VisualBasic/function-expression--visual-basic-_3.vb)]  
  
## Example  
 Following is an example of a lambda expression that increments its argument and returns the value. The example shows both the single-line and multiline lambda expression syntax for a function. For more examples, see [Lambda Expressions](../VS_visualbasic/lambda-expressions--visual-basic-.md).  
  
 [!code[VbVbalrLambdas#14](../VS_visualbasic/codesnippet/VisualBasic/function-expression--visual-basic-_4.vb)]  
  
## Example  
 Lambda expressions underlie many of the query operators in [!INCLUDE[vbteclinqext](../VS_visualbasic/includes/vbteclinqext_md.md)], and can be used explicitly in method-based queries. The following example shows a typical [!INCLUDE[vbteclinq](../VS_visualbasic/includes/vbteclinq_md.md)] query, followed by the translation of the query into method format.  
  
```vb#  
Dim londonCusts = From cust In db.Customers  
                       Where cust.City = "London"  
                       Select cust  
  
' This query is compiled to the following code:  
Dim londonCusts = db.Customers.  
                  Where(Function(cust) cust.City = "London").  
                  Select(Function(cust) cust)  
```  
  
 For more information about query methods, see [Queries](../VS_visualbasic/queries--visual-basic-.md). For more information about standard query operators, see [Standard Query Operators Overview](../Topic/Standard%20Query%20Operators%20Overview.md).  
  
## See Also  
 [Function Statement](../VS_visualbasic/function-statement--visual-basic-.md)   
 [Lambda Expressions](../VS_visualbasic/lambda-expressions--visual-basic-.md)   
 [Operators and Expressions](../VS_visualbasic/operators-and-expressions-in-visual-basic.md)   
 [Statements](../VS_visualbasic/statements-in-visual-basic.md)   
 [Value Comparisons](../VS_visualbasic/value-comparisons--visual-basic-.md)   
 [Boolean Expressions](../VS_visualbasic/boolean-expressions--visual-basic-.md)   
 [If Operator](../VS_visualbasic/if-operator--visual-basic-.md)   
 [Relaxed Delegate Conversion](../VS_visualbasic/relaxed-delegate-conversion--visual-basic-.md)