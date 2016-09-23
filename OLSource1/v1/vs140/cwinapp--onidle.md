---
title: "CWinApp::OnIdle"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CWinApp::OnIdle
  - CWinApp.OnIdle
dev_langs: 
  - C++
helpviewer_keywords: 
  - OnIdle method
  - idle processing
  - CWinApp class, overridables
ms.assetid: 29094045-b29b-4239-ba1f-7831b79ad2d7
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CWinApp::OnIdle
Override this member function to perform idle-time processing.  
  
## Syntax  
  
```  
  
      virtual BOOL OnIdle(  
   LONG lCount   
);  
```  
  
#### Parameters  
 `lCount`  
 A counter incremented each time `OnIdle` is called when the application's message queue is empty. This count is reset to 0 each time a new message is processed. You can use the `lCount` parameter to determine the relative length of time the application has been idle without processing a message.  
  
## Return Value  
 Nonzero to receive more idle processing time; 0 if no more idle time is needed.  
  
## Remarks  
 `OnIdle` is called in the default message loop when the application's message queue is empty. Use your override to call your own background idle-handler tasks.  
  
 `OnIdle` should return 0 to indicate that no idle processing time is required. The `lCount` parameter is incremented each time `OnIdle` is called when the message queue is empty and resets to 0 each time a new message is processed. You can call your different idle routines based on this count.  
  
 The following summarizes idle loop processing:  
  
1.  If the message loop in the Microsoft Foundation Class Library checks the message queue and finds no pending messages, it calls `OnIdle` for the application object and supplies 0 as the `lCount` argument.  
  
2.  `OnIdle` performs some processing and returns a nonzero value to indicate it should be called again to do further processing.  
  
3.  The message loop checks the message queue again. If no messages are pending, it calls `OnIdle` again, incrementing the `lCount` argument.  
  
4.  Eventually, `OnIdle` finishes processing all its idle tasks and returns 0. This tells the message loop to stop calling `OnIdle` until the next message is received from the message queue, at which point the idle cycle restarts with the argument set to 0.  
  
 Do not perform lengthy tasks during `OnIdle` because your application cannot process user input until `OnIdle` returns.  
  
> [!NOTE]
>  The default implementation of `OnIdle` updates command user-interface objects such as menu items and toolbar buttons, and it performs internal data structure cleanup. Therefore, if you override `OnIdle`, you must call `CWinApp::OnIdle` with the `lCount` in your overridden version. First call all base-class idle processing (that is, until the base class `OnIdle` returns 0). If you need to perform work before the base-class processing completes, review the base-class implementation to select the proper `lCount` during which to do your work.  
  
 If you do not want `OnIdle` to be called whenever a message is retrieved from the message queue, you can override the [CWinThreadIsIdleMessage](../vs140/cwinthread--isidlemessage.md). If an application has set a very short timer, or if the system is sending the **WM_SYSTIMER** message, then `OnIdle` will be called repeatedly, and degrade performance.  
  
## Example  
 The following two examples show how to use `OnIdle`. The first example processes two idle tasks using the `lCount` argument to prioritize the tasks. The first task is high priority, and you should do it whenever possible. The second task is less important and should be done only when there is a long pause in user input. Note the call to the base-class version of `OnIdle`. The second example manages a group of idle tasks with different priorities.  
  
 [!code[NVC_MFCWindowing#51](../vs140/codesnippet/CPP/cwinapp--onidle_1.cpp)]
  
  
## Second Example  
 [!code[NVC_MFCDocView#187](../vs140/codesnippet/CPP/cwinapp--onidle_2.cpp)]
  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWinApp Class](../vs140/cwinapp-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)