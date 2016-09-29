---
title: "CContainedWindowT::SubclassWindow"
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
  - "ATL::CContainedWindowT::SubclassWindow"
  - "CContainedWindow.SubclassWindow"
  - "CContainedWindowT.SubclassWindow"
  - "CContainedWindowT::SubclassWindow"
  - "CContainedWindow::SubclassWindow"
  - "ATL.CContainedWindowT.SubclassWindow"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SubclassWindow method"
ms.assetid: ddc92f81-79b2-4ec6-8d1f-78b7d4b47011
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CContainedWindowT::SubclassWindow
Subclasses the window identified by `hWnd` and attaches it to the `CContainedWindowT` object.  
  
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
 The subclassed window now uses [CContainedWindowT::WindowProc](../vs140/ccontainedwindowt--windowproc.md). The original window procedure is saved in [m_pfnSuperWindowProc](../vs140/ccontainedwindowt--m_pfnsuperwindowproc.md).  
  
> [!NOTE]
>  Do not call `SubclassWindow` if you have already called [Create](../vs140/ccontainedwindowt--create.md).  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [CContainedWindowT Class](../vs140/ccontainedwindowt-class.md)   
 [CContainedWindowT::UnsubclassWindow](../vs140/ccontainedwindowt--unsubclasswindow.md)