---
title: "CWnd::KillTimer"
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
  - "CWnd::KillTimer"
  - "CWnd.KillTimer"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "timer functions"
  - "KillTimer method"
  - "CWnd class, timer functions"
ms.assetid: c4a11e5a-3215-4d96-8c3b-3934324cc3ff
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::KillTimer
Kills the timer event identified by `nIDEvent` from the earlier call to `SetTimer`.  
  
## Syntax  
  
```  
  
      BOOL KillTimer(  
   UINT_PTR nIDEvent   
);  
```  
  
#### Parameters  
 `nIDEvent`  
 The value of the timer event passed to [SetTimer](../vs140/cwnd--settimer.md).  
  
## Return Value  
 Specifies the outcome of the function. The value is nonzero if the event was killed. It is 0 if the `KillTimer` member function could not find the specified timer event.  
  
## Remarks  
 Pending [WM_TIMER](../vs140/cwnd--ontimer.md) messages associated with the timer are not removed from the message queue.  
  
## Example  
 See the example for [CWnd::SetTimer](../vs140/cwnd--settimer.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::SetTimer](../vs140/cwnd--settimer.md)   
 [KillTimer](http://msdn.microsoft.com/library/windows/desktop/ms644903)