---
title: "How to: Group Results by Contiguous Keys (C# Programming Guide)"
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
  - "contiguous keys [LINQ in C#]"
ms.assetid: 0f0f48a8-e13b-4274-8903-3b73f68cd18e
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Group Results by Contiguous Keys (C# Programming Guide)
The following example shows how to group elements into chunks that represent subsequences of contiguous keys. For example, assume that you are given the following sequence of key-value pairs:  
  
|Key|Value|  
|---------|-----------|  
|A|We|  
|A|think|  
|A|that|  
|B|Linq|  
|C|is|  
|A|really|  
|B|cool|  
|B|!|  
  
 The following groups will be created in this order:  
  
1.  We, think, that  
  
2.  Linq  
  
3.  is  
  
4.  really  
  
5.  cool, !  
  
 The solution is implemented as an extension method that is thread-safe and that returns its results in a streaming manner. In other words, it produces its groups as it moves through the source sequence. Unlike the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> operators, it can begin returning groups to the caller before all of the sequence has been read.  
  
 Thread-safety is accomplished by making a copy of each group or chunk as the source sequence is iterated, as explained in the source code comments. If the source sequence has a large sequence of contiguous items, the common language runtime may throw an \<xref:System.OutOfMemoryException*>.  
  
## Example  
 The following example shows both the extension method and the client code that uses it.  
  
 [!code[cscsrefContiguousGroups#1](../vs140/codesnippet/CSharp/how-to--group-results-by-contiguous-keys--csharp-programming-guide-_1.cs)]  
  
 To use the extension method in your project, copy the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> static class to a new or existing source code file and if it is required, add a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> directive for the namespace where it is located.  
  
## See Also  
 [LINQ Query Expressions (C# Programming Guide)](../vs140/linq-query-expressions--csharp-programming-guide-.md)   
 [Classification of Standard Query Operators by Manner of Execution](../vs140/classification-of-standard-query-operators-by-manner-of-execution.md)