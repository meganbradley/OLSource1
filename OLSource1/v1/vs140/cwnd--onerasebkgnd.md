---
title: "CWnd::OnEraseBkgnd"
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
  - CWnd::OnEraseBkgnd
  - WM_ERASEBKGND
  - CWnd.OnEraseBkgnd
  - OnEraseBkgnd
dev_langs: 
  - C++
helpviewer_keywords: 
  - CWnd::OnEraseBkgnd
  - WM_ERASEBKGND
  - OnEraseBkgnd method
ms.assetid: 8ec6806f-fd8b-4190-b469-0367d2b29dad
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CWnd::OnEraseBkgnd
The framework calls this member function when the `CWnd` object background needs erasing (for example, when resized).  
  
## Syntax  
  
```  
  
      afx_msg BOOL OnEraseBkgnd(  
   CDC* pDC   
);  
```  
  
#### Parameters  
 `pDC`  
 Specifies the device-context object.  
  
## Return Value  
 Nonzero if it erases the background; otherwise 0.  
  
## Remarks  
 It is called to prepare an invalidated region for painting.  
  
 The default implementation erases the background using the window class background brush specified by the **hbrBackground** member of the window class structure.  
  
 If the **hbrBackground** member is **NULL**, your overridden version of `OnEraseBkgnd` should erase the background color. Your version should also align the origin of the intended brush with the `CWnd` coordinates by first calling [UnrealizeObject](http://msdn.microsoft.com/library/windows/desktop/dd145164) for the brush, and then selecting the brush.  
  
 An overridden `OnEraseBkgnd` should return nonzero in response to `WM_ERASEBKGND` if it processes the message and erases the background; this indicates that no further erasing is required. If it returns 0, the window will remain marked as needing to be erased. (Typically, this means that the **fErase** member of the `PAINTSTRUCT` structure will be **TRUE**.)  
  
 Windows assumes the background is computed with the `MM_TEXT` mapping mode. If the device context is using any other mapping mode, the area erased may not be within the visible part of the client area.  
  
> [!NOTE]
>  This member function is called by the framework to allow your application to handle a Windows message. The parameters passed to your function reflect the parameters received by the framework when the message was received. If you call the base-class implementation of this function, that implementation will use the parameters originally passed with the message and not the parameters you supply to the function.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::OnIconEraseBkgnd](../vs140/cwnd--oniconerasebkgnd.md)   
 [CGdiObject::UnrealizeObject](../vs140/cgdiobject--unrealizeobject.md)   
 [WM_ERASEBKGND](http://msdn.microsoft.com/library/windows/desktop/ms648055)