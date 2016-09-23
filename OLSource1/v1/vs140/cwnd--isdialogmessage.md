---
title: "CWnd::IsDialogMessage"
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
  - IsDialogMessage
  - CWnd::IsDialogMessage
  - CWnd.IsDialogMessage
dev_langs: 
  - C++
helpviewer_keywords: 
  - IsDialogMessage method
ms.assetid: 4f68f1eb-c727-4869-8cac-d19bcfa9a934
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CWnd::IsDialogMessage
Call this member function to determine whether the given message is intended for a modeless dialog box; if it is, this function processes the message.  
  
## Syntax  
  
```  
  
      BOOL IsDialogMessage(  
   LPMSG lpMsg   
);  
```  
  
#### Parameters  
 `lpMsg`  
 Points to an [MSG](../vs140/msg-structure.md) structure that contains the message to be checked.  
  
## Return Value  
 Specifies whether the member function has processed the given message. It is nonzero if the message has been processed; otherwise 0. If the return is 0, call the [CWnd::PreTranslateMessage](../vs140/cwnd--pretranslatemessage.md) member function of the base class to process the message. In an override of the `CWnd::PreTranslateMessage` member function the code looks like this :  
  
 [!code[NVC_MFCWindowing#100](../vs140/codesnippet/CPP/cwnd--isdialogmessage_1.cpp)]
  
  
## Remarks  
 When the `IsDialogMessage` function processes a message, it checks for keyboard messages and converts them to selection commands for the corresponding dialog box. For example, the TAB key selects the next control or group of controls, and the DOWN ARROW key selects the next control in a group.  
  
 You must not pass a message processed by `IsDialogMessage` to the [TranslateMessage](http://msdn.microsoft.com/library/windows/desktop/ms644955) or [DispatchMessage](http://msdn.microsoft.com/library/windows/desktop/ms644934) Windows functions, because it has already been processed.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [DispatchMessage](http://msdn.microsoft.com/library/windows/desktop/ms644934)   
 [TranslateMessage](http://msdn.microsoft.com/library/windows/desktop/ms644955)   
 [GetMessage](http://msdn.microsoft.com/library/windows/desktop/ms644936)   
 [CWnd::PreTranslateMessage](../vs140/cwnd--pretranslatemessage.md)   
 [IsDialogMessage](http://msdn.microsoft.com/library/windows/desktop/ms645498)