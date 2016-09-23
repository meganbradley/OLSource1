---
title: "CWnd::SendMessage"
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
  - CWnd::SendMessage
  - CWnd.SendMessage
dev_langs: 
  - C++
helpviewer_keywords: 
  - window message functions
  - SendMessage method
  - messages, sending
  - message functions
ms.assetid: ba72b0bd-57ec-4ef5-bee4-f5dbb971f927
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CWnd::SendMessage
Sends the specified message to this window.  
  
## Syntax  
  
```  
  
      LRESULT SendMessage(  
   UINT message,  
   WPARAM wParam = 0,  
   LPARAM lParam = 0   
);  
```  
  
#### Parameters  
 `message`  
 Specifies the message to be sent.  
  
 `wParam`  
 Specifies additional message-dependent information.  
  
 `lParam`  
 Specifies additional message-dependent information.  
  
## Return Value  
 The result of the message processing; its value depends on the message sent.  
  
## Remarks  
 The **SendMessage** member function calls the window procedure directly and does not return until that window procedure has processed the message. This is in contrast to the [PostMessage](../vs140/cwnd--postmessage.md) member function, which places the message into the window's message queue and returns immediately.  
  
## Example  
 [!code[NVC_MFCWindowing#101](../vs140/codesnippet/CPP/cwnd--sendmessage_1.cpp)]
  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [InSendMessage](http://msdn.microsoft.com/library/windows/desktop/ms644941)   
 [CWnd::PostMessage](../vs140/cwnd--postmessage.md)   
 [CWnd::SendDlgItemMessage](../vs140/cwnd--senddlgitemmessage.md)   
 [SendMessage](http://msdn.microsoft.com/library/windows/desktop/ms644950)