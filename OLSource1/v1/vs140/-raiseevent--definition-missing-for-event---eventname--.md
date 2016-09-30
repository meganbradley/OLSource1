---
title: "&#39;RaiseEvent&#39; definition missing for event &#39;&lt;eventname&gt;&#39;"
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
  - "vbc31132"
  - "bc31132"
helpviewer_keywords: 
  - "BC31132"
ms.assetid: 8f3442fd-2ed1-4dbc-83a8-f0860ec022ac
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &#39;RaiseEvent&#39; definition missing for event &#39;&lt;eventname&gt;&#39;
If an event is declared as <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>, it must supply a procedure for raising the event.  
  
 **Error ID:** BC31132  
  
### To correct this error  
  
1.  Include a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> declaration between the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> statement and the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> statement.  
  
2.  Verify that other procedures within the event declaration are correctly terminated.  
  
## See Also  
 [RaiseEvent Statement](../vs140/raiseevent-statement.md)   
 [Event Statement](../vs140/event-statement.md)