---
title: "Compiler Error CS0077"
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
  - "CS0077"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0077"
ms.assetid: 55d3d290-d172-41a3-b326-ebf5a0a7e81f
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0077
The as operator must be used with a reference type or nullable type ('int' is a non-nullable value type).  
  
 The [as](../vs140/as--csharp-reference-.md) operator was passed a [value type](../vs140/value-types--csharp-reference-.md). Because `as` can return [null](../vs140/null--csharp-reference-.md), it can only be passed [reference types](../vs140/reference-types--csharp-reference-.md) or nullable type. For more information about nullable types, see [Nullable Types (C# Programming Guide)](../vs140/nullable-types--csharp-programming-guide-.md).  
  
 The following sample generates CS0077:  
  
```  
// CS0077.cs  
using System;  
  
class C  
{  
}  
  
struct S  
{  
}  
  
class M  
{  
   public static void Main()  
   {  
      object o1, o2;  
      C c;  
      S s;  
  
      o1 = new C();  
      o2 = new S();  
  
      s = o2 as S;  // CS0077, S is not a reference type.  
      // try the following line instead  
      // c = o1 as C;  
   }  
}  
```