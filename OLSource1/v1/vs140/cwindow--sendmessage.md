---
title: "CWindow::SendMessage"
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
  - "CWindow.SendMessage"
  - "ATL.CWindow.SendMessage"
  - "ATL::CWindow::SendMessage"
  - "CWindow::SendMessage"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SendMessage method"
ms.assetid: 7c5c3a12-fb7e-422a-8376-1ac91a5cdace
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWindow::SendMessage
Sends a message to the window and does not return until the window procedure has processed the message.  
  
## Syntax  
  
```  
  
      LRESULT SendMessage(  
   UINT message,  
   WPARAM wParam = 0,  
   LPARAM lParam = 0   
) throw();  
static LRESULT SendMessage(  
   HWND hWnd,  
   UINT message,  
   WPARAM wParam,  
   LPARAM lParam   
) throw();  
```  
  
## Remarks  
 See [SendMessage](http://msdn.microsoft.com/library/windows/desktop/ms644950) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 [!code[NVC_ATL_Windowing#29](../vs140/codesnippet/CPP/cwindow--sendmessage_1.cpp)]  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [CWindow Class](../vs140/cwindow-class.md)   
 [CWindow::PostMessage](../vs140/cwindow--postmessage.md)   
 [CWindow::SendNotifyMessage](../vs140/cwindow--sendnotifymessage.md)   
 [CWindow::SendMessageToDescendants](../vs140/cwindow--sendmessagetodescendants.md)