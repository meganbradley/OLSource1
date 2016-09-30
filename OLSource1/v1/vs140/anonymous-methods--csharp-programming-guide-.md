---
title: "Anonymous Methods (C# Programming Guide)"
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
  - "anonymous methods [C#]"
  - "methods [C#], anonymous"
  - "delegates [C#], anonymous methods"
ms.assetid: a62441fa-f0a3-4acb-9aa6-93762a635275
caps.latest.revision: 35
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Anonymous Methods (C# Programming Guide)
In versions of C# before 2.0, the only way to declare a [delegate](../vs140/delegate--csharp-reference-.md) was to use [named methods](../vs140/delegates-with-named-vs.-anonymous-methods--csharp-programming-guide-.md). C# 2.0 introduced anonymous methods and in C# 3.0 and later, lambda expressions supersede anonymous methods as the preferred way to write inline code. However, the information about anonymous methods in this topic also applies to lambda expressions. There is one case in which an anonymous method provides functionality not found in lambda expressions. Anonymous methods enable you to omit the parameter list. This means that an anonymous method can be converted to delegates with a variety of signatures. This is not possible with lambda expressions. For more information specifically about lambda expressions, see [Lambda Expressions (C# Programming Guide)](../vs140/lambda-expressions--csharp-programming-guide-.md).  
  
 Creating anonymous methods is essentially a way to pass a code block as a delegate parameter. Here are two examples:  
  
 [!code[csProgGuideDelegates#6](../vs140/codesnippet/CSharp/anonymous-methods--csharp-programming-guide-_1.cs)]  
  
 [!code[csProgGuideDelegates#5](../vs140/codesnippet/CSharp/anonymous-methods--csharp-programming-guide-_2.cs)]  
  
 By using anonymous methods, you reduce the coding overhead in instantiating delegates because you do not have to create a separate method.  
  
 For example, specifying a code block instead of a delegate can be useful in a situation when having to create a method might seem an unnecessary overhead. A good example would be when you start a new thread. This class creates a thread and also contains the code that the thread executes without creating an additional method for the delegate.  
  
 [!code[csProgGuideDelegates#7](../vs140/codesnippet/CSharp/anonymous-methods--csharp-programming-guide-_3.cs)]  
  
## Remarks  
 The scope of the parameters of an anonymous method is the *anonymous-method-block*.  
  
 It is an error to have a jump statement, such as [goto](../vs140/goto--csharp-reference-.md), [break](../vs140/break--csharp-reference-.md), or [continue](../vs140/continue--csharp-reference-.md), inside the anonymous method block if the target is outside the block. It is also an error to have a jump statement, such as <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, outside the anonymous method block if the target is inside the block.  
  
 The local variables and parameters whose scope contains an anonymous method declaration are called *outer* variables of the anonymous method. For example, in the following code segment, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is an outer variable:  
  
 [!code[csProgGuideDelegates#8](../vs140/codesnippet/CSharp/anonymous-methods--csharp-programming-guide-_4.cs)]  
  
 A reference to the outer variable <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is said to be *captured* when the delegate is created. Unlike local variables, the lifetime of a captured variable extends until the delegates that reference the anonymous methods are eligible for garbage collection.  
  
 An anonymous method cannot access the [ref](../vs140/ref--csharp-reference-.md) or [out](../vs140/out--csharp-reference-.md) parameters of an outer scope.  
  
 No unsafe code can be accessed within the *anonymous-method-block*.  
  
 Anonymous methods are not allowed on the left side of the [is](../vs140/is--csharp-reference-.md) operator.  
  
## Example  
 The following example demonstrates two ways of instantiating a delegate:  
  
-   Associating the delegate with an anonymous method.  
  
-   Associating the delegate with a named method (<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>).  
  
 In each case, a message is displayed when the delegate is invoked.  
  
 [!code[csProgGuideDelegates#4](../vs140/codesnippet/CSharp/anonymous-methods--csharp-programming-guide-_5.cs)]  
  
## See Also  
 [C# Programmer's Reference](../vs140/csharp-reference.md)   
 [C# Programming](../vs140/csharp-programming-guide.md)   
 [Delegates (Visual C#)](../vs140/delegates--csharp-programming-guide-.md)   
 [Lambda Expressions (C# Programming Guide)](../vs140/lambda-expressions--csharp-programming-guide-.md)   
 [Unsafe Code and Pointers (C# Programming Guide)](../vs140/unsafe-code-and-pointers--csharp-programming-guide-.md)   
 [Methods (C# Programming Guide)](../vs140/methods--csharp-programming-guide-.md)   
 [Named Methods (C# Programming Guide)](../vs140/delegates-with-named-vs.-anonymous-methods--csharp-programming-guide-.md)