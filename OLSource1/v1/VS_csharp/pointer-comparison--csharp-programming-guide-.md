---
title: "Pointer Comparison (C# Programming Guide)"
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
  - "pointers [C#], comparison"
ms.assetid: fcafd514-7405-4deb-8490-cc58efda5495
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Pointer Comparison (C# Programming Guide)
You can apply the following operators to compare pointers of any type:  
  
 **==   !=   <   >   <=   >=**  
  
 The comparison operators compare the addresses of the two operands as if they are unsigned integers.  
  
## Example  
 [!code[csProgGuidePointers#16](../VS_csharp/codesnippet/CSharp/pointer-comparison--csharp-programming-guide-_1.cs)]  
  
 [!code[csProgGuidePointers#17](../VS_csharp/codesnippet/CSharp/pointer-comparison--csharp-programming-guide-_2.cs)]  
  
## Sample Output  
 `True`  
  
 `False`  
  
## See Also  
 [C# Programming Guide](../VS_csharp/csharp-programming-guide.md)   
 [Pointer Expressions](../VS_csharp/pointer-expressions--csharp-programming-guide-.md)   
 [C# Operators](../VS_csharp/csharp-operators.md)   
 [Manipulating Pointers](../VS_csharp/manipulating-pointers--csharp-programming-guide-.md)   
 [Pointer types](../VS_csharp/pointer-types--csharp-programming-guide-.md)   
 [Types](../VS_csharp/types--csharp-reference-.md)   
 [unsafe](../VS_csharp/unsafe--csharp-reference-.md)   
 [fixed Statement](../VS_csharp/fixed-statement--csharp-reference-.md)   
 [stackalloc](../VS_csharp/stackalloc--csharp-reference-.md)