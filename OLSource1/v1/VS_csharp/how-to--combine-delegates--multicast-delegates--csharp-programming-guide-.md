---
title: "How to: Combine Delegates (Multicast Delegates)(C# Programming Guide)"
ms.custom: na
ms.date: "10/03/2016"
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
caps.latest.revision: 17
ms.author: "shoag"
manager: "wpickett"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# How to: Combine Delegates (Multicast Delegates)(C# Programming Guide)
This example demonstrates how to create multicast delegates. A useful property of [delegate](../VS_csharp/delegate--csharp-reference-.md) objects is that multiple objects can be assigned to one delegate instance by using the `+` operator. The multicast delegate contains a list of the assigned delegates. When the multicast delegate is called, it invokes the delegates in the list, in order. Only delegates of the same type can be combined.  
  
 The `-` operator can be used to remove a component delegate from a multicast delegate.  
  
## Example  
 [!code[csProgGuideDelegates#11](../VS_csharp/codesnippet/CSharp/how-to--combine-delegates--multicast-delegates--csharp-programming-guide-_1.cs)]  
  
## See Also  
 \<xref:System.MulticastDelegate>   
 [C# Programming Guide](../VS_csharp/csharp-programming-guide.md)   
 [Events](../VS_csharp/events--csharp-programming-guide-.md)