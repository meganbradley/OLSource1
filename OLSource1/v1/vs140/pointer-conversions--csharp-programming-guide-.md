---
title: "Pointer Conversions (C# Programming Guide)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
dev_langs: 
  - CSharp
helpviewer_keywords: 
  - pointers [C#], conversions
ms.assetid: f0e87502-477a-4ede-a31f-7a3e262e46fb
caps.latest.revision: 21
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Pointer Conversions (C# Programming Guide)
The following table shows the predefined implicit pointer conversions. Implicit conversions might occur in many situations, including method invoking and assignment statements.  
  
## Implicit pointer conversions  
  
|From|To|  
|----------|--------|  
|Any pointer type|void*|  
|null|Any pointer type|  
  
 Explicit pointer conversion is used to perform conversions, for which there is no implicit conversion, by using a cast expression. The following table shows these conversions.  
  
## Explicit pointer conversions  
  
|From|To|  
|----------|--------|  
|Any pointer type|Any other pointer type|  
|sbyte, byte, short, ushort, int, uint, long, or ulong|Any pointer type|  
|Any pointer type|sbyte, byte, short, ushort, int, uint, long, or ulong|  
  
## Example  
 In the following example, a pointer to `int` is converted to a pointer to `byte`. Notice that the pointer points to the lowest addressed byte of the variable. When you successively increment the result, up to the size of `int` (4 bytes), you can display the remaining bytes of the variable.  
  
 [!code[csProgGuidePointers#3](../vs140/codesnippet/CSharp/pointer-conversions--csharp-programming-guide-_1.cs)]
  
  
 [!code[csProgGuidePointers#4](../vs140/codesnippet/CSharp/pointer-conversions--csharp-programming-guide-_2.cs)]
  
  
## See Also  
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [Pointer Expressions](../vs140/pointer-expressions--csharp-programming-guide-.md)   
 [Pointer types](../vs140/pointer-types--csharp-programming-guide-.md)   
 [Types](../vs140/types--csharp-reference-.md)   
 [unsafe](../vs140/unsafe--csharp-reference-.md)   
 [fixed Statement](../vs140/fixed-statement--csharp-reference-.md)   
 [stackalloc](../vs140/stackalloc--csharp-reference-.md)