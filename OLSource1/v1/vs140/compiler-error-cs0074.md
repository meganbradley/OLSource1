---
title: "Compiler Error CS0074"
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
  - "CS0074"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0074"
ms.assetid: 9395c532-3934-4553-8e41-042bfe3399ce
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0074
'event': abstract event cannot have initializer  
  
 If an [event](../vs140/event--csharp-reference-.md) is marked as **abstract**, it cannot be initialized. For more information, see [Events (C# Programmer's Reference)](../vs140/events--csharp-programming-guide-.md).  
  
 The following sample generates CS0074:  
  
```  
// CS0074.cs  
delegate void D();  
  
abstract class Test  
{  
   public abstract event D e = null;   // CS0074  
   // try the following line instead  
   // public abstract event D e;  
  
   public static void Main()  
   {  
   }  
}  
```