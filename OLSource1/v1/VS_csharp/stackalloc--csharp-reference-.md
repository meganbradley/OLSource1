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
The `stackalloc` keyword is used in an unsafe code context to allocate a block of memory on the stack.  
  
```  
int* block = stackalloc int[100];  
```  
  
## Remarks  
 The keyword is valid only in local variable initializers. The following code causes compiler errors.  
  
```  
int* block;  
// The following assignment statement causes compiler errors. You  
// can use stackalloc only when declaring and initializing a local   
// variable.  
block = stackalloc int[100];  
```  
  
 Because pointer types are involved, `stackalloc` requires [unsafe](../VS_csharp/unsafe--csharp-reference-.md) context. For more information, see [Unsafe Code and Pointers](../VS_csharp/unsafe-code-and-pointers--csharp-programming-guide-.md).  
  
 `stackalloc` is like [_alloca](../VS_csharp/_alloca.md) in the C run-time library.  
  
 The following example calculates and displays the first 20 numbers in the Fibonacci sequence. Each number is the sum of the previous two numbers. In the code, a block of memory of sufficient size to contain 20 elements of type `int` is allocated on the stack, not the heap. The address of the block is stored in the pointer `fib`. This memory is not subject to garbage collection and therefore does not have to be pinned (by using [fixed](../VS_csharp/fixed-statement--csharp-reference-.md)). The lifetime of the memory block is limited to the lifetime of the method that defines it. You cannot free the memory before the method returns.  
  
## Example  
 [!code[csrefKeywordsOperator#15](../VS_csharp/codesnippet/CSharp/stackalloc--csharp-reference-_1.cs)]  
  
## Security  
 Unsafe code is less secure than safe alternatives. However, the use of `stackalloc` automatically enables buffer overrun detection features in the common language runtime (CLR). If a buffer overrun is detected, the process is terminated as quickly as possible to minimize the chance that malicious code is executed.  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../VS_csharp/includes/csharplangspec_md.md)]  
  
## See Also  
 [C# Reference](../VS_csharp/csharp-reference.md)   
 [C# Programming Guide](../VS_csharp/csharp-programming-guide.md)   
 [C# Keywords](../VS_csharp/csharp-keywords.md)   
 [Operator Keywords](../VS_csharp/operator-keywords--csharp-reference-.md)   
 [Unsafe Code and Pointers (C#)](../VS_csharp/unsafe-code-and-pointers--csharp-programming-guide-.md)