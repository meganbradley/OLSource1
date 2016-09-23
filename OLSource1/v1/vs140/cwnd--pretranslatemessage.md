---
title: "CWnd::PreTranslateMessage"
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
  - CWnd.PreTranslateMessage
  - CWnd::PreTranslateMessage
dev_langs: 
  - C++
helpviewer_keywords: 
  - window message functions
  - translating messages
  - PreTranslateMessage method
  - message functions
  - CWnd class, operations
  - messages, translating
ms.assetid: b5c6f146-c053-405b-bb4e-20a4e4add31c
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CWnd::PreTranslateMessage
Used by class [CWinApp](../vs140/cwinapp-class.md) to translate window messages before they are dispatched to the [TranslateMessage](http://msdn.microsoft.com/library/windows/desktop/ms644955) and [DispatchMessage](http://msdn.microsoft.com/library/windows/desktop/ms644934) Windows functions.  
  
## Syntax  
  
```  
  
      virtual BOOL PreTranslateMessage(  
   MSG* pMsg   
);  
```  
  
#### Parameters  
 `pMsg`  
 Points to a [MSG](../vs140/msg-structure.md) structure that contains the message to process.  
  
## Return Value  
 Nonzero if the message was translated and should not be dispatched; 0 if the message was not translated and should be dispatched.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [TranslateMessage](http://msdn.microsoft.com/library/windows/desktop/ms644955)   
 [IsDialogMessage](http://msdn.microsoft.com/library/windows/desktop/ms645498)   
 [CWinApp::PreTranslateMessage](../vs140/cwinapp--pretranslatemessage.md)