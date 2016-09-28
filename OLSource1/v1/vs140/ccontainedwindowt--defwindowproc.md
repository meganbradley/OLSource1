---
title: "CContainedWindowT::DefWindowProc"
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
  - "CContainedWindow.DefWindowProc"
  - "CContainedWindowT::DefWindowProc"
  - "CContainedWindow::DefWindowProc"
  - "ATL.CContainedWindowT.DefWindowProc"
  - "ATL::CContainedWindowT::DefWindowProc"
  - "CContainedWindowT.DefWindowProc"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DefWindowProc method"
ms.assetid: e9db4092-a880-497b-a8cc-ee390331feff
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CContainedWindowT::DefWindowProc
Called by [WindowProc](../vs140/ccontainedwindowt--windowproc.md) to process messages not handled by the message map.  
  
## Syntax  
  
```  
  
      LRESULT DefWindowProc( )   
LRESULT DefWindowProc(  
   UINT uMsg,  
   WPARAM wParam,  
   LPARAM lParam   
);  
```  
  
#### Parameters  
 `uMsg`  
 [in] The message sent to the window.  
  
 `wParam`  
 [in] Additional message-specific information.  
  
 `lParam`  
 [in] Additional message-specific information.  
  
## Return Value  
 The result of the message processing.  
  
## Remarks  
 By default, `DefWindowProc` calls the [CallWindowProc](http://msdn.microsoft.com/library/windows/desktop/ms633571) Win32 function to send the message information to the window procedure specified in [m_pfnSuperWindowProc](../vs140/ccontainedwindowt--m_pfnsuperwindowproc.md).  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [CContainedWindowT Class](../vs140/ccontainedwindowt-class.md)