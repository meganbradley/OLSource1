---
title: "How to: Increment and Decrement Pointers (C# Programming Guide)"
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
  - "pointers [C#], increment and decrement"
  - "pointer expressions [C#], increment and decrement"
ms.assetid: 1b8b9281-44ee-485a-9045-3db38a4b4b89
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Increment and Decrement Pointers (C# Programming Guide)
Use the increment and the decrement operators, `++` and `--`, to change the pointer location by [sizeof](../VS_csharp/sizeof--csharp-reference-.md) (`pointer-type`) for a pointer of type pointer-type*. The increment and decrement expressions take the following form:  
  
```  
++p;  
p++;  
--p;  
p--;  
```  
  
 The increment and decrement operators can be applied to pointers of any type except the type `void*`.  
  
 The effect of applying the increment operator to a pointer of the type `pointer-type` is to add [sizeof](../VS_csharp/sizeof--csharp-reference-.md) (`pointer-type`) to the address that is contained in the pointer variable.  
  
 The effect of applying the decrement operator to a pointer of the type `pointer-type` is to subtract `sizeof` (`pointer-type`) from the address that is contained in the pointer variable.  
  
 No exceptions are generated when the operation overflows the domain of the pointer, and the result depends on the implementation.  
  
## Example  
 In this example, you step through an array by incrementing the pointer by the size of `int`. With each step, you display the address and the content of the array element.  
  
 [!code[csProgGuidePointers#3](../VS_csharp/codesnippet/CSharp/how-to--increment-and-decrement-pointers--csharp-programming-guide-_1.cs)]  
  
 [!code[csProgGuidePointers#13](../VS_csharp/codesnippet/CSharp/how-to--increment-and-decrement-pointers--csharp-programming-guide-_2.cs)]  
  
 **Value:0 @ Address:12860272**  
**Value:1 @ Address:12860276**  
**Value:2 @ Address:12860280**  
**Value:3 @ Address:12860284**  
**Value:4 @ Address:12860288**   
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