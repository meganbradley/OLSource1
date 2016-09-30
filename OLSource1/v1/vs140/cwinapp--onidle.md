---
title: "CWinApp::OnIdle"
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
  - "CWinApp::OnIdle"
  - "CWinApp.OnIdle"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnIdle method"
  - "idle processing"
  - "CWinApp class, overridables"
ms.assetid: 29094045-b29b-4239-ba1f-7831b79ad2d7
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinApp::OnIdle
Override this member function to perform idle-time processing.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A counter incremented each time <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is called when the application's message queue is empty. This count is reset to 0 each time a new message is processed. You can use the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> parameter to determine the relative length of time the application has been idle without processing a message.  
  
## Return Value  
 Nonzero to receive more idle processing time; 0 if no more idle time is needed.  
  
## Remarks  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is called in the default message loop when the application's message queue is empty. Use your override to call your own background idle-handler tasks.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> should return 0 to indicate that no idle processing time is required. The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> parameter is incremented each time <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is called when the message queue is empty and resets to 0 each time a new message is processed. You can call your different idle routines based on this count.  
  
 The following summarizes idle loop processing:  
  
1.  If the message loop in the Microsoft Foundation Class Library checks the message queue and finds no pending messages, it calls <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> for the application object and supplies 0 as the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> argument.  
  
2.  <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> performs some processing and returns a nonzero value to indicate it should be called again to do further processing.  
  
3.  The message loop checks the message queue again. If no messages are pending, it calls <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> again, incrementing the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> argument.  
  
4.  Eventually, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> finishes processing all its idle tasks and returns 0. This tells the message loop to stop calling <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> until the next message is received from the message queue, at which point the idle cycle restarts with the argument set to 0.  
  
 Do not perform lengthy tasks during <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> because your application cannot process user input until <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> returns.  
  
> [!NOTE]
>  The default implementation of <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> updates command user-interface objects such as menu items and toolbar buttons, and it performs internal data structure cleanup. Therefore, if you override <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, you must call <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> with the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> in your overridden version. First call all base-class idle processing (that is, until the base class <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> returns 0). If you need to perform work before the base-class processing completes, review the base-class implementation to select the proper <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> during which to do your work.  
  
 If you do not want <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> to be called whenever a message is retrieved from the message queue, you can override the [CWinThreadIsIdleMessage](../vs140/cwinthread--isidlemessage.md). If an application has set a very short timer, or if the system is sending the **WM_SYSTIMER** message, then <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> will be called repeatedly, and degrade performance.  
  
## Example  
 The following two examples show how to use <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>. The first example processes two idle tasks using the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> argument to prioritize the tasks. The first task is high priority, and you should do it whenever possible. The second task is less important and should be done only when there is a long pause in user input. Note the call to the base-class version of <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>. The second example manages a group of idle tasks with different priorities.  
  
 [!code[NVC_MFCWindowing#51](../vs140/codesnippet/CPP/cwinapp--onidle_1.cpp)]  
  
## Second Example  
 [!code[NVC_MFCDocView#187](../vs140/codesnippet/CPP/cwinapp--onidle_2.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWinApp Class](../vs140/cwinapp-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)