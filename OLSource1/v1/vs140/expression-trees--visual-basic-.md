---
title: "Expression Trees (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
ms.assetid: 8bbbb02d-7ffc-476b-8c25-118d82bf5d46
caps.latest.revision: 3
---
# Expression Trees (Visual Basic)
Expression trees represent code in a tree-like data structure, where each node is an expression, for example, a method call or a binary operation such as `x < y`.  
  
 You can compile and run code represented by expression trees. This enables dynamic modification of executable code, the execution of LINQ queries in various databases, and the creation of dynamic queries. For more information about expression trees in LINQ, see [How to: Use Expression Trees to Build Dynamic Queries (Visual Basic)](../vs140/how-to--use-expression-trees-to-build-dynamic-queries--visual-basic-.md).  
  
 Expression trees are also used in the dynamic language runtime (DLR) to provide interoperability between dynamic languages and the .NET Framework and to enable compiler writers to emit expression trees instead of Microsoft intermediate language (MSIL). For more information about the DLR, see [Dynamic Language Runtime Overview](assetId:///f769a271-8aff-4bea-bfab-6160217ce23d).  
  
 You can have the C# or Visual Basic compiler create an expression tree for you based on an anonymous lambda expression, or you can create expression trees manually by using the <xref:System.Linq.Expressions*> namespace.  
  
## Creating Expression Trees from Lambda Expressions  
 When a lambda expression is assigned to a variable of type <xref:System.Linq.Expressions.Expression`1*>, the compiler emits code to build an expression tree that represents the lambda expression.  
  
 The Visual Basic compiler can generate expression trees only from expression lambdas (or single-line lambdas). It cannot parse statement lambdas (or multi-line lambdas). For more information about lambda expressions in Visual Basic, see [Lambda Expressions](../vs140/lambda-expressions--visual-basic-.md).  
  
 The following code examples demonstrate how to have the Visual Basic compiler create an expression tree that represents the lambda expression `Function(num) num < 5`.  
  
<CodeContentPlaceHolder>0</CodeContentPlaceHolder>  
## Creating Expression Trees by Using the API  
 To create expression trees by using the API, use the <xref:System.Linq.Expressions.Expression*> class. This class contains static factory methods that create expression tree nodes of specific types, for example, <xref:System.Linq.Expressions.ParameterExpression*>, which represents a variable or parameter, or <xref:System.Linq.Expressions.MethodCallExpression*>, which represents a method call. <xref:System.Linq.Expressions.ParameterExpression*>, <xref:System.Linq.Expressions.MethodCallExpression*>, and the other expression-specific types are also defined in the <xref:System.Linq.Expressions*> namespace. These types derive from the abstract type <xref:System.Linq.Expressions.Expression*>.  
  
 The following code example demonstrates how to create an expression tree that represents the lambda expression `Function(num) num < 5` by using the API.  
  
<CodeContentPlaceHolder>1</CodeContentPlaceHolder>  
 In .NET Framework 4 or later, the expression trees API also supports assignments and control flow expressions such as loops, conditional blocks, and `try-catch` blocks. By using the API, you can create expression trees that are more complex than those that can be created from lambda expressions by the Visual Basic compiler. The following example demonstrates how to create an expression tree that calculates the factorial of a number.  
  
<CodeContentPlaceHolder>2</CodeContentPlaceHolder>  
 For more information, see [Generating Dynamic Methods with Expression Trees in Visual Studio 2010 (or later)](http://go.microsoft.com/fwlink/?LinkId=169513).  
  
## Parsing Expression Trees  
 The following code example demonstrates how the expression tree that represents the lambda expression `Function(num) num < 5` can be decomposed into its parts.  
  
<CodeContentPlaceHolder>3</CodeContentPlaceHolder>  
## Immutability of Expression Trees  
 Expression trees should be immutable. This means that if you want to modify an expression tree, you must construct a new expression tree by copying the existing one and replacing nodes in it. You can use an expression tree visitor to traverse the existing expression tree. For more information, see [How to: Modify Expression Trees (Visual Basic)](../vs140/how-to--modify-expression-trees--visual-basic-.md).  
  
## Compiling Expression Trees  
 The <xref:System.Linq.Expressions.Expression`1*> type provides the <xref:System.Linq.Expressions.Expression`1.Compile*> method that compiles the code represented by an expression tree into an executable delegate.  
  
 The following code example demonstrates how to compile an expression tree and run the resulting code.  
  
```vb  
' Creating an expression tree.  
Dim expr As Expression(Of Func(Of Integer, Boolean)) =  
    Function(num) num < 5  
  
' Compiling the expression tree into a delegate.  
Dim result As Func(Of Integer, Boolean) = expr.Compile()  
  
' Invoking the delegate and writing the result to the console.  
Console.WriteLine(result(4))  
  
' Prints True.  
  
' You can also use simplified syntax  
' to compile and run an expression tree.  
' The following line can replace two previous statements.  
Console.WriteLine(expr.Compile()(4))  
  
' Also prints True.  
```  
  
 For more information, see [How to: Execute Expression Trees (Visual Basic)](../vs140/how-to--execute-expression-trees--visual-basic-.md).  
  
## See Also  
 <xref:System.Linq.Expressions*>   
 [How to: Execute Expression Trees (Visual Basic)](../vs140/how-to--execute-expression-trees--visual-basic-.md)   
 [How to: Modify Expression Trees (Visual Basic)](../vs140/how-to--modify-expression-trees--visual-basic-.md)   
 [Lambda Expressions (Visual Basic)](../vs140/lambda-expressions--visual-basic-.md)   
 [Dynamic Language Runtime Overview](assetId:///f769a271-8aff-4bea-bfab-6160217ce23d)   
 [Programming Concepts (Visual Basic)](../vs140/programming-concepts--visual-basic-.md)