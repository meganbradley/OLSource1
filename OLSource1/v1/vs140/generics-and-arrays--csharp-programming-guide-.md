---
title: "Generics and Arrays (C# Programming Guide)"
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
  - "generics [C#], arrays"
  - "arrays [C#], generics"
ms.assetid: 7d956536-3851-41b5-94ad-3e7c0a5fe485
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Generics and Arrays (C# Programming Guide)
In C# 2.0 and later, single-dimensional arrays that have a lower bound of zero automatically implement <xref:System.Collections.Generic.IList<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>1*> interface cannot be used to add or remove elements from an array. An exception will be thrown if you try to call an <xref:System.Collections.Generic.IList<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>1.RemoveAt*> on an array in this context.  
  
 The following code example demonstrates how a single generic method that takes an \<xref:System.Collections.Generic.IList`1*> input parameter can iterate through both a list and an array, in this case an array of integers.  
  
 [!code[csProgGuideGenerics#35](../vs140/codesnippet/CSharp/generics-and-arrays--csharp-programming-guide-_1.cs)]  
  
## See Also  
 \<xref:System.Collections.Generic*>   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [Generics (C# Programmer's Reference)](../vs140/generics--csharp-programming-guide-.md)   
 [Arrays (C# Programmer's Reference)](../vs140/arrays--csharp-programming-guide-.md)   
 [Generics in the .NET Framework](assetId:///2994d786-c5c7-4666-ab23-4c83129fe39c)