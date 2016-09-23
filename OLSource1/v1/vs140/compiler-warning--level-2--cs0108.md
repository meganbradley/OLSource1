---
title: "Compiler Warning (level 2) CS0108"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: error-reference
f1_keywords: 
  - CS0108
dev_langs: 
  - CSharp
helpviewer_keywords: 
  - CS0108
ms.assetid: 04330ed2-80d5-4bf2-b0c1-a0c2bec03074
caps.latest.revision: 14
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Warning (level 2) CS0108
'member1' hides inherited member 'member2'. Use the new keyword if hiding was intended.  
  
 A variable was declared with the same name as a variable in a base class. However, the [new](../vs140/new--csharp-reference-.md) keyword was not used. This warning informs you that you should use **new**; the variable is declared as if **new** had been used in the declaration.  
  
 The following sample generates CS0108:  
  
```  
// CS0108.cs  
// compile with: /W:2  
using System;  
  
namespace x  
{  
   public class clx  
   {  
      public int i = 1;  
   }  
  
   public class cly : clx  
   {  
      public static int i = 2;   // CS0108, use the new keyword  
      // Use the following line instead:  
      // public static new int i = 2;  
  
      public static void Main()  
      {  
         Console.WriteLine(i);  
      }  
   }  
}  
```  
  
## See Also  
 [new Modifier (C# Reference)](../vs140/new-modifier--csharp-reference-.md)   
 [new](../vs140/new--csharp-reference-.md)