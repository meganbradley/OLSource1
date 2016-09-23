---
title: "Compiler Error CS0079"
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
  - CS0079
dev_langs: 
  - CSharp
helpviewer_keywords: 
  - CS0079
ms.assetid: 71c85883-b72f-402f-a828-18ca92976273
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Error CS0079
The event 'event' can only appear on the left hand side of += or -=  
  
 An [event](../vs140/event--csharp-reference-.md) was called incorrectly. For more information, see [Events (C# Programmer's Reference)](../vs140/events--csharp-programming-guide-.md) and [Delegates (C# Programmer's Reference)](../vs140/delegates--csharp-programming-guide-.md).  
  
 The following sample generates CS0079:  
  
```  
// CS0079.cs  
using System;  
  
public delegate void MyEventHandler();  
  
public class Class1  
{  
   private MyEventHandler _e;  
  
   public event MyEventHandler Pow  
   {  
      add  
      {  
         _e += value;  
         Console.WriteLine("in add accessor");  
      }  
      remove  
      {  
         _e -= value;  
         Console.WriteLine("in remove accessor");  
      }  
   }  
  
   public void Handler()  
   {  
   }  
  
   public void Fire()  
   {  
      if (_e != null)  
      {  
         Pow();   // CS0079  
         // try the following line instead  
         // _e();  
      }  
   }  
  
   public static void Main()  
   {  
      Class1 p = new Class1();  
      p.Pow += new MyEventHandler(p.Handler);  
      p._e();  
      p.Pow += new MyEventHandler(p.Handler);  
      p._e();  
      p._e -= new MyEventHandler(p.Handler);  
      if (p._e != null)  
      {  
         p._e();  
      }  
      p.Pow -= new MyEventHandler(p.Handler);  
      if (p._e != null)  
      {  
         p._e();  
      }  
   }  
}  
```