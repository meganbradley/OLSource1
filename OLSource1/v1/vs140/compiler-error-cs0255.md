---
title: "Compiler Error CS0255"
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
  - "CS0255"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0255"
ms.assetid: b45f5d5a-1923-4fe1-a858-e5ef5590a108
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0255
stackalloc may not be used in a catch or finally block  
  
 The [stackalloc](../vs140/stackalloc--csharp-reference-.md) keyword may not be used in a [catch](../vs140/try-catch--csharp-reference-.md) or [finally](../vs140/try-catch-finally--csharp-reference-.md) block. For more information, see [Exceptions and Exception Handling (C# Programmer's Reference)](../vs140/exceptions-and-exception-handling--csharp-programming-guide-.md).  
  
 The following sample generates CS0255:  
  
```  
// CS0255.cs  
// compile with: /unsafe  
using System;  
  
public class TestTryFinally  
{  
   public static unsafe void Test()  
   {  
      int i = 123;  
      string s = "Some string";  
      object o = s;  
  
      try  
      {  
         // Conversion is not valid; o contains a string not an int  
         i = (int) o;  
      }  
  
      finally  
      {  
         Console.Write("i = {0}", i);  
         int* fib = stackalloc int[100];   // CS0255  
      }  
   }  
  
   public static void Main()  
   {  
   }  
}  
```