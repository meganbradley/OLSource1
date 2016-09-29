---
title: "Compiler Error CS0620"
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
  - "CS0620"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0620"
ms.assetid: cadd7156-0c3c-460b-844b-c9bbfb8f62df
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0620
Indexers cannot have void type  
  
 The return type of an [indexer](../vs140/indexers--csharp-programming-guide-.md) cannot be `void`. An indexer must return a value.  
  
 The following sample generates CS0620:  
  
```  
// CS0620.cs  
class MyClass  
{  
   public static void Main()  
   {  
      MyClass test = new MyClass();  
      System.Console.WriteLine(test[2]);  
   }  
  
   void this [int intI]   // CS0620, return type cannot be void  
   {  
      get  
      {  
         // will need to return some value  
      }  
   }  
}  
```  
  
## See Also  
 [void (C# Reference)](../vs140/void--csharp-reference-.md)