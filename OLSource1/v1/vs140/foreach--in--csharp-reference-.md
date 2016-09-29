---
title: "foreach, in (C# Reference)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "foreach"
  - "foreach_CSharpKeyword"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "foreach keyword [C#]"
  - "foreach statement [C#]"
  - "in keyword [C#]"
ms.assetid: 5a9c5ddc-5fd3-457a-9bb6-9abffcd874ec
caps.latest.revision: 33
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# foreach, in (C# Reference)
The `foreach` statement repeats a group of embedded statements for each element in an array or an object collection that implements the <xref:System.Collections.IEnumerable*?displayProperty=fullName> or <xref:System.Collections.Generic.IEnumerable`1*?displayProperty=fullName> interface. The `foreach` statement is used to iterate through the collection to get the information that you want, but can not be used to add or remove items from the source collection to avoid unpredictable side effects. If you need to add or remove items from the source collection, use a [for](../vs140/for--csharp-reference-.md) loop.  
  
 The embedded statements continue to execute for each element in the array or collection. After the iteration has been completed for all the elements in the collection, control is transferred to the next statement following the `foreach` block.  
  
 At any point within the `foreach` block, you can break out of the loop by using the [break](../vs140/break--csharp-reference-.md) keyword, or step to the next iteration in the loop by using the [continue](../vs140/continue--csharp-reference-.md) keyword.  
  
 A `foreach` loop can also be exited by the [goto](../vs140/goto--csharp-reference-.md), [return](../vs140/return--csharp-reference-.md), or [throw](../vs140/throw--csharp-reference-.md) statements.  
  
 For more information about the `foreach` keyword and code samples, see the following topics:  
  
 [Using Foreach with Arrays (Visual C#)](../vs140/using-foreach-with-arrays--csharp-programming-guide-.md)  
  
 [How to: Access a Collection Class with foreach (C#)](../vs140/how-to--access-a-collection-class-with-foreach--csharp-programming-guide-.md)  
  
## Example  
 The following code shows three examples:  
  
-   a typical `foreach` loop that displays the contents of an array of integers  
  
-   a [for](../vs140/for--csharp-reference-.md) loop that does the same thing  
  
-   a `foreach` loop that maintains a count of the number of elements in the array  
  
 [!code[csrefKeywordsIteration#4](../vs140/codesnippet/CSharp/foreach--in--csharp-reference-_1.cs)]  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../vs140/includes/csharplangspec_md.md)]  
  
## See Also  
 [C# Reference](../vs140/csharp-reference.md)   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [C# Keywords](../vs140/csharp-keywords.md)   
 [Iteration Statements](../vs140/iteration-statements--csharp-reference-.md)   
 [for (C# Reference)](../vs140/for--csharp-reference-.md)