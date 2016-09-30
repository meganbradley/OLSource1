---
title: "stackalloc (C# Reference)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "stackalloc_CSharpKeyword"
  - "stackalloc"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "stackalloc keyword [C#]"
ms.assetid: adc04c28-3ed2-4326-807a-7545df92b852
caps.latest.revision: 31
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# stackalloc (C# Reference)
The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> keyword is used in an unsafe code context to allocate a block of memory on the stack.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The keyword is valid only in local variable initializers. The following code causes compiler errors.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Because pointer types are involved, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> requires [unsafe](../vs140/unsafe--csharp-reference-.md) context. For more information, see [Unsafe Code and Pointers](../vs140/unsafe-code-and-pointers--csharp-programming-guide-.md).  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is like [_alloca](../vs140/_alloca.md) in the C run-time library.  
  
 The following example calculates and displays the first 20 numbers in the Fibonacci sequence. Each number is the sum of the previous two numbers. In the code, a block of memory of sufficient size to contain 20 elements of type <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is allocated on the stack, not the heap. The address of the block is stored in the pointer <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. This memory is not subject to garbage collection and therefore does not have to be pinned (by using [fixed](../vs140/fixed-statement--csharp-reference-.md)). The lifetime of the memory block is limited to the lifetime of the method that defines it. You cannot free the memory before the method returns.  
  
## Example  
 [!code[csrefKeywordsOperator#15](../vs140/codesnippet/CSharp/stackalloc--csharp-reference-_1.cs)]  
  
## Security  
 Unsafe code is less secure than safe alternatives. However, the use of <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> automatically enables buffer overrun detection features in the common language runtime (CLR). If a buffer overrun is detected, the process is terminated as quickly as possible to minimize the chance that malicious code is executed.  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../vs140/includes/csharplangspec_md.md)]  
  
## See Also  
 [C# Reference](../vs140/csharp-reference.md)   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [C# Keywords](../vs140/csharp-keywords.md)   
 [Operator Keywords](../vs140/operator-keywords--csharp-reference-.md)   
 [Unsafe Code and Pointers (C#)](../vs140/unsafe-code-and-pointers--csharp-programming-guide-.md)