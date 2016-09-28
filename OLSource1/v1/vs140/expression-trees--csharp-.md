---
title: "Expression Trees (C#)"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "CSharp"
ms.assetid: 7d0ac21a-6d90-4e2e-8903-528cb78615b7
caps.latest.revision: 7
author: ""
ms.author: ""
manager: ""
---
# Expression Trees (C#)
Expression trees represent code in a tree-like data structure, where each node is an expression, for example, a method call or a binary operation such as `x < y`.  
  
 You can compile and run code represented by expression trees. This enables dynamic modification of executable code, the execution of LINQ queries in various databases, and the creation of dynamic queries. For more information about expression trees in LINQ, see [How to: Use Expression Trees to Build Dynamic Queries (C#)](../vs140/how-to--use-expression-trees-to-build-dynamic-queries--csharp-.md).  
  
 Expression trees are also used in the dynamic language runtime (DLR) to provide interoperability between dynamic languages and the .NET Framework and to enable compiler writers to emit expression trees instead of Microsoft intermediate language (MSIL). For more information about the DLR, see [Dynamic Language Runtime Overview](assetId:///f769a271-8aff-4bea-bfab-6160217ce23d).  
  
 You can have the C# or Visual Basic compiler create an expression tree for you based on an anonymous lambda expression, or you can create expression trees manually by using the <xref:System.Linq.Expressions*> namespace.  
  
## Creating Expression Trees from Lambda Expressions  
 When a lambda expression is assigned to a variable of type <xref:System.Linq.Expressions.Expression`1*>, the compiler emits code to build an expression tree that represents the lambda expression.  
  
 The C# compiler can generate expression trees only from expression lambdas (or single-line lambdas). It cannot parse statement lambdas (or multi-line lambdas). For more information about lambda expressions in C#, see [Lambda Expressions (C# Programming Guide)](../vs140/lambda-expressions--csharp-programming-guide-.md).  
  
 The following code examples demonstrate how to have the C# compiler create an expression tree that represents the lambda expression `num => num < 5`.  
  
```c#  
Expression<Func<int, bool>> lambda = num => num < 5;  
```  
  
## Creating Expression Trees by Using the API  
 To create expression trees by using the API, use the <xref:System.Linq.Expressions.Expression*> class. This class contains static factory methods that create expression tree nodes of specific types, for example, <xref:System.Linq.Expressions.ParameterExpression*>, which represents a variable or parameter, or <xref:System.Linq.Expressions.MethodCallExpression*>, which represents a method call. <xref:System.Linq.Expressions.ParameterExpression*>, <xref:System.Linq.Expressions.MethodCallExpression*>, and the other expression-specific types are also defined in the <xref:System.Linq.Expressions*> namespace. These types derive from the abstract type <xref:System.Linq.Expressions.Expression*>.  
  
 The following code example demonstrates how to create an expression tree that represents the lambda expression `num => num < 5` by using the API.  
  
```c#  
// Add the following using directive to your code file:  
// using System.Linq.Expressions;  
  
// Manually build the expression tree for   
// the lambda expression num => num < 5.  
ParameterExpression numParam = Expression.Parameter(typeof(int), "num");  
ConstantExpression five = Expression.Constant(5, typeof(int));  
BinaryExpression numLessThanFive = Expression.LessThan(numParam, five);  
Expression<Func<int, bool>> lambda1 =  
    Expression.Lambda<Func<int, bool>>(  
        numLessThanFive,  
        new ParameterExpression[] { numParam });  
```  
  
 In .NET Framework 4 or later, the expression trees API also supports assignments and control flow expressions such as loops, conditional blocks, and `try-catch` blocks. By using the API, you can create expression trees that are more complex than those that can be created from lambda expressions by the C# compiler. The following example demonstrates how to create an expression tree that calculates the factorial of a number.  
  
```c#  
// Creating a parameter expression.  
ParameterExpression value = Expression.Parameter(typeof(int), "value");  
  
// Creating an expression to hold a local variable.   
ParameterExpression result = Expression.Parameter(typeof(int), "result");  
  
// Creating a label to jump to from a loop.  
LabelTarget label = Expression.Label(typeof(int));  
  
// Creating a method body.  
BlockExpression block = Expression.Block(  
    // Adding a local variable.  
    new[] { result },  
    // Assigning a constant to a local variable: result = 1  
    Expression.Assign(result, Expression.Constant(1)),  
    // Adding a loop.  
        Expression.Loop(  
    // Adding a conditional block into the loop.  
           Expression.IfThenElse(  
    // Condition: value > 1  
               Expression.GreaterThan(value, Expression.Constant(1)),  
    // If true: result *= value --  
               Expression.MultiplyAssign(result,  
                   Expression.PostDecrementAssign(value)),  
    // If false, exit the loop and go to the label.  
               Expression.Break(label, result)  
           ),  
    // Label to jump to.  
       label  
    )  
);  
  
// Compile and execute an expression tree.  
int factorial = Expression.Lambda<Func<int, int>>(block, value).Compile()(5);  
  
Console.WriteLine(factorial);  
// Prints 120.  
```  
  
 For more information, see [Generating Dynamic Methods with Expression Trees in Visual Studio 2010 (or later)](http://go.microsoft.com/fwlink/?LinkId=169513).  
  
## Parsing Expression Trees  
 The following code example demonstrates how the expression tree that represents the lambda expression `num => num < 5` can be decomposed into its parts.  
  
```c#  
// Add the following using directive to your code file:  
// using System.Linq.Expressions;  
  
// Create an expression tree.  
Expression<Func<int, bool>> exprTree = num => num < 5;  
  
// Decompose the expression tree.  
ParameterExpression param = (ParameterExpression)exprTree.Parameters[0];  
BinaryExpression operation = (BinaryExpression)exprTree.Body;  
ParameterExpression left = (ParameterExpression)operation.Left;  
ConstantExpression right = (ConstantExpression)operation.Right;  
  
Console.WriteLine("Decomposed expression: {0} => {1} {2} {3}",  
                  param.Name, left.Name, operation.NodeType, right.Value);  
  
// This code produces the following output:  
  
// Decomposed expression: num => num LessThan 5  
```  
  
## Immutability of Expression Trees  
 Expression trees should be immutable. This means that if you want to modify an expression tree, you must construct a new expression tree by copying the existing one and replacing nodes in it. You can use an expression tree visitor to traverse the existing expression tree. For more information, see [How to: Modify Expression Trees (C#)](../vs140/how-to--modify-expression-trees--csharp-.md).  
  
## Compiling Expression Trees  
 The <xref:System.Linq.Expressions.Expression`1*> type provides the <xref:System.Linq.Expressions.Expression`1.Compile*> method that compiles the code represented by an expression tree into an executable delegate.  
  
 The following code example demonstrates how to compile an expression tree and run the resulting code.  
  
```c#  
// Creating an expression tree.  
Expression<Func<int, bool>> expr = num => num < 5;  
  
// Compiling the expression tree into a delegate.  
Func<int, bool> result = expr.Compile();  
  
// Invoking the delegate and writing the result to the console.  
Console.WriteLine(result(4));  
  
// Prints True.  
  
// You can also use simplified syntax  
// to compile and run an expression tree.  
// The following line can replace two previous statements.  
Console.WriteLine(expr.Compile()(4));  
  
// Also prints True.  
```  
  
 For more information, see [How to: Execute Expression Trees (C#)](../vs140/how-to--execute-expression-trees--csharp-.md).  
  
## See Also  
 <xref:System.Linq.Expressions*>   
 [How to: Execute Expression Trees (C#)](../vs140/how-to--execute-expression-trees--csharp-.md)   
 [How to: Modify Expression Trees (C#)](../vs140/how-to--modify-expression-trees--csharp-.md)   
 [Lambda Expressions (C# Programming Guide)](../vs140/lambda-expressions--csharp-programming-guide-.md)   
 [Dynamic Language Runtime Overview](assetId:///f769a271-8aff-4bea-bfab-6160217ce23d)   
 [Programming Concepts (C#)](../vs140/programming-concepts--csharp-.md)