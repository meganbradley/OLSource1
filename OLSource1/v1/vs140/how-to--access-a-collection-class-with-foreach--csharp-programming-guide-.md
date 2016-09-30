---
title: "How to: Access a Collection Class with foreach (C# Programming Guide)"
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
  - "collection classes [C#], foreach statement"
ms.assetid: a6b9cf5c-6c8d-4223-b12c-288949434493
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Access a Collection Class with foreach (C# Programming Guide)
The following code example illustrates how to write a non-generic collection class that can be used with [foreach](../vs140/foreach--in--csharp-reference-.md). The example defines a string tokenizer class.  
  
> [!NOTE]
>  This example represents recommended practice only when you cannot use a generic collection class. For an example of how to implement a type-safe generic collection class that supports <xref:System.Collections.Generic.IEnumerable`1*>, see [Iterators (C# and Visual Basic)](../vs140/iterators--csharp-and-visual-basic-.md).  
  
 In the example, the following code segment uses the `Tokens` class to break the sentence "This is a sample sentence." into tokens by using ' ' and '-' as separators. The code then displays those tokens by using a `foreach` statement.  
  
 [!code[csProgGuideCollections#3](../vs140/codesnippet/CSharp/how-to--access-a-collection-class-with-foreach--csharp-programming-guide-_1.cs)]  
  
## Example  
 Internally, the `Tokens` class uses an array to store the tokens. Because arrays implement <xref:System.Collections.IEnumerator*> and <xref:System.Collections.IEnumerable*>, the code example could have used the array's enumeration methods (<xref:System.Collections.IEnumerable.GetEnumerator*>, <xref:System.Collections.IEnumerator.MoveNext*>, <xref:System.Collections.IEnumerator.Reset*>, and <xref:System.Collections.IEnumerator.Current*>) instead of defining them in the `Tokens` class. The method definitions are included in the example to clarify how they are defined and what each does.  
  
 [!code[csProgGuideCollections#2](../vs140/codesnippet/CSharp/how-to--access-a-collection-class-with-foreach--csharp-programming-guide-_2.cs)]  
  
 In C#, it is not necessary for a collection class to implement <xref:System.Collections.IEnumerable*> and <xref:System.Collections.IEnumerator*> to be compatible with `foreach`. If the class has the required <xref:System.Collections.IEnumerable.GetEnumerator*>, <xref:System.Collections.IEnumerator.MoveNext*>, <xref:System.Collections.IEnumerator.Reset*>, and <xref:System.Collections.IEnumerator.Current*> members, it will work with `foreach`. Omitting the interfaces has the advantage of enabling you to define a return type for `Current` that is more specific than <xref:System.Object*>. This provides type safety.  
  
 For example, change the following lines in the previous example.  
  
<CodeContentPlaceHolder>0</CodeContentPlaceHolder>  
 Because `Current` returns a string, the compiler can detect when an incompatible type is used in a `foreach` statement, as shown in the following code.  
  
<CodeContentPlaceHolder>1</CodeContentPlaceHolder>  
 The disadvantage of omitting <xref:System.Collections.IEnumerable*> and <xref:System.Collections.IEnumerator*> is that the collection class is no longer interoperable with the `foreach` statements, or equivalent statements, of other common language runtime languages.  
  
## See Also  
 \<xref:System.Collections.Generic*>   
 [C# Programmer's Reference](../vs140/csharp-reference.md)   
 [C# Programming](../vs140/csharp-programming-guide.md)   
 [Arrays (Visual C#)](../vs140/arrays--csharp-programming-guide-.md)   
 [Collection Classes (C#)](../vs140/collections--csharp-and-visual-basic-.md)