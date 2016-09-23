---
title: "Compiler Error CS0263"
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
  - CS0263
dev_langs: 
  - CSharp
helpviewer_keywords: 
  - CS0263
ms.assetid: 94fe3eb0-10e9-4602-a993-68fe125c8565
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Error CS0263
Partial declarations of 'type' must not specify different base classes  
  
 When defining a type in partial declarations, specify the same base types in each of the partial declarations. For more information, see [Partial Class Definitions (C# Programmer's Reference)](../vs140/partial-classes-and-methods--csharp-programming-guide-.md).  
  
 The following sample generates CS0263:  
  
```  
  
// CS0263.cs  
// compile with: /target:library  
class B1  
{  
}  
  
class B2  
{  
}  
partial class C : B1  // CS0263 – is the base class B1 or B2?  
{  
}  
  
partial class C : B2  
{  
}  
```