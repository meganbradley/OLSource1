---
title: "Compiler Error CS0157"
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
  - "CS0157"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0157"
ms.assetid: a5d9d506-81f8-47dd-85b6-85f8170bcbef
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0157
Control cannot leave the body of a finally clause  
  
 All of the statements in a [finally](../vs140/try-catch-finally--csharp-reference-.md) clause must execute. For more information, see [Exception Handling Statements](../vs140/exception-handling-statements--csharp-reference-.md) and [Exceptions and Exception Handling (C# Programmer's Reference)](../vs140/exceptions-and-exception-handling--csharp-programming-guide-.md).  
  
 The following sample generates CS0157:  
  
```  
// CS0157.cs  
using System;  
namespace MyNamespace  
{  
   public class MyClass2 : Exception  
   {  
   }  
  
   public class MyClass  
   {  
      public static void Main()  
      {  
         try  
         {  
         }  
  
         finally  
         {  
            return;   // CS0157, cannot leave finally clause  
         }  
      }  
   }  
}  
```