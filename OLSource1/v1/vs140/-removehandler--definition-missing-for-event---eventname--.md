---
title: "&#39;RemoveHandler&#39; definition missing for event &#39;&lt;eventname&gt;&#39;"
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
  - "bc31131"
  - "vbc31131"
helpviewer_keywords: 
  - "BC31131"
ms.assetid: 0ef68daf-b66e-4ecf-bf2c-dcacabd8aa3d
caps.latest.revision: 10
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &#39;RemoveHandler&#39; definition missing for event &#39;&lt;eventname&gt;&#39;
If an event is declared as `Custom`, it must supply a procedure for removing an event handler.  
  
 **Error ID:** BC31131  
  
### To correct this error  
  
1.  Include a `RemoveHandler` declaration between the `Custom Event` statement and the `End Event` statement.  
  
2.  Verify that other procedures within the event declaration are correctly terminated.  
  
## See Also  
 [RemoveHandler Statement](../vs140/removehandler-statement.md)   
 [Event Statement](../vs140/event-statement.md)