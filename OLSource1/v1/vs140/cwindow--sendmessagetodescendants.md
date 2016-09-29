---
title: "CWindow::SendMessageToDescendants"
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
  - "CWindow.SendMessageToDescendants"
  - "ATL::CWindow::SendMessageToDescendants"
  - "CWindow::SendMessageToDescendants"
  - "ATL.CWindow.SendMessageToDescendants"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SendMessageToDescendants method"
ms.assetid: 2e60ecd5-4191-4cb9-b075-e95d9f468c0f
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWindow::SendMessageToDescendants
Sends the specified message to all immediate children of the `CWindow` object.  
  
## Syntax  
  
```  
  
      void SendMessageToDescendants(  
   UINT message,  
   WPARAM wParam = 0,  
   LPARAM lParam = 0,  
   BOOL bDeep = TRUE   
) throw();  
```  
  
#### Parameters  
 `message`  
 [in] The message to be sent.  
  
 `wParam`  
 [in] Additional message-specific information.  
  
 `lParam`  
 [in] Additional message-specific information.  
  
 `bDeep`  
 [in] If **TRUE** (the default value), the message will be sent to all descendant windows; otherwise, it will be sent only to the immediate child windows.  
  
## Remarks  
 If `bDeep` is **TRUE**, the message is additionally sent to all other descendant windows.  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [CWindow Class](../vs140/cwindow-class.md)   
 [CWindow::SendMessage](../vs140/cwindow--sendmessage.md)   
 [CWindow::SendNotifyMessage](../vs140/cwindow--sendnotifymessage.md)   
 [CWindow::PostMessage](../vs140/cwindow--postmessage.md)