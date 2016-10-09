---
title: "How to: Access a Member with a Pointer (C# Programming Guide)"
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
  - "pointers [C#], member access"
ms.assetid: 1e998498-8c85-4a78-8ce2-4d8c20f08342
caps.latest.revision: 16
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
# How to: Access a Member with a Pointer (C# Programming Guide)
To access a member of a struct that is declared in an unsafe context, you can use the member access operator as shown in the following example in which `p` is a pointer to a [struct](../VS_csharp/struct--csharp-reference-.md) that contains a member `x`.  
  
```  
CoOrds* p = &home;  
p -> x = 25; //member access operator ->  
```  
  
## Example  
 In this example, a [struct](../VS_csharp/struct--csharp-reference-.md), `CoOrds`, that contains the two coordinates `x` and `y` is declared and instantiated. By using the member access operator `->` and a pointer to the instance `home`, `x` and `y` are assigned values.  
  
> [!NOTE]
>  Notice that the expression `p->x` is equivalent to the expression `(*p).x`, and you can obtain the same result by using either of the two expressions.  
  
 [!code[csProgGuidePointers#9](../VS_csharp/codesnippet/CSharp/how-to--access-a-member-with-a-pointer--csharp-programming-guide-_1.cs)]  
  
 [!code[csProgGuidePointers#10](../VS_csharp/codesnippet/CSharp/how-to--access-a-member-with-a-pointer--csharp-programming-guide-_2.cs)]  
  
## See Also  
 [C# Programming Guide](../VS_csharp/csharp-programming-guide.md)   
 [Pointer Expressions](../VS_csharp/pointer-expressions--csharp-programming-guide-.md)   
 [Pointer types](../VS_csharp/pointer-types--csharp-programming-guide-.md)   
 [Types](../VS_csharp/types--csharp-reference-.md)   
 [unsafe](../VS_csharp/unsafe--csharp-reference-.md)   
 [fixed Statement](../VS_csharp/fixed-statement--csharp-reference-.md)   
 [stackalloc](../VS_csharp/stackalloc--csharp-reference-.md)