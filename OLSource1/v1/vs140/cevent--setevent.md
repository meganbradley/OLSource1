---
title: "CEvent::SetEvent"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "CEvent::SetEvent"
  - "SetEvent"
  - "CEvent.SetEvent"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetEvent method"
ms.assetid: 6b86630a-5a9b-4eb1-a05b-6918d15731d8
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CEvent::SetEvent
Sets the state of the event to signaled, releasing any waiting threads.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Nonzero if the function was successful, otherwise 0.  
  
## Remarks  
 If the event is manual, the event will remain signaled until [ResetEvent](../vs140/cevent--resetevent.md) is called. More than one thread can be released in this case. If the event is automatic, the event will remain signaled until a single thread is released. The system will then set the state of the event to nonsignaled. If no threads are waiting, the state remains signaled until one thread is released.  
  
## Requirements  
 **Header:** afxmt.h  
  
## See Also  
 [CEvent Class](../vs140/cevent-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)