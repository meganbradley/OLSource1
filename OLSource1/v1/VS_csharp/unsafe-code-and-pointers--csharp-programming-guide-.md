---
title: "Unsafe Code and Pointers (C# Programming Guide)"
ms.custom: na
ms.date: "10/03/2016"
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
  - "security [C#], type safety"
  - "C# language, unsafe code"
  - "type safety [C#]"
  - "unsafe keyword [C#]"
  - "unsafe code [C#]"
  - "C# language, pointers"
  - "pointers [C#], about pointers"
ms.assetid: b0fcca10-a92d-4f2a-835b-b0ccae6739ee
caps.latest.revision: 24
ms.author: "shoag"
manager: "wpickett"
translation.priority.ht: 
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "ru-ru"
  - "zh-cn"
  - "zh-tw"
translation.priority.mt: 
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---
# Unsafe Code and Pointers (C# Programming Guide)
To maintain type safety and security, C# does not support pointer arithmetic, by default. However, by using the [unsafe](../VS_csharp/unsafe--csharp-reference-.md) keyword, you can define an unsafe context in which pointers can be used. For more information about pointers, see the topic [Pointer types](../VS_csharp/pointer-types--csharp-programming-guide-.md).  
  
> [!NOTE]
>  In the common language runtime (CLR), unsafe code is referred to as unverifiable code. Unsafe code in C# is not necessarily dangerous; it is just code whose safety cannot be verified by the CLR. The CLR will therefore only execute unsafe code if it is in a fully trusted assembly. If you use unsafe code, it is your responsibility to ensure that your code does not introduce security risks or pointer errors.  
  
## Unsafe Code Overview  
 Unsafe code has the following properties:  
  
-   Methods, types, and code blocks can be defined as unsafe.  
  
-   In some cases, unsafe code may increase an application's performance by removing array bounds checks.  
  
-   Unsafe code is required when you call native functions that require pointers.  
  
-   Using unsafe code introduces security and stability risks.  
  
-   In order for C# to compile unsafe code, the application must be compiled with [/unsafe](../VS_csharp/-unsafe--csharp-compiler-options-.md).  
  
## Related Sections  
 For more information, see:  
  
-   [Pointer types](../VS_csharp/pointer-types--csharp-programming-guide-.md)  
  
-   [Fixed Size Buffers](../VS_csharp/fixed-size-buffers--csharp-programming-guide-.md)  
  
-   [How to: Use Pointers to Copy an Array of Bytes](../VS_csharp/how-to--use-pointers-to-copy-an-array-of-bytes---csharp-programming-guide-.md)  
  
-   [unsafe](../VS_csharp/unsafe--csharp-reference-.md)  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../VS_csharp/includes/csharplangspec_md.md)]  
  
## See Also  
 [C# Programming Guide](../VS_csharp/csharp-programming-guide.md)