---
title: "Methods declared in structures cannot have &#39;Handles&#39; clauses"
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
  - "vbc30728"
  - "bc30728"
helpviewer_keywords: 
  - "BC30728"
ms.assetid: 64c70bb5-3696-4865-8194-328394c2b4b1
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Methods declared in structures cannot have &#39;Handles&#39; clauses
Structure methods cannot use the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> keyword to handle events.  
  
 **Error ID:** BC30728  
  
### To correct this error  
  
-   Consider redesigning your structure as a class.  
  
     You can use <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> to associate an event with an event handler in a structure, provided that the structure implements an event handler defined in an interface.  
  
## See Also  
 [Structures and Classes](../vs140/structures-and-classes--visual-basic-.md)   
 [NOT IN BUILD: Classes: Blueprints for Objects](assetId:///2c86373d-0333-4616-a7d8-4790c4e89f7b)   
 [Events in Visual Basic](../vs140/events--visual-basic-.md)   
 [NOT IN BUILD:AddHandler and RemoveHandler](assetId:///a7a24bd2-519a-46fe-8a2c-2b9df2ca28ef)