---
title: "void (C# Reference)"
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
  - void_CSharpKeyword
  - void
dev_langs: 
  - CSharp
helpviewer_keywords: 
  - void keyword [C#]
ms.assetid: 0d2d8a95-fe20-4fbd-bf5d-c1e54bce71d4
caps.latest.revision: 19
translation.priority.ht: 
  - de-de
  - ja-jp
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
  
 `void` is also used in an unsafe context to declare a pointer to an unknown type. For more information, see [Pointer types](../vs140/pointer-types--csharp-programming-guide-.md).  
  
 `void` is an alias for the .NET Framework <xref:System.Void?qualifyHint=True> type.  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../vs140/includes/csharplangspec_md.md)]  
  
## See Also  
 [C# Reference](../vs140/csharp-reference.md)   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [C# Keywords](../vs140/csharp-keywords.md)   
 [Reference Types](../vs140/reference-types--csharp-reference-.md)   
 [Value Types](../vs140/value-types--csharp-reference-.md)   
 [Methods (C# Programming Guide)](../vs140/methods--csharp-programming-guide-.md)   
 [Unsafe Code and Pointers (C# Programming Guide)](../vs140/unsafe-code-and-pointers--csharp-programming-guide-.md)