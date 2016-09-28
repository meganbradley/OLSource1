---
title: "How to: Combine Delegates (Multicast Delegates)(C# Programming Guide)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "delegates [C#], combining"
  - "multicast delegates [C#]"
ms.assetid: 4e689450-6d0c-46de-acfd-f961018ae5dd
caps.latest.revision: 21
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Combine Delegates (Multicast Delegates)(C# Programming Guide)
This example demonstrates how to create multicast delegates. A useful property of [delegate](../vs140/delegate--csharp-reference-.md) objects is that multiple objects can be assigned to one delegate instance by using the `+` operator. The multicast delegate contains a list of the assigned delegates. When the multicast delegate is called, it invokes the delegates in the list, in order. Only delegates of the same type can be combined.  
  
 The `-` operator can be used to remove a component delegate from a multicast delegate.  
  
## Example  
 [!code[csProgGuideDelegates#11](../vs140/codesnippet/CSharp/how-to--combine-delegates--multicast-delegates--csharp-programming-guide-_1.cs)]  
  
## See Also  
 <xref:System.MulticastDelegate*>   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [Events (C#)](../vs140/events--csharp-programming-guide-.md)