---
title: "How to: Use a Dictionary to Store Event Instances (C# Programming Guide)"
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
  - "events [C#], storing instances in a Dictionary"
ms.assetid: 9512c64d-5aaf-40cd-b941-ca2a592f0064
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Use a Dictionary to Store Event Instances (C# Programming Guide)
One use for `accessor-declarations` is to expose many events without allocating a field for each event, but instead using a Dictionary to store the event instances. This is only useful if you have many events, but you expect most of the events will not be implemented.  
  
## Example  
 [!code[csProgGuideEvents#9](../vs140/codesnippet/CSharp/how-to--use-a-dictionary-to-store-event-instances--csharp-programming-guide-_1.cs)]  
  
## See Also  
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [Events (C#)](../vs140/events--csharp-programming-guide-.md)   
 [Delegates (Visual C#)](../vs140/delegates--csharp-programming-guide-.md)