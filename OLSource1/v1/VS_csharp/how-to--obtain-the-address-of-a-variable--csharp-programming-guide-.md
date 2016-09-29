---
title: "How to: Obtain the Address of a Variable (C# Programming Guide)"
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
  - "variables [C#], address of"
  - "pointers [C#], & operator"
  - "pointer expressions [C#], address-of operator"
ms.assetid: 44fe2cd9-a64f-4ef5-be2a-09ce807c0182
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Obtain the Address of a Variable (C# Programming Guide)
To obtain the address of a unary expression, which evaluates to a fixed variable, use the address-of operator:  
  
```  
int number;  
int* p = &number; //address-of operator &  
```  
  
 The address-of operator can only be applied to a variable. If the variable is a moveable variable, you can use the [fixed statement](../VS_csharp/fixed-statement--csharp-reference-.md) to temporarily fix the variable before obtaining its address.  
  
 It is your responsibility to ensure that the variable is initialized. The compiler will not issue an error message if the variable is not initialized.  
  
 You cannot get the address of a constant or a value.  
  
## Example  
 In this example, a pointer to `int`, `p`, is declared and assigned the address of an integer variable, `number`. The variable `number` is initialized as a result of the assignment to *p. If you make this assignment statement a comment, the initialization of the variable `number` will be removed, but no compile-time error is issued. Notice the use of the [Member Access](../VS_csharp/how-to--access-a-member-with-a-pointer--csharp-programming-guide-.md) operator `->` to obtain and display the address stored in the pointer.  
  
 [!code[csProgGuidePointers#7](../VS_csharp/codesnippet/CSharp/how-to--obtain-the-address-of-a-variable--csharp-programming-guide-_1.cs)]  
  
 [!code[csProgGuidePointers#8](../VS_csharp/codesnippet/CSharp/how-to--obtain-the-address-of-a-variable--csharp-programming-guide-_2.cs)]  
  
## See Also  
 [C# Programming Guide](../VS_csharp/csharp-programming-guide.md)   
 [Pointer Expressions](../VS_csharp/pointer-expressions--csharp-programming-guide-.md)   
 [Pointer types](../VS_csharp/pointer-types--csharp-programming-guide-.md)   
 [Types](../VS_csharp/types--csharp-reference-.md)   
 [unsafe](../VS_csharp/unsafe--csharp-reference-.md)   
 [fixed Statement](../VS_csharp/fixed-statement--csharp-reference-.md)   
 [stackalloc](../VS_csharp/stackalloc--csharp-reference-.md)