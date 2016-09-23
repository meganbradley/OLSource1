---
title: "Expressions (C# Programming Guide)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
dev_langs: 
  - CSharp
helpviewer_keywords: 
  - expressions [C#]
  - C# language, expressions
ms.assetid: c7d8feb0-0e58-4f94-8bf6-4d070550a832
caps.latest.revision: 26
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Expressions (C# Programming Guide)
An *expression* is a sequence of one or more operands and zero or more operators that can be evaluated to a single value, object, method, or namespace. Expressions can consist of a literal value, a method invocation, an operator and its operands, or a *simple name*. Simple names can be the name of a variable, type member, method parameter, namespace or type.  
  
 Expressions can use operators that in turn use other expressions as parameters, or method calls whose parameters are in turn other method calls, so expressions can range from simple to very complex. Following are two examples of expressions:  
  
```  
((x < 10) && ( x > 5)) || ((x > 20) && (x < 25))   
System.Convert.ToInt32("35")  
```  
  
## Expression Values  
 In most of the contexts in which expressions are used, for example in statements or method parameters, the expression is expected to evaluate to some value. If x and y are integers, the expression `x + y` evaluates to a numeric value. The expression `new MyClass()` evaluates to a reference to a new instance of a `MyClass` object. The expression `myClass.ToString()` evaluates to a string because that is the return type of the method. However, although a namespace name is classified as an expression, it does not evaluate to a value and therefore can never be the final result of any expression. You cannot pass a namespace name to a method parameter, or use it in a new expression, or assign it to a variable. You can only use it as a sub-expression in a larger expression. The same is true for types (as distinct from <xref:System.Type?qualifyHint=True> objects), method group names (as distinct from specific methods), and event [add](../vs140/add--csharp-reference-.md) and [remove](../vs140/remove--csharp-reference-.md) accessors.  
  
 Every value has an associated type. For example, if x and y are both variables of type `int`, the value of the expression `x + y` is also typed as `int`. If the value is assigned to a variable of a different type, or if x and y are different types, the rules of type conversion are applied. For more information about how such conversions work, see [Casting and Type Conversions (C# Programming Guide)](../vs140/casting-and-type-conversions--csharp-programming-guide-.md).  
  
## Overflows  
 Numeric expressions may cause overflows if the value is larger than the maximum value of the value's type. For more information, see [Checked and Unchecked (C# Reference)](../vs140/checked-and-unchecked--csharp-reference-.md) and [Explicit Numeric Conversions Table (C# Reference)](../vs140/explicit-numeric-conversions-table--csharp-reference-.md).  
  
## Operator Precedence and Associativity  
 The manner in which an expression is evaluated is governed by the rules of associativity and operator precedence. For more information, see [Operators (C# Programming Guide)](../vs140/operators--csharp-programming-guide-.md).  
  
 Most expressions, except assignment expressions and method invocation expressions, must be embedded in a statement. For more information, see [Statements (C# Programming Guide)](../vs140/statements--csharp-programming-guide-.md).  
  
## Literals and Simple Names  
 The two simplest types of expressions are literals and simple names. A literal is a constant value that has no name. For example, in the following code example, both `5` and `"Hello World"` are literal values:  
  
 [!code[csProgGuideStatements#2](../vs140/codesnippet/CSharp/expressions--csharp-programming-guide-_1.cs)]
  
  
 For more information on literals, see [Types (C# Programmer's Reference)](../vs140/types--csharp-reference-.md).  
  
 In the preceding example, both `i` and `s` are simple names that identify local variables. When those variables are used in an expression, the variable name evaluates to the value that is currently stored in the variable's location in memory. This is shown in the following example:  
  
 [!code[csProgGuideStatements#3](../vs140/codesnippet/CSharp/expressions--csharp-programming-guide-_2.cs)]
  
  
## Invocation Expressions  
 In the following code example, the call to `DoWork` is an invocation expression.  
  
```  
DoWork();  
```  
  
 A method invocation requires the name of the method, either as a name as in the previous example, or as the result of another expression, followed by parenthesis and any method parameters. For more information, see [Class Methods (Visual C#)](../vs140/methods--csharp-programming-guide-.md). A delegate invocation uses the name of a delegate and method parameters in parenthesis. For more information, see [Delegates (Visual C#)](../vs140/delegates--csharp-programming-guide-.md). Method invocations and delegate invocations evaluate to the return value of the method, if the method returns a value. Methods that return void cannot be used in place of a value in an expression.  
  
## Query Expressions  
 The same rules for expressions in general apply to query expressions. For more information, see [LINQ Query Expressions (C# Programming Guide)](../vs140/linq-query-expressions--csharp-programming-guide-.md).  
  
## Lambda Expressions  
 Lambda expressions represent "inline methods" that have no name but can have input parameters and multiple statements. They are used extensively in LINQ to pass arguments to methods. Lambda expressions are compiled to either delegates or expression trees depending on the context in which they are used. For more information, see [Lambda Expressions (C# Programming Guide)](../vs140/lambda-expressions--csharp-programming-guide-.md).  
  
## Expression Trees  
 Expression trees enable expressions to be represented as data structures. They are used extensively by LINQ providers to translate query expressions into code that is meaningful in some other context, such as a SQL database. For more information, see [Expression Trees](../vs140/expression-trees--csharp-and-visual-basic-.md).  
  
## Remarks  
 Whenever a variable, object property, or object indexer access is identified from an expression, the value of that item is used as the value of the expression. An expression can be placed anywhere in C# where a value or object is required, as long as the expression ultimately evaluates to the required type.  
  
## Featured Book Chapter  
 [Variables and Expressions](http://go.microsoft.com/fwlink/?LinkId=221228) in [Beginning Visual C# 2010](http://go.microsoft.com/fwlink/?LinkId=221214)  
  
## See Also  
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [Class Methods (Visual C#)](../vs140/methods--csharp-programming-guide-.md)   
 [Delegates (Visual C#)](../vs140/delegates--csharp-programming-guide-.md)   
 [Operators (Visual C#)](../vs140/operators--csharp-programming-guide-.md)   
 [Data Types (C# Programming Guide)](../vs140/types--csharp-programming-guide-.md)   
 [LINQ Query Expressions (C# Programming Guide)](../vs140/linq-query-expressions--csharp-programming-guide-.md)