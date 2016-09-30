---
title: "How to: Access a Member with a Pointer (C# Programming Guide)"
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
  - "pointers [C#], member access"
ms.assetid: 1e998498-8c85-4a78-8ce2-4d8c20f08342
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Access a Member with a Pointer (C# Programming Guide)
To access a member of a struct that is declared in an unsafe context, you can use the member access operator as shown in the following example in which <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> is a pointer to a [struct](../vs140/struct--csharp-reference-.md) that contains a member <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Example  
 In this example, a [struct](../vs140/struct--csharp-reference-.md), <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, that contains the two coordinates <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is declared and instantiated. By using the member access operator <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> and a pointer to the instance <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> are assigned values.  
  
> [!NOTE]
>  Notice that the expression <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is equivalent to the expression <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, and you can obtain the same result by using either of the two expressions.  
  
 [!code[csProgGuidePointers#9](../vs140/codesnippet/CSharp/how-to--access-a-member-with-a-pointer--csharp-programming-guide-_1.cs)]  
  
 [!code[csProgGuidePointers#10](../vs140/codesnippet/CSharp/how-to--access-a-member-with-a-pointer--csharp-programming-guide-_2.cs)]  
  
## See Also  
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [Pointer Expressions](../vs140/pointer-expressions--csharp-programming-guide-.md)   
 [Pointer types](../vs140/pointer-types--csharp-programming-guide-.md)   
 [Types](../vs140/types--csharp-reference-.md)   
 [unsafe](../vs140/unsafe--csharp-reference-.md)   
 [fixed Statement](../vs140/fixed-statement--csharp-reference-.md)   
 [stackalloc](../vs140/stackalloc--csharp-reference-.md)