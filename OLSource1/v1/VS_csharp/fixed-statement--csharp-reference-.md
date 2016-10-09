---
title: "fixed Statement (C# Reference)"
ms.custom: na
ms.date: "10/03/2016"
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
caps.latest.revision: 24
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
# fixed Statement (C# Reference)
The `fixed` statement prevents the garbage collector from relocating a movable variable. The `fixed` statement is only permitted in an [unsafe](../VS_csharp/unsafe--csharp-reference-.md) context. `Fixed` can also be used to create [fixed size buffers](../VS_csharp/fixed-size-buffers--csharp-programming-guide-.md).  
  
 The `fixed` statement sets a pointer to a managed variable and "pins" that variable during the execution of the statement. Without `fixed`, pointers to movable managed variables would be of little use since garbage collection could relocate the variables unpredictably. The C# compiler only lets you assign a pointer to a managed variable in a `fixed` statement.  
  
 [!code[csrefKeywordsFixedLock#1](../VS_csharp/codesnippet/CSharp/fixed-statement--csharp-reference-_1.cs)]  
  
 You can initialize a pointer by using an array, a string, a fixed-size buffer, or the address of a variable. The following example illustrates the use of variable addresses, arrays, and strings. For more information about fixed-size buffers, see [Fixed Size Buffers](../VS_csharp/fixed-size-buffers--csharp-programming-guide-.md).  
  
 [!code[csrefKeywordsFixedLock#2](../VS_csharp/codesnippet/CSharp/fixed-statement--csharp-reference-_2.cs)]  
  
 You can initialize multiple pointers, as long as they are all of the same type.  
  
```  
fixed (byte* ps = srcarray, pd = dstarray) {...}  
```  
  
 To initialize pointers of different types, simply nest `fixed` statements, as shown in the following example.  
  
 [!code[csrefKeywordsFixedLock#3](../VS_csharp/codesnippet/CSharp/fixed-statement--csharp-reference-_3.cs)]  
  
 After the code in the statement is executed, any pinned variables are unpinned and subject to garbage collection. Therefore, do not point to those variables outside the `fixed` statement.  
  
> [!NOTE]
>  Pointers initialized in fixed statements cannot be modified.  
  
 In unsafe mode, you can allocate memory on the stack, where it is not subject to garbage collection and therefore does not need to be pinned. For more information, see [stackalloc](../VS_csharp/stackalloc--csharp-reference-.md).  
  
## Example  
 [!code[csrefKeywordsFixedLock#4](../VS_csharp/codesnippet/CSharp/fixed-statement--csharp-reference-_4.cs)]  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../VS_csharp/includes/csharplangspec_md.md)]  
  
## See Also  
 [C# Reference](../VS_csharp/csharp-reference.md)   
 [C# Programming Guide](../VS_csharp/csharp-programming-guide.md)   
 [C# Keywords](../VS_csharp/csharp-keywords.md)   
 [unsafe](../VS_csharp/unsafe--csharp-reference-.md)   
 [Fixed Size Buffers](../VS_csharp/fixed-size-buffers--csharp-programming-guide-.md)