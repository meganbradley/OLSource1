---
title: "#endif (C# Reference)"
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
  - "#endif"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "#endif directive [C#]"
ms.assetid: 6a5fca55-5aee-441f-86f6-1c99fbe9ec05
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# #endif (C# Reference)
`#endif` specifies the end of a conditional directive, which began with the [#if](../vs140/sharpif--csharp-reference-.md) directive. For example,  
  
```  
  
      #define DEBUG  
// ...  
#if DEBUG  
    Console.WriteLine("Debug version");  
#endif  
```  
  
## Remarks  
 A conditional directive, beginning with a `#if` directive, must explicitly be terminated with a `#endif` directive. See [#if](../vs140/sharpif--csharp-reference-.md) for an example of how to use `#endif`.  
  
## See Also  
 [C# Reference](../vs140/csharp-reference.md)   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [C# Preprocessor Directives](../vs140/csharp-preprocessor-directives.md)