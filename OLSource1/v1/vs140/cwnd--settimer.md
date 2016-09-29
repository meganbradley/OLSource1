---
title: "CWnd::SetTimer"
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
  - "CWnd::SetTimer"
  - "CWnd.SetTimer"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "timers, setting"
  - "timer functions"
  - "SetTimer method"
  - "CWnd class, timer functions"
ms.assetid: 8f7d77c7-7f77-4270-8441-1c357649c1c2
caps.latest.revision: 20
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::SetTimer
Installs a system timer.  
  
## Syntax  
  
```  
  
      UINT_PTR SetTimer(  
   UINT_PTR nIDEvent,  
   UINT nElapse,  
   void (CALLBACK* lpfnTimer  
)(HWND,  
   UINT,  
   UINT_PTR,  
   DWORD  
)   
);  
```  
  
#### Parameters  
 `nIDEvent`  
 Specifies a nonzero timer identifier. If the timer identifier is unique, this same value is returned by `SetTimer`. Otherwise, `SetTimer` determines a new unique value and returns that. For a window timer (which has a NULL callback function), the value must be unique only for other windows timers that are associated with the current window. For a callback timer, the value must be unique for all timers in all processes. Therefore, when you create a callback timer, it is more likely that the returned value might differ from the value you specify.  
  
 `nElapse`  
 Specifies the time-out value, or interval, in milliseconds.  
  
 `lpfnTimer`  
 Specifies the address of the application-supplied `TimerProc` callback function that processes the [WM_TIMER](http://msdn.microsoft.com/library/windows/desktop/ms644902) messages. If this parameter is `NULL`, the `WM_TIMER` messages are placed in the message queue of the application and handled by the `CWnd` object.  
  
## Return Value  
 The timer identifier of the new timer if the function is successful. This value may or may not be equal to the value passed in through the `nIDEvent` parameter. An application should always pass the return value to the [KillTimer](../vs140/cwnd--killtimer.md) member function to kill the timer. Nonzero if successful; otherwise, 0.  
  
## Remarks  
 An interval value is specified, and every time the interval elapses, the system posts a `WM_TIMER` message to the installing message queue of the installing application or passes the message to an application-defined `TimerProc` callback function.  
  
 The `lpfnTimer` callback function need not be named `TimerProc`, but it must be declared as static and defined as follows.  
  
```  
void CALLBACK TimerProc(  
   HWND hWnd,      // handle of CWnd that called SetTimer  
   UINT nMsg,      // WM_TIMER  
   UINT_PTR nIDEvent,   // timer identification  
   DWORD dwTime    // system time  
);  
```  
  
## Example  
 This example uses `CWnd::SetTimer`, `CWnd::OnTimer`, and `CWnd::KillTimer` to handle `WM_TIMER` messages. The first timer is set up to send a `WM_TIMER` message to the main frame window every 2 seconds in `OnStartTimer`. The `OnTimer` event handler handles `WM_TIMER` messages for the main frame window. This method causes the PC speaker to beep every 2 seconds. The second timer sends a message to the callback function every 3.75 seconds. `OnStopTimer` will stop both timers by calling `CWnd::KillTimer` for each timer ID.  
  
 [!code[NVC_MFCWindowing#118](../vs140/codesnippet/CPP/cwnd--settimer_1.cpp)]  
  
## Requirements  
 Header: afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [WM_TIMER](http://msdn.microsoft.com/library/windows/desktop/ms644902)   
 [CWnd::KillTimer](../vs140/cwnd--killtimer.md)   
 [SetTimer](http://msdn.microsoft.com/library/windows/desktop/ms644906)