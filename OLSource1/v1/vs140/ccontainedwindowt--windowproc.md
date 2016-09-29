---
title: "CContainedWindowT::WindowProc"
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
  - "CContainedWindow.WindowProc"
  - "CContainedWindowT::WindowProc"
  - "ATL.CContainedWindowT.WindowProc"
  - "CContainedWindow::WindowProc"
  - "CContainedWindowT.WindowProc"
  - "ATL::CContainedWindowT::WindowProc"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "WindowProc method"
ms.assetid: 9e9435b2-f767-4d73-be2b-92b7e4334640
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CContainedWindowT::WindowProc
This static method implements the window procedure.  
  
## Syntax  
  
```  
  
      static LRESULT CALLBACK WindowProc(  
   HWND hWnd,  
   UINT uMsg,  
   WPARAM wParam,  
   LPARAM lParam   
);  
```  
  
#### Parameters  
 `hWnd`  
 [in] The handle to the window.  
  
 `uMsg`  
 [in] The message sent to the window.  
  
 `wParam`  
 [in] Additional message-specific information.  
  
 `lParam`  
 [in] Additional message-specific information.  
  
## Return Value  
 The result of the message processing.  
  
## Remarks  
 `WindowProc` directs messages to the message map identified by [m_dwMsgMapID](../vs140/ccontainedwindowt--m_dwmsgmapid.md). If necessary, `WindowProc` calls [DefWindowProc](../vs140/ccontainedwindowt--defwindowproc.md) for additional message processing.  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [CContainedWindowT Class](../vs140/ccontainedwindowt-class.md)   
 [BEGIN_MSG_MAP](../vs140/begin_msg_map.md)   
 [ALT_MSG_MAP](../vs140/alt_msg_map.md)