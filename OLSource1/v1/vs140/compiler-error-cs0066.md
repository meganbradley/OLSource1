---
title: "Compiler Error CS0066"
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
  - CS0066
dev_langs: 
  - CSharp
helpviewer_keywords: 
  - CS0066
ms.assetid: 9b50b49b-78b8-4562-8839-d59e5edbec6b
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Error CS0066
'event': event must be of a delegate type  
  
 The event keyword requires a [delegate](../vs140/delegate--csharp-reference-.md) type. For more information, see [Events (C# Programmer's Reference)](../vs140/events--csharp-programming-guide-.md) and [Delegates (C# Programmer's Reference)](../vs140/delegates--csharp-programming-guide-.md).  
  
 The following sample generates CS0066:  
  
```  
// CS0066.cs  
using System;  
  
public class EventHandler  
{  
}  
  
// to fix the error, remove the event declaration and the  
// EventHandler class declaration, and uncomment the following line  
// public delegate void EventHandler();  
  
public class a  
{  
   public event EventHandler Click;   // CS0066  
  
   private void TestMethod()  
   {  
      if (Click != null)  
         Click();  
   }  
  
   public static void Main()  
   {  
   }  
}  
```