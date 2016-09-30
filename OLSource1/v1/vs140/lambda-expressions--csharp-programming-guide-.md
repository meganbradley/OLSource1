---
title: "Lambda Expressions (C# Programming Guide)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "lambda expressions [C#]"
  - "outer variables [C#]"
  - "statement lambda [C#]"
  - "expression lambda [C#]"
  - "expressions [C#], lambda"
ms.assetid: 57e3ba27-9a82-4067-aca7-5ca446b7bf93
caps.latest.revision: 68
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Lambda Expressions (C# Programming Guide)
A lambda expression is an [anonymous function](../vs140/anonymous-methods--csharp-programming-guide-.md) that you can use to create [delegates](../vs140/using-delegates--csharp-programming-guide-.md) or [expression tree](../vs140/expression-trees--csharp-and-visual-basic-.md) types. By using lambda expressions, you can write local functions that can be passed as arguments or returned as the value of function calls. Lambda expressions are particularly helpful for writing LINQ query expressions.  
  
 To create a lambda expression, you specify input parameters (if any) on the left side of the lambda operator [=>](../vs140/=--operator--csharp-reference-.md), and you put the expression or statement block on the other side. For example, the lambda expression <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> specifies a parameter that’s named <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> and returns the value of <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> squared. You can assign this expression to a delegate type, as the following example shows:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 To create an expression tree type:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> operator has the same precedence as assignment (<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>) and is [right associative](../vs140/operators--csharp-programming-guide-.md) (see “Associativity” section of the Operators article).  
  
 Lambdas are used in method-based [!INCLUDE[vbteclinq](../vs140/includes/vbteclinq_md.md)] queries as arguments to standard query operator methods such as \<xref:System.Linq.Enumerable.Where*>.  
  
 When you use method-based syntax to call the \<xref:System.Linq.Enumerable.Where*> method in the \<xref:System.Linq.Enumerable*> class (as you do in [!INCLUDE[vbteclinq](../vs140/includes/vbteclinq_md.md)] to Objects and [!INCLUDE[sqltecxlinq](../vs140/includes/sqltecxlinq_md.md)]) the parameter is a delegate type <xref:System.Func<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>Where<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>int<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>int<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>x<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>int<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>ExampleMethodAsync<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>async<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>2*> family of generic delegates. These delegates use type parameters to define the number and types of input parameters, and the return type of the delegate. <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> delegates are very useful for encapsulating user-defined expressions that are applied to each element in a set of source data. For example, consider the following delegate type:  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 The delegate can be instantiated as <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> where <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> is an input parameter and <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> is the return value. The return value is always specified in the last type parameter. <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> defines a delegate with two input parameters, <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>, and a return type of <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>. The following <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> delegate, when it is invoked, will return true or false to indicate whether the input parameter is equal to 5:  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 You can also supply a lambda expression when the argument type is an <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>, for example in the standard query operators that are defined in System.Linq.Queryable. When you specify an <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> argument, the lambda will be compiled to an expression tree.  
  
 A standard query operator, the \<xref:System.Linq.Enumerable.Count*> method, is shown here:  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 The compiler can infer the type of the input parameter, or you can also specify it explicitly. This particular lambda expression counts those integers (<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>) which when divided by two have a remainder of 1.  
  
 The following line of code produces a sequence that contains all elements in the <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> array that are to the left side of the 9 because that's the first number in the sequence that doesn't meet the condition:  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 This example shows how to specify multiple input parameters by enclosing them in parentheses. The method returns all the elements in the numbers array until a number is encountered whose value is less than its position. Do not confuse the lambda operator (<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>) with the greater than or equal operator (<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>).  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
## Type Inference in Lambdas  
 When writing lambdas, you often do not have to specify a type for the input parameters because the compiler can infer the type based on the lambda body, the parameter’s delegate type, and other factors as described in the C# Language Specification. For most of the standard query operators, the first input is the type of the elements in the source sequence. So if you are querying an <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>, then the input variable is inferred to be a <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> object, which means you have access to its methods and properties:  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 The general rules for lambdas are as follows:  
  
-   The lambda must contain the same number of parameters as the delegate type.  
  
-   Each input parameter in the lambda must be implicitly convertible to its corresponding delegate parameter.  
  
-   The return value of the lambda (if any) must be implicitly convertible to the delegate's return type.  
  
 Note that lambda expressions in themselves do not have a type because the common type system has no intrinsic concept of "lambda expression." However, it is sometimes convenient to speak informally of the "type" of a lambda expression. In these cases the type refers to the delegate type or \<xref:System.Linq.Expressions.Expression*> type to which the lambda expression is converted.  
  
## Variable Scope in Lambda Expressions  
 Lambdas can refer to *outer variables* (see [Anonymous Methods (C# Programming Guide)](../vs140/anonymous-methods--csharp-programming-guide-.md)) that are in scope in the method that defines the lambda function, or in scope in the type that contains the lambda expression. Variables that are captured in this manner are stored for use in the lambda expression even if the variables would otherwise go out of scope and be garbage collected. An outer variable must be definitely assigned before it can be consumed in a lambda expression. The following example demonstrates these rules:  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 The following rules apply to variable scope in lambda expressions:  
  
-   A variable that is captured will not be garbage-collected until the delegate that references it becomes eligible for garbage collection.  
  
-   Variables introduced within a lambda expression are not visible in the outer method.  
  
-   A lambda expression cannot directly capture a <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> parameter from an enclosing method.  
  
-   A return statement in a lambda expression does not cause the enclosing method to return.  
  
-   A lambda expression cannot contain a <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> statement, <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> statement, or <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> statement that is inside the lambda function if the jump statement’s target is outside the block. It is also an error to have a jump statement outside the lambda function block if the target is inside the block.  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../vs140/includes/csharplangspec_md.md)]  
  
## Featured Book Chapter  
 [Delegates, Events, and Lambda Expressions](http://go.microsoft.com/fwlink/?LinkId=195395) in [C# 3.0 Cookbook, Third Edition: More than 250 solutions for C# 3.0 programmers](http://go.microsoft.com/fwlink/?LinkId=195369)  
  
## See Also  
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [Language-Integrated Query (LINQ)](../vs140/linq--language-integrated-query-.md)   
 [Anonymous Methods (C# Programming Guide)](../vs140/anonymous-methods--csharp-programming-guide-.md)   
 [is (C# Reference)](../vs140/is--csharp-reference-.md)   
 [Expression Trees](../vs140/expression-trees--csharp-and-visual-basic-.md)   
 [Visual Studio 2008 C# Samples (see LINQ Sample Queries files and XQuery program)](http://code.msdn.microsoft.com/Visual-Studio-2008-C-d295cdba)   
 [Recursive lambda expressions](http://go.microsoft.com/fwlink/?LinkId=112395)