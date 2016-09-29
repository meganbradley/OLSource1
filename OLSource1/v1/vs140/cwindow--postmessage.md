---
title: "CWindow::PostMessage"
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
  - "ATL.CWindow.PostMessage"
  - "ATL::CWindow::PostMessage"
  - "CWindow.PostMessage"
  - "CWindow::PostMessage"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "PostMessage method"
ms.assetid: f778a4c1-7ee2-4c77-8076-90fca2724a1d
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWindow::PostMessage
Places a message in the message queue associated with the thread that created the window.  
  
## Syntax  
  
```  
  
      BOOL PostMessage(  
   UINT message,  
   WPARAM wParam = 0,  
   LPARAM lParam = 0   
) throw();  
```  
  
## Remarks  
 See [PostMessage](http://msdn.microsoft.com/library/windows/desktop/ms644944) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 Returns without waiting for the thread to process the message.  
  
## Example  
 [!code[NVC_ATL_Windowing#27](../vs140/codesnippet/CPP/cwindow--postmessage_1.cpp)]  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [CWindow Class](../vs140/cwindow-class.md)   
 [CWindow::SendMessage](../vs140/cwindow--sendmessage.md)   
 [CWindow::SendNotifyMessage](../vs140/cwindow--sendnotifymessage.md)