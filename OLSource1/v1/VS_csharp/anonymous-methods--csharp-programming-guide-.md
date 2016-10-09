---
title: "Anonymous Methods (C# Programming Guide)"
ms.custom: na
ms.date: "10/03/2016"
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
  - "anonymous methods [C#]"
  - "methods [C#], anonymous"
  - "delegates [C#], anonymous methods"
ms.assetid: a62441fa-f0a3-4acb-9aa6-93762a635275
caps.latest.revision: 31
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
# Anonymous Methods (C# Programming Guide)
In versions of C# before 2.0, the only way to declare a [delegate](../VS_csharp/delegate--csharp-reference-.md) was to use [named methods](../VS_csharp/delegates-with-named-vs.-anonymous-methods--csharp-programming-guide-.md). C# 2.0 introduced anonymous methods and in C# 3.0 and later, lambda expressions supersede anonymous methods as the preferred way to write inline code. However, the information about anonymous methods in this topic also applies to lambda expressions. There is one case in which an anonymous method provides functionality not found in lambda expressions. Anonymous methods enable you to omit the parameter list. This means that an anonymous method can be converted to delegates with a variety of signatures. This is not possible with lambda expressions. For more information specifically about lambda expressions, see [Lambda Expressions](../VS_csharp/lambda-expressions--csharp-programming-guide-.md).  
  
 Creating anonymous methods is essentially a way to pass a code block as a delegate parameter. Here are two examples:  
  
 [!code[csProgGuideDelegates#6](../VS_csharp/codesnippet/CSharp/anonymous-methods--csharp-programming-guide-_1.cs)]  
  
 [!code[csProgGuideDelegates#5](../VS_csharp/codesnippet/CSharp/anonymous-methods--csharp-programming-guide-_2.cs)]  
  
 By using anonymous methods, you reduce the coding overhead in instantiating delegates because you do not have to create a separate method.  
  
 For example, specifying a code block instead of a delegate can be useful in a situation when having to create a method might seem an unnecessary overhead. A good example would be when you start a new thread. This class creates a thread and also contains the code that the thread executes without creating an additional method for the delegate.  
  
 [!code[csProgGuideDelegates#7](../VS_csharp/codesnippet/CSharp/anonymous-methods--csharp-programming-guide-_3.cs)]  
  
## Remarks  
 The scope of the parameters of an anonymous method is the *anonymous-method-block*.  
  
 It is an error to have a jump statement, such as [goto](../VS_csharp/goto--csharp-reference-.md), [break](../VS_csharp/break--csharp-reference-.md), or [continue](../VS_csharp/continue--csharp-reference-.md), inside the anonymous method block if the target is outside the block. It is also an error to have a jump statement, such as `goto`, `break`, or `continue`, outside the anonymous method block if the target is inside the block.  
  
 The local variables and parameters whose scope contains an anonymous method declaration are called *outer* variables of the anonymous method. For example, in the following code segment, `n` is an outer variable:  
  
 [!code[csProgGuideDelegates#8](../VS_csharp/codesnippet/CSharp/anonymous-methods--csharp-programming-guide-_4.cs)]  
  
 A reference to the outer variable `n` is said to be *captured* when the delegate is created. Unlike local variables, the lifetime of a captured variable extends until the delegates that reference the anonymous methods are eligible for garbage collection.  
  
 An anonymous method cannot access the [ref](../VS_csharp/ref--csharp-reference-.md) or [out](../VS_csharp/out--csharp-reference-.md) parameters of an outer scope.  
  
 No unsafe code can be accessed within the *anonymous-method-block*.  
  
 Anonymous methods are not allowed on the left side of the [is](../VS_csharp/is--csharp-reference-.md) operator.  
  
## Example  
 The following example demonstrates two ways of instantiating a delegate:  
  
-   Associating the delegate with an anonymous method.  
  
-   Associating the delegate with a named method (`DoWork`).  
  
 In each case, a message is displayed when the delegate is invoked.  
  
 [!code[csProgGuideDelegates#4](../VS_csharp/codesnippet/CSharp/anonymous-methods--csharp-programming-guide-_5.cs)]  
  
## See Also  
 [C# Reference](../VS_csharp/csharp-reference.md)   
 [C# Programming Guide](../VS_csharp/csharp-programming-guide.md)   
 [Delegates](../VS_csharp/delegates--csharp-programming-guide-.md)   
 [Lambda Expressions](../VS_csharp/lambda-expressions--csharp-programming-guide-.md)   
 [Unsafe Code and Pointers](../VS_csharp/unsafe-code-and-pointers--csharp-programming-guide-.md)   
 [Methods](../VS_csharp/methods--csharp-programming-guide-.md)   
 [Delegates with Named vs. Anonymous Methods](../VS_csharp/delegates-with-named-vs.-anonymous-methods--csharp-programming-guide-.md)