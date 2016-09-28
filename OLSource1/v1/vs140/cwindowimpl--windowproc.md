---
title: "CWindowImpl::WindowProc"
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
  - "CWindowImpl::WindowProc"
  - "CWindowImpl.WindowProc"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "WindowProc method"
ms.assetid: ba0dff17-bbd7-41b2-9fc9-2caaf142133f
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWindowImpl::WindowProc
This static function implements the window procedure.  
  
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
 `WindowProc` uses the default message map (declared with [BEGIN_MSG_MAP](../vs140/begin_msg_map.md)) to direct messages to the appropriate handlers. If necessary, `WindowProc` calls [DefWindowProc](../vs140/cwindowimpl--defwindowproc.md) for additional message processing. If the final message is not handled, `WindowProc` does the following:  
  
-   Performs unsubclassing if the window was unsubclassed.  
  
-   Clears `m_hWnd`.  
  
-   Calls [OnFinalMessage](../vs140/cwindowimpl--onfinalmessage.md) before the window is destroyed.  
  
 You can override `WindowProc` to provide a different mechanism for handling messages.  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [CWindowImpl Class](../vs140/cwindowimpl-class.md)