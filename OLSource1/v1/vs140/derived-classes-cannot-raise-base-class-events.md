---
title: "Derived classes cannot raise base class events"
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
  - "vbc30029"
  - "bc30029"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "BC30029"
ms.assetid: 63afa1c6-2f93-4512-a2f0-372455979771
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Derived classes cannot raise base class events
An event can be raised only from the declaration space in which it is declared. Therefore, a class cannot raise events from any other class, even one from which it is derived.  
  
 **Error ID:** BC30029  
  
### To correct this error  
  
-   Move the `Event` statement or the `RaiseEvent` statement so they are in the same class.  
  
## See Also  
 [Event Statement](../vs140/event-statement.md)   
 [RaiseEvent Statement](../vs140/raiseevent-statement.md)