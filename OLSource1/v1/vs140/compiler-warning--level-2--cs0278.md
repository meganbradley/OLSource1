---
title: "Compiler Warning (level 2) CS0278"
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
  - CS0278
dev_langs: 
  - CSharp
helpviewer_keywords: 
  - CS0278
ms.assetid: 5418cbbe-bcec-4379-a6f6-410987beb96a
caps.latest.revision: 14
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Warning (level 2) CS0278
'type' does not implement the 'pattern name' pattern. 'method name' is ambiguous with 'method name'.  
  
 There are several statements in C# that rely on defined patterns, such as `foreach` and `using`. For example, `foreach` relies on the collection class implementing the "enumerable" pattern.  
  
 CS0278 can occur if the compiler is unable to make the match due to ambiguities. For example, the "enumerable" pattern requires that there be a method called `MoveNext`, and your code might contain two methods called `MoveNext`. The compiler will attempt to find an interface to use, but it is recommended that you determine and resolve the cause of the ambiguity.  
  
 For more information, see [How to: Access a Collection Class with foreach (C# Programming Guide)](../vs140/how-to--access-a-collection-class-with-foreach--csharp-programming-guide-.md).  
  
## Example  
 The following sample generates CS0278.  
  
```  
// CS0278.cs  
using System.Collections.Generic;  
public class myTest   
{  
   public static void TestForeach<W>(W w)   
      where W: IEnumerable<int>, IEnumerable<string>  
   {  
      foreach (int i in w) {}   // CS0278  
   }  
}  
```