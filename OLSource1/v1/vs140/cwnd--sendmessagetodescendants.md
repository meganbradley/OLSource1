---
title: "CWnd::SendMessageToDescendants"
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
  - "CWnd.SendMessageToDescendants"
  - "CWnd::SendMessageToDescendants"
  - "SendMessageToDescendants"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "messages, sending"
  - "SendMessageToDescendants method"
  - "child windows, messages"
  - "message functions"
ms.assetid: e1b1a63f-93ed-4fd0-84cf-245b716cb1d7
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::SendMessageToDescendants
Call this member function to send the specified Windows message to all descendant windows.  
  
## Syntax  
  
```  
  
      void SendMessageToDescendants(  
   UINT message,  
   WPARAM wParam = 0,  
   LPARAM lParam = 0,  
   BOOL bDeep = TRUE,  
   BOOL bOnlyPerm = FALSE   
);  
```  
  
#### Parameters  
 `message`  
 Specifies the message to be sent.  
  
 `wParam`  
 Specifies additional message-dependent information.  
  
 `lParam`  
 Specifies additional message-dependent information.  
  
 `bDeep`  
 Specifies the level to which to search. If **TRUE**, recursively search all children; if **FALSE**, search only immediate children.  
  
 `bOnlyPerm`  
 Specifies whether the message will be received by temporary windows. If **TRUE**, temporary windows can receive the message; if **FALSE**, only permanent windows receive the message. For more information on temporary windows see [Technical Note 3](../vs140/tn003--mapping-of-windows-handles-to-objects.md).  
  
## Remarks  
 If `bDeep` is **FALSE**, the message is sent just to the immediate children of the window; otherwise the message is sent to all descendant windows.  
  
 If `bDeep` and `bOnlyPerm` are **TRUE**, the search continues below temporary windows. In this case, only permanent windows encountered during the search receive the message. If `bDeep` is **FALSE**, the message is sent only to the immediate children of the window.  
  
## Example  
 [!code[NVC_MFCWindowing#114](../vs140/codesnippet/CPP/cwnd--sendmessagetodescendants_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::SendMessage](../vs140/cwnd--sendmessage.md)   
 [CWnd::FromHandlePermanent](../vs140/cwnd--fromhandlepermanent.md)   
 [CWnd::FromHandle](../vs140/cwnd--fromhandle.md)