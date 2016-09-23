---
title: "#else (C# Reference)"
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
  - #else
dev_langs: 
  - CSharp
helpviewer_keywords: 
  - #else directive [C#]
ms.assetid: 6a347322-cfa2-4a86-98f8-ddfa2cb7d4db
caps.latest.revision: 15
translation.priority.ht: 
  - de-de
  - ja-jp
---
# #else (C# Reference)
`#else` lets you create a compound conditional directive, so that, if none of the expressions in the preceding [#if](../vs140/sharpif--csharp-reference-.md) or (optional) [#elif](../vs140/sharpelif--csharp-reference-.md) directives to `true`, the compiler will evaluate all code between `#else` and the subsequent `#endif`.  
  
## Remarks  
 [#endif](../vs140/sharpendif--csharp-reference-.md) must be the next preprocessor directive after `#else`. See [#if](../vs140/sharpif--csharp-reference-.md) for an example of how to use `#else`.  
  
## See Also  
 [C# Reference](../vs140/csharp-reference.md)   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [C# Preprocessor Directives](../vs140/csharp-preprocessor-directives.md)