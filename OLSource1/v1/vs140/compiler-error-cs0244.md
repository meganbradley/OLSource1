---
title: "Compiler Error CS0244"
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
  - "CS0244"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0244"
ms.assetid: f10e4479-ed6e-40dc-9fab-914e404d7f84
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0244
Neither 'is' nor 'as' is valid on pointer types  
  
 The [is](../vs140/is--csharp-reference-.md) and [as](../vs140/as--csharp-reference-.md) keywords are not valid for use on pointer types. For more information, see [Unsafe Code and Pointers (C# Programmers Reference)](../vs140/unsafe-code-and-pointers--csharp-programming-guide-.md).  
  
 The following sample generates CS0244:  
  
```  
// CS0244.cs  
// compile with: /unsafe  
  
class UnsafeTest  
{  
   unsafe static void SquarePtrParam (int* p)  
   {  
      bool b = p is object;   // CS0244 p is pointer  
   }  
  
   unsafe public static void Main()  
   {  
      int i = 5;  
      SquarePtrParam (&i);  
   }  
}  
```