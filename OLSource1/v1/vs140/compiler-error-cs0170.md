---
title: "Compiler Error CS0170"
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
  - CS0170
dev_langs: 
  - CSharp
helpviewer_keywords: 
  - CS0170
ms.assetid: ba881e38-2abf-4a5f-b9e6-28d26a5bd235
caps.latest.revision: 14
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Error CS0170
Use of possibly unassigned field 'field'  
  
 A field in a structure was used without first being initialized. To solve this problem, first determine which field was uninitialized and then initialize it before you try to access it. For more information about initializing structs, see [Structs (C# Programming Guide)](../vs140/structs--csharp-programming-guide-.md) and [Using Structs (C# Programming Guide)](../vs140/using-structs--csharp-programming-guide-.md).  
  
 The following sample generates CS0170:  
  
```  
// CS0170.cs  
public struct error  
{  
   public int i;  
}  
  
public class MyClass  
{  
   public static void Main()  
   {  
      error e;  
      // uncomment the next line to resolve this error  
      // e.i = 0;  
      System.Console.WriteLine( e.i );   // CS0170 because   
                                         //e.i was never assigned  
   }  
}  
```