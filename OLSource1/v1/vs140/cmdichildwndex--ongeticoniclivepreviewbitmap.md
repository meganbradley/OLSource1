---
title: "CMDIChildWndEx::OnGetIconicLivePreviewBitmap"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - OnGetIconicLivePreviewBitmap
  - afxmdichildwndex/CMDIChildWndEx::OnGetIconicLivePreviewBitmap
dev_langs: 
  - C++
helpviewer_keywords: 
  - OnGetIconicLivePreviewBitmap
ms.assetid: 3431009f-109d-4625-a073-f6b7c077c6c7
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMDIChildWndEx::OnGetIconicLivePreviewBitmap
Called by the framework when it needs to obtain a bitmap for live preview of the MDI child.  
  
## Syntax  
  
```  
virtual HBITMAP OnGetIconicLivePreviewBitmap(  
   BOOL bIsMDIChildActive,  
   CPoint& ptLocation  
);  
```  
  
#### Parameters  
 `bIsMDIChildActive`  
 This parameter is `TRUE` if the bitmap is requested for the MDI child, which is currently active and the main window is not minimized. The default processing in this case takes a snapshot of the main window.  
  
 `ptLocation`  
 Specifies the location of the bitmap in the main (top level) window client coordinates. This point should be provided by the callee.  
  
## Return Value  
 If processed, returns a handle to a valid 32bpp bitmap, otherwise `NULL`.  
  
## Remarks  
 Override this method in a derived class and return a valid 32bpp bitmap for live preview of MDI child. This method is called only when the MDI child is displayed on Windows 7 taskbar tabs. If you return `NULL`, MFC calls the default handlers and obtains bitmaps using `PrintClient` or `PrintWindow`.  
  
## Requirements  
 **Header:** afxmdichildwndex.h  
  
## See Also  
 [CMDIChildWndEx Class](../vs140/cmdichildwndex-class.md)