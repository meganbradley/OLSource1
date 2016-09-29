---
title: "Compiler Error CS0113"
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
  - "CS0113"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0113"
ms.assetid: 43c5c0b7-67c0-45c1-8363-21c844c094f3
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0113
A member 'function' marked as override cannot be marked as new or virtual  
  
 It is mutually exclusive to mark a method with the [new](../vs140/new--csharp-reference-.md) and [override](../vs140/override--csharp-reference-.md) keywords.  
  
 The following sample generates CS0113:  
  
```  
// CS0113.cs  
namespace MyNamespace  
{  
   abstract public class MyClass  
   {  
      public abstract void Foo();  
   }  
  
   public class MyClass2 : MyClass  
   {  
      override new public void Foo()   // CS0113, remove new keyword  
      {  
      }  
  
      public static int Main()  
      {  
         return 0;  
      }  
   }  
}  
```