---
title: "fixed Statement (C# Reference)"
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
  - "fixed_CSharpKeyword"
  - "fixed"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "fixed keyword [C#]"
ms.assetid: 7ea6db08-ad49-4a7a-b934-d8c4acad1c3a
caps.latest.revision: 28
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# fixed Statement (C# Reference)
The `fixed` statement prevents the garbage collector from relocating a movable variable. The `fixed` statement is only permitted in an [unsafe](../vs140/unsafe--csharp-reference-.md) context. `Fixed` can also be used to create [fixed size buffers](../vs140/fixed-size-buffers--csharp-programming-guide-.md).  
  
 The `fixed` statement sets a pointer to a managed variable and "pins" that variable during the execution of the statement. Without `fixed`, pointers to movable managed variables would be of little use since garbage collection could relocate the variables unpredictably. The C# compiler only lets you assign a pointer to a managed variable in a `fixed` statement.  
  
 [!code[csrefKeywordsFixedLock#1](../vs140/codesnippet/CSharp/fixed-statement--csharp-reference-_1.cs)]  
  
 You can initialize a pointer by using an array, a string, a fixed-size buffer, or the address of a variable. The following example illustrates the use of variable addresses, arrays, and strings. For more information about fixed-size buffers, see [Fixed Size Buffers (C# Programming Guide)](../vs140/fixed-size-buffers--csharp-programming-guide-.md).  
  
 [!code[csrefKeywordsFixedLock#2](../vs140/codesnippet/CSharp/fixed-statement--csharp-reference-_2.cs)]  
  
 You can initialize multiple pointers, as long as they are all of the same type.  
  
```  
fixed (byte* ps = srcarray, pd = dstarray) {...}  
```  
  
 To initialize pointers of different types, simply nest `fixed` statements, as shown in the following example.  
  
 [!code[csrefKeywordsFixedLock#3](../vs140/codesnippet/CSharp/fixed-statement--csharp-reference-_3.cs)]  
  
 After the code in the statement is executed, any pinned variables are unpinned and subject to garbage collection. Therefore, do not point to those variables outside the `fixed` statement.  
  
> [!NOTE]
>  Pointers initialized in fixed statements cannot be modified.  
  
 In unsafe mode, you can allocate memory on the stack, where it is not subject to garbage collection and therefore does not need to be pinned. For more information, see [stackalloc](../vs140/stackalloc--csharp-reference-.md).  
  
## Example  
 [!code[csrefKeywordsFixedLock#4](../vs140/codesnippet/CSharp/fixed-statement--csharp-reference-_4.cs)]  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../vs140/includes/csharplangspec_md.md)]  
  
## See Also  
 [C# Reference](../vs140/csharp-reference.md)   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [C# Keywords](../vs140/csharp-keywords.md)   
 [unsafe](../vs140/unsafe--csharp-reference-.md)   
 [Fixed Size Buffers (C#)](../vs140/fixed-size-buffers--csharp-programming-guide-.md)