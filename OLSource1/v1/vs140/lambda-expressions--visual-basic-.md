---
title: "Lambda Expressions (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vb.LambdaFunction"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "functions [Visual Basic], lambda expressions"
  - "lambda expressions [Visual Basic]"
  - "expressions [Visual Basic], lambda"
  - "inline functions [Visual Basic]"
ms.assetid: 137064b0-3928-4bfa-ba71-c3f9cbd951e2
caps.latest.revision: 56
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Lambda Expressions (Visual Basic)
A *lambda expression* is a function or subroutine without a name that can be used wherever a delegate is valid. Lambda expressions can be functions or subroutines and can be single-line or multi-line. You can pass values from the current scope to a lambda expression.  
  
> [!NOTE]
>  The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> statement is an exception. You cannot pass a lambda expression in for the delegate parameter of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 You create lambda expressions by using the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> keyword, just as you create a standard function or subroutine. However, lambda expressions are included in a statement.  
  
 The following example is a lambda expression that increments its argument and returns the value. The example shows both the single-line and multi-line lambda expression syntax for a function.  
  
 [!code[VbVbalrLambdas#14](../vs140/codesnippet/VisualBasic/lambda-expressions--visual-basic-_1.vb)]  
  
 The following example is a lambda expression that writes a value to the console. The example shows both the single-line and multi-line lambda expression syntax for a subroutine.  
  
 [!code[VbVbalrLambdas#15](../vs140/codesnippet/VisualBasic/lambda-expressions--visual-basic-_2.vb)]  
  
 Notice that in the previous examples the lambda expressions are assigned to a variable name. Whenever you refer to the variable, you invoke the lambda expression. You can also declare and invoke a lambda expression at the same time, as shown in the following example.  
  
 [!code[VbVbalrLambdas#3](../vs140/codesnippet/VisualBasic/lambda-expressions--visual-basic-_3.vb)]  
  
 A lambda expression can be returned as the value of a function call (as is shown in the example in the [Context](#context) section later in this topic), or passed in as an argument to a parameter that takes a delegate type, as shown in the following example.  
  
 [!code[VbVbalrLambdas#8](../vs140/codesnippet/VisualBasic/lambda-expressions--visual-basic-_4.vb)]  
  
## Lambda Expression Syntax  
 The syntax of a lambda expression resembles that of a standard function or subroutine. The differences are as follows:  
  
-   A lambda expression does not have a name.  
  
-   Lambda expressions cannot have modifiers, such as <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
-   Single-line lambda functions do not use an <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> clause to designate the return type. Instead, the type is inferred from the value that the body of the lambda expression evaluates to. For example, if the body of the lambda expression is <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, its return type is <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
-   In multi-line lambda functions, you can either specify a return type by using an <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> clause, or omit the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> clause so that the return type is inferred. When the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> clause is omitted for a multi-line lambda function, the return type is inferred to be the dominant type from all the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> statements in the multi-line lambda function. The *dominant type* is a unique type that all other types can widen to. If this unique type cannot be determined, the dominant type is the unique type that all other types in the array can narrow to. If neither of these unique types can be determined, the dominant type is <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>. In this case, if <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, a compiler error occurs.  
  
     For example, if the expressions supplied to the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> statement contain values of type <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, the resulting array is of type <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>. Both <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> widen to <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> and only <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>. Therefore, <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> is the dominant type. For more information, see [Widening and Narrowing Conversions](../vs140/widening-and-narrowing-conversions--visual-basic-.md).  
  
-   The body of a single-line function must be an expression that returns a value, not a statement. There is no <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> statement for single-line functions. The value returned by the single-line function is the value of the expression in the body of the function.  
  
-   The body of a single-line subroutine must be single-line statement.  
  
-   Single-line functions and subroutines do not include an <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> statement.  
  
-   You can specify the data type of a lambda expression parameter by using the <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> keyword, or the data type of the parameter can be inferred. Either all parameters must have specified data types or all must be inferred.  
  
-   <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> parameters are not permitted.  
  
-   Generic parameters are not permitted.  
  
## Async Lambdas  
 You can easily create lambda expressions and statements that incorporate asynchronous processing by using the [Async (Visual Basic)](../vs140/async--visual-basic-.md) and [Await Operator (Visual Basic)](../vs140/await-operator--visual-basic-.md) keywords. For example, the following Windows Forms example contains an event handler that calls and awaits an async method, <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 You can add the same event handler by using an async lambda in an [AddHandler Statement](../vs140/addhandler-statement.md). To add this handler, add an <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> modifier before the lambda parameter list, as the following example shows.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 For more information about how to create and use async methods, see [Asynchronous Programming with Async and Await (C# and Visual Basic)](../vs140/asynchronous-programming-with-async-and-await--csharp-and-visual-basic-.md).  
  
##  \<a name="context">\</a> Context  
 A lambda expression shares its context with the scope within which it is defined. It has the same access rights as any code written in the containing scope. This includes access to member variables, functions and subs, <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>, and parameters and local variables in the containing scope.  
  
 Access to local variables and parameters in the containing scope can extend beyond the lifetime of that scope. As long as a delegate referring to a lambda expression is not available to garbage collection, access to the variables in the original environment is retained. In the following example, variable <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> is local to <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>, the method in which the lambda expression <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> is defined. Note that the returned lambda expression, assigned to <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> in <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>, still has access to the local variable <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>.  
  
 [!code[VbVbalrLambdas#12](../vs140/codesnippet/VisualBasic/lambda-expressions--visual-basic-_5.vb)]  
  
 The following example demonstrates the wide range of access rights of the nested lambda expression. When the returned lambda expression is executed from <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> as <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>, it accesses these elements:  
  
-   A field of the class in which it is defined: <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
  
-   A property of the class in which it is defined: <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
  
-   A parameter of method <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>, in which it is defined: <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
  
-   A local variable of <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>: <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
  
-   A parameter of the lambda expression in which it is nested: <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
  
 [!code[VbVbalrLambdas#9](../vs140/codesnippet/VisualBasic/lambda-expressions--visual-basic-_6.vb)]  
  
## Converting to a Delegate Type  
 A lambda expression can be implicitly converted to a compatible delegate type. For information about the general requirements for compatibility, see [Relaxed Delegate Conversions](../vs140/relaxed-delegate-conversion--visual-basic-.md). For example, the following code example shows a lambda expression that implicitly converts to <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> or a matching delegate signature.  
  
 [!code[VbVbalrLambdas#16](../vs140/codesnippet/VisualBasic/lambda-expressions--visual-basic-_7.vb)]  
  
 The following code example shows a lambda expression that implicitly converts to <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> or a matching delegate signature.  
  
 [!code[VbVbalrLambdas#23](../vs140/codesnippet/VisualBasic/lambda-expressions--visual-basic-_8.vb)]  
  
 When you assign lambda expressions to delegates or pass them as arguments to procedures, you can specify the parameter names but omit their data types, letting the types be taken from the delegate.  
  
## Examples  
  
-   The following example defines a lambda expression that returns <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> if the nullable argument has an assigned value, and <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> if its value is <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>.  
  
     [!code[VbVbalrLambdas#4](../vs140/codesnippet/VisualBasic/lambda-expressions--visual-basic-_9.vb)]  
  
-   The following example defines a lambda expression that returns the index of the last element in an array.  
  
     [!code[VbVbalrLambdas#5](../vs140/codesnippet/VisualBasic/lambda-expressions--visual-basic-_10.vb)]  
  
## See Also  
 [Procedures in Visual Basic](../vs140/procedures-in-visual-basic.md)   
 [Introduction to LINQ in Visual Basic](../vs140/introduction-to-linq-in-visual-basic.md)   
 [Delegates (Visual Basic)](../vs140/delegates--visual-basic-.md)   
 [Function Statement](../vs140/function-statement--visual-basic-.md)   
 [Sub Statement (Visual Basic)](../vs140/sub-statement--visual-basic-.md)   
 [Value Types that Might Not Have a Defined Value](../vs140/nullable-value-types--visual-basic-.md)   
 [How to: Pass Procedures to Another Procedure in Visual Basic](../vs140/how-to--pass-procedures-to-another-procedure-in-visual-basic.md)   
 [How to: Create a Lambda Expression](../vs140/how-to--create-a-lambda-expression--visual-basic-.md)   
 [Relaxed Delegate Conversions](../vs140/relaxed-delegate-conversion--visual-basic-.md)