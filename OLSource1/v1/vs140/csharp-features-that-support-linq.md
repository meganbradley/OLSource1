---
title: "C# Features That Support LINQ"
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
  - "LINQ [C#], features supporting LINQ"
ms.assetid: 524b0078-ebfd-45a7-b390-f2ceb9d84797
caps.latest.revision: 27
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# C# Features That Support LINQ
The following section introduces new language constructs introduced in C# 3.0. Although these new features are all used to a degree with [!INCLUDE[vbteclinq](../vs140/includes/vbteclinq_md.md)] queries, they are not limited to [!INCLUDE[vbteclinq](../vs140/includes/vbteclinq_md.md)] and can be used in any context where you find them useful.  
  
## Query Expressions  
 Queries expressions use a declarative syntax similar to SQL or XQuery to query over IEnumerable collections. At compile time query syntax is converted to method calls to a [!INCLUDE[vbteclinq](../vs140/includes/vbteclinq_md.md)] provider's implementation of the standard query operator extension methods. Applications control the standard query operators that are in scope by specifying the appropriate namespace with a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> directive. The following query expression takes an array of strings, groups them according to the first character in the string, and orders the groups.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 For more information, see [LINQ Query Expressions (C# Programming Guide)](../vs140/linq-query-expressions--csharp-programming-guide-.md).  
  
## Implicitly Typed Variables (var)  
 Instead of explicitly specifying a type when you declare and initialize a variable, you can use the [var](../vs140/var--csharp-reference-.md) modifier to instruct the compiler to infer and assign the type, as shown here:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Variables declared as <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> are just as strongly-typed as variables whose type you specify explicitly. The use of <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> makes it possible to create anonymous types, but it can be used for any local variable. Arrays can also be declared with implicit typing.  
  
 For more information, see [Implicitly Typed Local Variables and Arrays](../vs140/implicitly-typed-local-variables--csharp-programming-guide-.md).  
  
## Object and Collection Initializers  
 Object and collection initializers make it possible to initialize objects without explicitly calling a constructor for the object. Initializers are typically used in query expressions when they project the source data into a new data type. Assuming a class named <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> with public <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> properties, the object initializer can be used as in the following code:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 For more information, see [Object and Collection Initializers (C# Programming Guide)](../vs140/object-and-collection-initializers--csharp-programming-guide-.md).  
  
## Anonymous Types  
 An anonymous type is constructed by the compiler and the type name is only available to the compiler. Anonymous types provide a convenient way to group a set of properties temporarily in a query result without having to define a separate named type. Anonymous types are initialized with a new expression and an object initializer, as shown here:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 For more information, see [Anonymous Types (C# Programming Guide)](../vs140/anonymous-types--csharp-programming-guide-.md).  
  
## Extension Methods  
 An extension method is a static method that can be associated with a type, so that it can be called as if it were an instance method on the type. This feature enables you to, in effect, "add" new methods to existing types without actually modifying them. The standard query operators are a set of extension methods that provide [!INCLUDE[vbteclinq](../vs140/includes/vbteclinq_md.md)] query functionality for any type that implements \<xref:System.Collections.Generic.IEnumerable`1*>.  
  
 For more information, see [Extension Methods (C# Programming Guide)](../vs140/extension-methods--csharp-programming-guide-.md).  
  
## Lambda Expressions  
 A lambda expression is an inline function that uses the => operator to separate input parameters from the function body and can be converted at compile time to a delegate or an expression tree. In [!INCLUDE[vbteclinq](../vs140/includes/vbteclinq_md.md)] programming, you will encounter lambda expressions when you make direct method calls to the standard query operators.  
  
 For more information, see:  
  
-   [Anonymous Functions (C# Programming Guide)](../vs140/anonymous-functions--csharp-programming-guide-.md)  
  
-   [Lambda Expressions (C# Programming Guide)](../vs140/lambda-expressions--csharp-programming-guide-.md)  
  
-   [Expression Trees (C#)](../vs140/expression-trees--csharp-.md)  
  
## Auto-Implemented Properties  
 Auto-implemented properties make property-declaration more concise. When you declare a property as shown in the following example, the compiler will create a private, anonymous backing field that is not accessible except through the property getter and setter.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 For more information, see [Auto-Implemented Properties (C# Programming Guide)](../vs140/auto-implemented-properties--csharp-programming-guide-.md).  
  
## See Also  
 [Language-Integrated Query (LINQ) (C#)](../vs140/language-integrated-query--linq---csharp-.md)