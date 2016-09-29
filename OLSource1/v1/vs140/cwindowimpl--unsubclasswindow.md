---
title: "CWindowImpl::UnsubclassWindow"
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
  - "CWindowImpl.UnsubclassWindow"
  - "UnsubclassWindow"
  - "CWindowImpl::UnsubclassWindow"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "UnsubclassWindow method"
ms.assetid: 907e8421-c242-4a1e-9c4d-206f6eb5793b
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWindowImpl::UnsubclassWindow
Detaches the subclassed window from the `CWindowImpl` object and restores the original window procedure, saved in [m_pfnSuperWindowProc](../vs140/cwindowimpl--m_pfnsuperwindowproc.md).  
  
## Syntax  
  
```  
  
HWND UnsubclassWindow( );  
  
```  
  
## Return Value  
 The handle to the window previously subclassed.  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [CWindowImpl Class](../vs140/cwindowimpl-class.md)   
 [CWindowImpl::SubclassWindow](../vs140/cwindowimpl--subclasswindow.md)