---
title: "CWnd::GetCurrentMessage"
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
  - "GetCurrentMessage"
  - "CWnd.GetCurrentMessage"
  - "CWnd::GetCurrentMessage"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "window message functions"
  - "GetCurrentMessage method"
  - "message functions"
  - "CWnd class, operations"
ms.assetid: 3427f95d-9472-488b-b4a0-4b2d750cee12
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::GetCurrentMessage
Returns a pointer to the message this window is currently processing. Should only be called when in an **On***Message* message-handler member function.  
  
## Syntax  
  
```  
  
static const MSG* PASCAL GetCurrentMessage( );  
```  
  
## Return Value  
 Returns a pointer to the [MSG](../vs140/msg-structure.md) structure that contains the message the window is currently processing. Should only be called when in an **On***Message* handler.  
  
## Example  
 See the example for [CMDIFrameWnd::MDICascade](../vs140/cmdiframewnd--mdicascade.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)