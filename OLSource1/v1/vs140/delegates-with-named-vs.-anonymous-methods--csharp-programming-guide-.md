---
title: "Delegates with Named vs. Anonymous Methods (C# Programming Guide)"
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
  - "delegates [C#], with named vs. anonymous methods"
  - "methods [C#], in delegates"
ms.assetid: 98fa8c61-66b6-4146-986c-3236c4045733
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Delegates with Named vs. Anonymous Methods (C# Programming Guide)
A [delegate](../vs140/delegate--csharp-reference-.md) can be associated with a named method. When you instantiate a delegate by using a named method, the method is passed as a parameter, for example:  
  
 [!code[csProgGuideDelegates#1](../vs140/codesnippet/CSharp/delegates-with-named-vs.-anonymous-methods--csharp-programming-guide-_1.cs)]  
  
 This is called using a named method. Delegates constructed with a named method can encapsulate either a [static](../vs140/static--csharp-reference-.md) method or an instance method. Named methods are the only way to instantiate a delegate in earlier versions of C#. However, in a situation where creating a new method is unwanted overhead, C# enables you to instantiate a delegate and immediately specify a code block that the delegate will process when it is called. The block can contain either a lambda expression or an anonymous method. For more information, see [Anonymous Functions (C# Programming Guide)](../vs140/anonymous-functions--csharp-programming-guide-.md).  
  
## Remarks  
 The method that you pass as a delegate parameter must have the same signature as the delegate declaration.  
  
 A delegate instance may encapsulate either static or instance method.  
  
 Although the delegate can use an [out](../vs140/out--csharp-reference-.md) parameter, we do not recommend its use with multicast event delegates because you cannot know which delegate will be called.  
  
## Example 1  
 The following is a simple example of declaring and using a delegate. Notice that both the delegate, `Del`, and the associated method, `MultiplyNumbers`, have the same signature  
  
 [!code[csProgGuideDelegates#2](../vs140/codesnippet/CSharp/delegates-with-named-vs.-anonymous-methods--csharp-programming-guide-_2.cs)]  
  
## Example 2  
 In the following example, one delegate is mapped to both static and instance methods and returns specific information from each.  
  
 [!code[csProgGuideDelegates#3](../vs140/codesnippet/CSharp/delegates-with-named-vs.-anonymous-methods--csharp-programming-guide-_3.cs)]  
  
## See Also  
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [Delegates (Visual C#)](../vs140/delegates--csharp-programming-guide-.md)   
 [Anonymous Methods (C# Programming Guide)](../vs140/anonymous-methods--csharp-programming-guide-.md)   
 [How to: Combine Delegates (Multicast Delegates)(C# Programming Guide)](../vs140/how-to--combine-delegates--multicast-delegates--csharp-programming-guide-.md)   
 [Events (C# Programming Guide)](../vs140/events--csharp-programming-guide-.md)