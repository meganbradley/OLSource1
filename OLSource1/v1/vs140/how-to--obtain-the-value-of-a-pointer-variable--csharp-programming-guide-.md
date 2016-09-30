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
Use the pointer indirection operator to obtain the variable at the location pointed to by a pointer. The expression takes the following form, where <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> is a pointer type:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 You cannot use the unary indirection operator on an expression of any type other than the pointer type. Also, you cannot apply it to a [void](../vs140/void--csharp-reference-.md) pointer.  
  
 When you apply the indirection operator to a [null](../vs140/null--csharp-reference-.md) pointer, the result depends on the implementation.  
  
## Example  
 In the following example, a variable of the type <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is accessed by using pointers of different types. Note that the address of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> will vary from run to run, because the physical address allocated to a variable can change.  
  
 [!code[csProgGuidePointers#5](../vs140/codesnippet/CSharp/how-to--obtain-the-value-of-a-pointer-variable--csharp-programming-guide-_1.cs)]  
  
 [!code[csProgGuidePointers#6](../vs140/codesnippet/CSharp/how-to--obtain-the-value-of-a-pointer-variable--csharp-programming-guide-_2.cs)]  
  
 **Value of theChar = Z**   
**Address of theChar = 12F718**  
**Value of pChar = Z**   
**Value of pInt = 90**    
## See Also  
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [Pointer Expressions](../vs140/pointer-expressions--csharp-programming-guide-.md)   
 [Pointer types](../vs140/pointer-types--csharp-programming-guide-.md)   
 [Types](../vs140/types--csharp-reference-.md)   
 [unsafe](../vs140/unsafe--csharp-reference-.md)   
 [fixed Statement](../vs140/fixed-statement--csharp-reference-.md)   
 [stackalloc](../vs140/stackalloc--csharp-reference-.md)