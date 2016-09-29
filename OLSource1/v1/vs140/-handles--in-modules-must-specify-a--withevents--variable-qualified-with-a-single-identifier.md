---
title: "&#39;Handles&#39; in modules must specify a &#39;WithEvents&#39; variable qualified with a single identifier"
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
  - "bc31418"
  - "vbc31418"
helpviewer_keywords: 
  - "BC31418"
ms.assetid: 7d866577-1e42-43f1-85d1-5d7eeba881b2
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &#39;Handles&#39; in modules must specify a &#39;WithEvents&#39; variable qualified with a single identifier
To specify an event handler, `Handles` statements must specify an object variable that was declared with the `WithEvents` keyword.  
  
 **Error ID:** BC31418  
  
### To correct this error  
  
-   Use the `WithEvents` modifier to declare variables that will be used with the `Handles` statement.  
  
## See Also  
 [Handles](../vs140/handles-clause--visual-basic-.md)   
 [WithEvents](../vs140/withevents--visual-basic-.md)   
 [Events in Visual Basic](../vs140/events--visual-basic-.md)