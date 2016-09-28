---
title: "&#39;&lt;eventname&gt;&#39; is an event, and cannot be called directly"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "bc32022"
  - "vbc32022"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "BC32022"
ms.assetid: 4dcfcb8d-a9fa-46a7-a034-29d9ff3a59b3
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &#39;&lt;eventname&gt;&#39; is an event, and cannot be called directly
'<`eventname`>' is an event, and so cannot be called directly. Use a `RaiseEvent` statement to raise an event.  
  
 A procedure call specifies an event for the procedure name. An event handler is a procedure, but the event itself is a signaling device, which must be raised and handled.  
  
 **Error ID:** BC32022  
  
### To correct this error  
  
1.  Use a `RaiseEvent` statement to signal an event and invoke the procedure or procedures that handle it.  
  
## See Also  
 [RaiseEvent Statement](../vs140/raiseevent-statement.md)