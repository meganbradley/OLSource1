---
title: "Visual Basic Features That Support LINQ"
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
  - "Visual Basic, LINQ features"
  - "LINQ [Visual Basic], features supporting LINQ"
ms.assetid: c821bb50-b6f6-4cf9-8aba-2717e465bd3a
caps.latest.revision: 51
ms.author: "shoag"
manager: "wpickett"
translation.priority.ht: 
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "ru-ru"
  - "zh-cn"
  - "zh-tw"
translation.priority.mt: 
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---
# Visual Basic Features That Support LINQ
The name [!INCLUDE[vbteclinqext](../VS_visualbasic/includes/vbteclinqext_md.md)] refers to technology in Visual Basic that supports query syntax and other language constructs directly in the language. With [!INCLUDE[vbteclinq](../VS_visualbasic/includes/vbteclinq_md.md)], you do not have to learn a new language to query against an external data source. You can query against data in relational databases, XML stores, or objects by using Visual Basic. This integration of query capabilities into the language enables compile-time checking for syntax errors and type safety. This integration also ensures that you already know most of what you have to know to write rich, varied queries in Visual Basic.  
  
 The following sections describe the language constructs that support LINQ in enough detail to enable you to get started in reading the introductory documentation, code examples, and sample applications. You can also click the links to find more detailed explanations of how the language features come together to enable language-integrated query. A good place to start is [Walkthrough: Writing Queries in Visual Basic](../VS_visualbasic/walkthrough--writing-queries-in-visual-basic.md).  
  
## Query Expressions  
 Query expressions in Visual Basic can be expressed in a declarative syntax similar to that of SQL or XQuery. At compile time, query syntax is converted into method calls to a LINQ provider's implementation of the standard query operator extension methods. Applications control which standard query operators are in scope by specifying the appropriate namespace with an `Imports` statement. Syntax for a Visual Basic query expression looks like this:  
  
 [!code[VbLINQVbFeatures#1](../VS_visualbasic/codesnippet/VisualBasic/visual-basic-features-that-support-linq_1.vb)]  
  
 For more information, see [Introduction to LINQ in Visual Basic](../VS_visualbasic/introduction-to-linq-in-visual-basic.md).  
  
## Implicitly Typed Variables  
 Instead of explicitly specifying a type when you declare and initialize a variable, you can enable the compiler to infer and assign the type. This is referred to as *local type inference*.  
  
 Variables whose types are inferred are strongly typed, just like variables whose type you specify explicitly. Local type inference works only when you are defining a local variable inside a method body. For more information, see [Option Infer Statement](../VS_visualbasic/option-infer-statement.md) and [Local Type Inference](../VS_visualbasic/local-type-inference--visual-basic-.md).  
  
 The following example illustrates local type inference. To use this example, you must set `Option Infer` to `On`.  
  
 [!code[VbLINQVbFeatures#2](../VS_visualbasic/codesnippet/VisualBasic/visual-basic-features-that-support-linq_2.vb)]  
  
 Local type inference also makes it possible to create anonymous types, which are described later in this section and are necessary for LINQ queries.  
  
 In the following LINQ example, type inference occurs if `Option Infer` is either `On` or `Off`. A compile-time error occurs if `Option Infer` is `Off` and `Option Strict` is `On`.  
  
 [!code[VbLINQVbFeatures#3](../VS_visualbasic/codesnippet/VisualBasic/visual-basic-features-that-support-linq_3.vb)]  
  
## Object Initializers  
 Object initializers are used in query expressions when you have to create an anonymous type to hold the results of a query. They also can be used to initialize objects of named types outside of queries. By using an object initializer, you can initialize an object in a single line without explicitly calling a constructor. Assuming that you have a class named `Customer` that has public `Name` and `Phone` properties, along with other properties, an object initializer can be used in this manner:  
  
 [!code[VbLINQVbFeatures#4](../VS_visualbasic/codesnippet/VisualBasic/visual-basic-features-that-support-linq_4.vb)]  
  
 For more information, see [Object Initializers: Named and Anonymous Types](../VS_visualbasic/object-initializers--named-and-anonymous-types--visual-basic-.md).  
  
## Anonymous Types  
 Anonymous types provide a convenient way to temporarily group a set of properties into an element that you want to include in a query result. This enables you to choose any combination of available fields in the query, in any order, without defining a named data type for the element.  
  
 An *anonymous type* is constructed dynamically by the compiler. The name of the type is assigned by the compiler, and it might change with each new compilation. Therefore, the name cannot be used directly. Anonymous types are initialized in the following way:  
  
 [!code[VbLINQVbFeatures#5](../VS_visualbasic/codesnippet/VisualBasic/visual-basic-features-that-support-linq_5.vb)]  
  
 For more information, see [Anonymous Types](../VS_visualbasic/anonymous-types--visual-basic-.md).  
  
## Extension Methods  
 Extension methods enable you to add methods to a data type or interface from outside the definition. This feature enables you to, in effect, add new methods to an existing type without actually modifying the type. The standard query operators are themselves a set of extension methods that provide [!INCLUDE[vbteclinq](../VS_visualbasic/includes/vbteclinq_md.md)] query functionality for any type that implements <xref:System.Collections.Generic.IEnumerable`1>. Other extensions to <xref:System.Collections.Generic.IEnumerable`1> include \<xref:System.Linq.Enumerable.Count*>, \<xref:System.Linq.Enumerable.Union*>, and \<xref:System.Linq.Enumerable.Intersect*>.  
  
 The following extension method adds a print method to the \<xref:System.String> class.  
  
 [!code[VbLINQVbFeatures#6](../VS_visualbasic/codesnippet/VisualBasic/visual-basic-features-that-support-linq_6.vb)]  
  
 The method is called like an ordinary instance method of \<xref:System.String>:  
  
 [!code[VbLINQVbFeatures#7](../VS_visualbasic/codesnippet/VisualBasic/visual-basic-features-that-support-linq_7.vb)]  
  
 For more information, see [Extension Methods](../VS_visualbasic/extension-methods--visual-basic-.md).  
  
## Lambda Expressions  
 A lambda expression is a function without a name that calculates and returns a single value. Unlike named functions, a lambda expression can be defined and executed at the same time. The following example displays 4.  
  
 [!code[VbLINQVbFeatures#8](../VS_visualbasic/codesnippet/VisualBasic/visual-basic-features-that-support-linq_8.vb)]  
  
 You can assign the lambda expression definition to a variable name and then use the name to call the function. The following example also displays 4.  
  
 [!code[VbLINQVbFeatures#12](../VS_visualbasic/codesnippet/VisualBasic/visual-basic-features-that-support-linq_9.vb)]  
  
 In [!INCLUDE[vbteclinq](../VS_visualbasic/includes/vbteclinq_md.md)], lambda expressions underlie many of the standard query operators. The compiler creates lambda expressions to capture the calculations that are defined in fundamental query methods such as `Where`, `Select`, `Order By`, `Take While`, and others.  
  
 For example, the following code defines a query that returns all senior students from a list of students.  
  
 [!code[VbLINQVbFeatures#9](../VS_visualbasic/codesnippet/VisualBasic/visual-basic-features-that-support-linq_10.vb)]  
  
 The query definition is compiled into code that is similar to the following example, which uses two lambda expressions to specify the arguments for `Where` and `Select`.  
  
 [!code[VbLINQVbFeatures#10](../VS_visualbasic/codesnippet/VisualBasic/visual-basic-features-that-support-linq_11.vb)]  
  
 Either version can be run by using a `For Each` loop:  
  
 [!code[VbLINQVbFeatures#11](../VS_visualbasic/codesnippet/VisualBasic/visual-basic-features-that-support-linq_12.vb)]  
  
 For more information, see [Lambda Expressions](../VS_visualbasic/lambda-expressions--visual-basic-.md).  
  
## See Also  
 [Language-Integrated Query (LINQ) (Visual Basic)](../VS_visualbasic/language-integrated-query--linq---visual-basic-.md)   
 [Getting Started with LINQ in Visual Basic](../VS_visualbasic/getting-started-with-linq-in-visual-basic.md)   
 [LINQ and Strings (Visual Basic)](../VS_visualbasic/linq-and-strings--visual-basic-.md)   
 [Option Infer Statement](../VS_visualbasic/option-infer-statement.md)   
 [Option Strict Statement](../VS_visualbasic/option-strict-statement.md)