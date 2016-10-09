---
title: "Pointer Conversions (C# Programming Guide)"
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
  - "pointers [C#], conversions"
ms.assetid: f0e87502-477a-4ede-a31f-7a3e262e46fb
caps.latest.revision: 17
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
  
 [!code[csProgGuidePointers#3](../VS_csharp/codesnippet/CSharp/pointer-conversions--csharp-programming-guide-_1.cs)]  
  
 [!code[csProgGuidePointers#4](../VS_csharp/codesnippet/CSharp/pointer-conversions--csharp-programming-guide-_2.cs)]  
  
## See Also  
 [C# Programming Guide](../VS_csharp/csharp-programming-guide.md)   
 [Pointer Expressions](../VS_csharp/pointer-expressions--csharp-programming-guide-.md)   
 [Pointer types](../VS_csharp/pointer-types--csharp-programming-guide-.md)   
 [Types](../VS_csharp/types--csharp-reference-.md)   
 [unsafe](../VS_csharp/unsafe--csharp-reference-.md)   
 [fixed Statement](../VS_csharp/fixed-statement--csharp-reference-.md)   
 [stackalloc](../VS_csharp/stackalloc--csharp-reference-.md)