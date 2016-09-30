---
title: "CEvent::PulseEvent"
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
  - "PulseEvent"
  - "CEvent.PulseEvent"
  - "CEvent::PulseEvent"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "PulseEvent method"
ms.assetid: 576a525f-3d88-428a-acb7-7d7a8437328f
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CEvent::PulseEvent
Sets the state of the event to signaled (available), releases any waiting threads, and resets it to nonsignaled (unavailable) automatically.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Nonzero if the function was successful; otherwise 0.  
  
## Remarks  
 If the event is manual, all waiting threads are released, the event is set to nonsignaled, and <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> returns. If the event is automatic, a single thread is released, the event is set to nonsignaled, and <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> returns.  
  
 If no threads are waiting, or no threads can be released immediately, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> sets the state of the event to nonsignaled and returns.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> uses the underlying Win32 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> function, which can be momentarily removed from the wait state by a kernel-mode asynchronous procedure call. Therefore, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is unreliable and should not be used by new applications. For more information, see the [PulseEvent function](http://msdn.microsoft.com/library/windows/desktop/ms684914).  
  
## Requirements  
 **Header:** afxmt.h  
  
## See Also  
 [CEvent Class](../vs140/cevent-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)