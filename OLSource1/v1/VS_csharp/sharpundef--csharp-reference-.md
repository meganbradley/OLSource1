---
title: "#undef (C# Reference)"
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
  - "#undef"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "#undef directive [C#]"
ms.assetid: 686c92d2-7194-4be4-b2f4-80091712d513
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# #undef (C# Reference)
`#undef` lets you undefine a symbol, such that, by using the symbol as the expression in a [#if](../VS_csharp/sharpif--csharp-reference-.md) directive, the expression will evaluate to `false`.  
  
 A symbol can be defined either with the [#define](../VS_csharp/sharpdefine--csharp-reference-.md) directive or the [/define](../VS_csharp/-define--csharp-compiler-options-.md) compiler option. The `#undef` directive must appear in the file before you use any statements that are not also directives.  
  
## Example  
  
```  
// preprocessor_undef.cs  
// compile with: /d:DEBUG  
#undef DEBUG  
using System;  
class MyClass   
{  
    static void Main()   
    {  
#if DEBUG  
        Console.WriteLine("DEBUG is defined");  
#else  
        Console.WriteLine("DEBUG is not defined");  
#endif  
    }  
}  
```  
  
 **DEBUG is not defined**   
## See Also  
 [C# Programmer's Reference](../VS_csharp/csharp-reference.md)   
 [C# Programming Guide](../VS_csharp/csharp-programming-guide.md)   
 [C# Preprocessor Directives](../VS_csharp/csharp-preprocessor-directives.md)