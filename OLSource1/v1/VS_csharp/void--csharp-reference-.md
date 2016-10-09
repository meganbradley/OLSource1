---
title: "void (C# Reference)"
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
  - "void_CSharpKeyword"
  - "void"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "void keyword [C#]"
ms.assetid: 0d2d8a95-fe20-4fbd-bf5d-c1e54bce71d4
caps.latest.revision: 15
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
# void (C# Reference)
When used as the return type for a method, `void` specifies that the method doesn't return a value.  
  
 `void` isn't allowed in the parameter list of a method. A method that takes no parameters and returns no value is declared as follows:  
  
```  
public void SampleMethod()  
{  
    // Body of the method.  
}  
  
```  
  
 `void` is also used in an unsafe context to declare a pointer to an unknown type. For more information, see [Pointer types](../VS_csharp/pointer-types--csharp-programming-guide-.md).  
  
 `void` is an alias for the .NET Framework \<xref:System.Void?displayProperty=fullName> type.  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../VS_csharp/includes/csharplangspec_md.md)]  
  
## See Also  
 [C# Reference](../VS_csharp/csharp-reference.md)   
 [C# Programming Guide](../VS_csharp/csharp-programming-guide.md)   
 [C# Keywords](../VS_csharp/csharp-keywords.md)   
 [Reference Types](../VS_csharp/reference-types--csharp-reference-.md)   
 [Value Types](../VS_csharp/value-types--csharp-reference-.md)   
 [Methods](../VS_csharp/methods--csharp-programming-guide-.md)   
 [Unsafe Code and Pointers](../VS_csharp/unsafe-code-and-pointers--csharp-programming-guide-.md)