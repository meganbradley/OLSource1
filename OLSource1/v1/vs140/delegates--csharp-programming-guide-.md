---
title: "Delegates (C# Programming Guide)"
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
  - "C# language, delegates"
  - "delegates [C#]"
ms.assetid: 97de039b-c76b-4b9c-a27d-8c1e1c8d93da
caps.latest.revision: 34
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Delegates (C# Programming Guide)
A [delegate](../vs140/delegate--csharp-reference-.md) is a type that represents references to methods with a particular parameter list and return type. When you instantiate a delegate, you can associate its instance with any method with a compatible signature and return type. You can invoke (or call) the method through the delegate instance.  
  
 Delegates are used to pass methods as arguments to other methods. Event handlers are nothing more than methods that are invoked through delegates. You create a custom method, and a class such as a windows control can call your method when a certain event occurs. The following example shows a delegate declaration:  
  
 [!code[csProgGuideDelegates#20](../vs140/codesnippet/CSharp/delegates--csharp-programming-guide-_1.cs)]  
  
 Any method from any accessible class or struct that matches the delegate type can be assigned to the delegate. The method can be either static or an instance method. This makes it possible to programmatically change method calls, and also plug new code into existing classes.  
  
> [!NOTE]
>  In the context of method overloading, the signature of a method does not include the return value. But in the context of delegates, the signature does include the return value. In other words, a method must have the same return type as the delegate.  
  
 This ability to refer to a method as a parameter makes delegates ideal for defining callback methods. For example, a reference to a method that compares two objects could be passed as an argument to a sort algorithm. Because the comparison code is in a separate procedure, the sort algorithm can be written in a more general way.  
  
## Delegates Overview  
 Delegates have the following properties:  
  
-   Delegates are like C++ function pointers but are type safe.  
  
-   Delegates allow methods to be passed as parameters.  
  
-   Delegates can be used to define callback methods.  
  
-   Delegates can be chained together; for example, multiple methods can be called on a single event.  
  
-   Methods do not have to match the delegate type exactly. For more information, see [Covariance and Contravariance in Delegates](../vs140/using-variance-in-delegates--csharp-and-visual-basic-.md).  
  
-   C# version 2.0 introduced the concept of [Anonymous Methods](../vs140/anonymous-methods--csharp-programming-guide-.md), which allow code blocks to be passed as parameters in place of a separately defined method. C# 3.0 introduced lambda expressions as a more concise way of writing inline code blocks. Both anonymous methods and lambda expressions (in certain contexts) are compiled to delegate types. Together, these features are now known as anonymous functions. For more information about lambda expressions, see [Anonymous Functions (C# Programming Guide)](../vs140/anonymous-functions--csharp-programming-guide-.md).  
  
## In This Section  
  
-   [Overview of Delegates](../vs140/using-delegates--csharp-programming-guide-.md)  
  
-   [When to Use Delegates Instead of Interfaces (C# Programming Guide)](assetId:///2e759bdf-7ca4-4005-8597-af92edf6d8f0)  
  
-   [Named Methods](../vs140/delegates-with-named-vs.-anonymous-methods--csharp-programming-guide-.md)  
  
-   [Anonymous Methods](../vs140/anonymous-methods--csharp-programming-guide-.md)  
  
-   [Covariance and Contravariance](../vs140/using-variance-in-delegates--csharp-and-visual-basic-.md)  
  
-   [How to: Combine Delegates](../vs140/how-to--combine-delegates--multicast-delegates--csharp-programming-guide-.md)  
  
-   [How to: Declare, Instantiate, and Use a Delegate](../vs140/how-to--declare--instantiate--and-use-a-delegate--csharp-programming-guide-.md)  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../vs140/includes/csharplangspec_md.md)]  
  
## Featured Book Chapters  
 [Delegates, Events, and Lambda Expressions](http://go.microsoft.com/fwlink/?LinkId=195395) in [C# 3.0 Cookbook, Third Edition: More than 250 solutions for C# 3.0 programmers](http://go.microsoft.com/fwlink/?LinkId=195369)  
  
 [Delegates and Events](http://go.microsoft.com/fwlink/?LinkId=195418) in [Learning C# 3.0: Master the fundamentals of C# 3.0](http://go.microsoft.com/fwlink/?LinkId=195412)  
  
## See Also  
 <xref:System.Delegate*>   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [Events (C#)](../vs140/events--csharp-programming-guide-.md)