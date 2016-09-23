---
title: "unsafe (C# Reference)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - unsafe_CSharpKeyword
  - unsafe
dev_langs: 
  - CSharp
helpviewer_keywords: 
  - unsafe keyword [C#]
ms.assetid: 7e818009-1c6e-4b9e-b769-3728a01586a0
caps.latest.revision: 23
translation.priority.ht: 
  - de-de
  - ja-jp
---
# unsafe (C# Reference)
The `unsafe` keyword denotes an unsafe context, which is required for any operation involving pointers. For more information, see [Unsafe Code and Pointers (C#)](../vs140/unsafe-code-and-pointers--csharp-programming-guide-.md).  
  
 You can use the `unsafe` modifier in the declaration of a type or a member. The entire textual extent of the type or member is therefore considered an unsafe context. For example, the following is a method declared with the `unsafe` modifier:  
  
```  
  
      unsafe static void FastCopy(byte[] src, byte[] dst, int count)  
{  
    // Unsafe context: can use pointers here.  
}  
```  
  
 The scope of the unsafe context extends from the parameter list to the end of the method, so pointers can also be used in the parameter list:  
  
```  
  
unsafe static void FastCopy ( byte* ps, byte* pd, int count ) {...}  
```  
  
 You can also use an unsafe block to enable the use of an unsafe code inside this block. For example:  
  
```  
  
      unsafe  
{  
    // Unsafe context: can use pointers here.  
}  
```  
  
 To compile unsafe code, you must specify the [/unsafe](../vs140/-unsafe--csharp-compiler-options-.md) compiler option. Unsafe code is not verifiable by the common language runtime.  
  
## Example  
 [!code[csrefKeywordsModifiers#22](../vs140/codesnippet/CSharp/unsafe--csharp-reference-_1.cs)]
  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../vs140/includes/csharplangspec_md.md)]  
  
## See Also  
 [C# Reference](../vs140/csharp-reference.md)   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [C# Keywords](../vs140/csharp-keywords.md)   
 [fixed Statement](../vs140/fixed-statement--csharp-reference-.md)   
 [Unsafe Code and Pointers (C#)](../vs140/unsafe-code-and-pointers--csharp-programming-guide-.md)   
 [Fixed Size Buffers (C#)](../vs140/fixed-size-buffers--csharp-programming-guide-.md)