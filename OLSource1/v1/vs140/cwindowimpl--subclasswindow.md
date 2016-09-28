---
title: "CWindowImpl::SubclassWindow"
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
  - "CWindowImpl::SubclassWindow"
  - "CWindowImpl.SubclassWindow"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SubclassWindow method"
ms.assetid: 62ebbca3-fa81-4a2e-bf90-1dc309d53dab
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWindowImpl::SubclassWindow
Subclasses the window identified by `hWnd` and attaches it to the `CWindowImpl` object.  
  
## Syntax  
  
```  
  
      BOOL SubclassWindow(  
   HWND hWnd   
);  
```  
  
#### Parameters  
 `hWnd`  
 [in] The handle to the window being subclassed.  
  
## Return Value  
 **TRUE** if the window is successfully subclassed; otherwise, **FALSE**.  
  
## Remarks  
 The subclassed window now uses [CWindowImpl::WindowProc](../vs140/cwindowimpl--windowproc.md). The original window procedure is saved in [m_pfnSuperWindowProc](../vs140/cwindowimpl--m_pfnsuperwindowproc.md).  
  
> [!NOTE]
>  Do not call `SubclassWindow` if you have already called [Create](../vs140/cwindowimpl--create.md).  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [CWindowImpl Class](../vs140/cwindowimpl-class.md)   
 [CWindowImpl::UnsubclassWindow](../vs140/cwindowimpl--unsubclasswindow.md)