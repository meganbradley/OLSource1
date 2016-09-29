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
 [!code[csProgGuidePointers#16](../vs140/codesnippet/CSharp/pointer-comparison--csharp-programming-guide-_1.cs)]  
  
 [!code[csProgGuidePointers#17](../vs140/codesnippet/CSharp/pointer-comparison--csharp-programming-guide-_2.cs)]  
  
## Sample Output  
 `True`  
  
 `False`  
  
## See Also  
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [Pointer Expressions](../vs140/pointer-expressions--csharp-programming-guide-.md)   
 [C# Operators](../vs140/csharp-operators.md)   
 [Manipulating Pointers](../vs140/manipulating-pointers--csharp-programming-guide-.md)   
 [Pointer types](../vs140/pointer-types--csharp-programming-guide-.md)   
 [Types](../vs140/types--csharp-reference-.md)   
 [unsafe](../vs140/unsafe--csharp-reference-.md)   
 [fixed Statement](../vs140/fixed-statement--csharp-reference-.md)   
 [stackalloc](../vs140/stackalloc--csharp-reference-.md)