---
title: "Compiler Error CS0069"
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
  - "CS0069"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0069"
ms.assetid: a1b32906-7773-47c6-8515-162a201a9be5
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0069
An event in an interface cannot have add or remove accessors  
  
 You cannot define an event's accessor functions in an [interface](../vs140/interface--csharp-reference-.md). For more information, see [Events (C# Programmer's Reference)](../vs140/events--csharp-programming-guide-.md) and [Interfaces (C# Programmer's Reference)](../vs140/interfaces--csharp-programming-guide-.md).  
  
 The following sample generates CS0069:  
  
```  
// CS0069.cs  
// compile with: /target:library  
  
public delegate void EventHandler();  
  
public interface a  
{  
   event EventHandler Click { remove {} }   // CS0069  
   event EventHandler Click2;   // OK  
}  
```