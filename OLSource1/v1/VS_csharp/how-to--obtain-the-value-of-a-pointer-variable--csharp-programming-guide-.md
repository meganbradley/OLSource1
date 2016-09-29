---
title: "How to: Obtain the Value of a Pointer Variable (C# Programming Guide)"
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
  - "pointer expressions [C#], indirection"
  - "pointers [C#], indirection"
  - "variables [C#], pointers"
  - "pointers [C#], * operator"
ms.assetid: 460a813a-4995-44c1-9de2-213b91dc7668
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Obtain the Value of a Pointer Variable (C# Programming Guide)
Use the pointer indirection operator to obtain the variable at the location pointed to by a pointer. The expression takes the following form, where `p` is a pointer type:  
  
```  
*p;  
```  
  
 You cannot use the unary indirection operator on an expression of any type other than the pointer type. Also, you cannot apply it to a [void](../VS_csharp/void--csharp-reference-.md) pointer.  
  
 When you apply the indirection operator to a [null](../VS_csharp/null--csharp-reference-.md) pointer, the result depends on the implementation.  
  
## Example  
 In the following example, a variable of the type `char` is accessed by using pointers of different types. Note that the address of `theChar` will vary from run to run, because the physical address allocated to a variable can change.  
  
 [!code[csProgGuidePointers#5](../VS_csharp/codesnippet/CSharp/how-to--obtain-the-value-of-a-pointer-variable--csharp-programming-guide-_1.cs)]  
  
 [!code[csProgGuidePointers#6](../VS_csharp/codesnippet/CSharp/how-to--obtain-the-value-of-a-pointer-variable--csharp-programming-guide-_2.cs)]  
  
 **Value of theChar = Z**   
**Address of theChar = 12F718**  
**Value of pChar = Z**   
**Value of pInt = 90**    
## See Also  
 [C# Programming Guide](../VS_csharp/csharp-programming-guide.md)   
 [Pointer Expressions](../VS_csharp/pointer-expressions--csharp-programming-guide-.md)   
 [Pointer types](../VS_csharp/pointer-types--csharp-programming-guide-.md)   
 [Types](../VS_csharp/types--csharp-reference-.md)   
 [unsafe](../VS_csharp/unsafe--csharp-reference-.md)   
 [fixed Statement](../VS_csharp/fixed-statement--csharp-reference-.md)   
 [stackalloc](../VS_csharp/stackalloc--csharp-reference-.md)