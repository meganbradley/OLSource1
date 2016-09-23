---
title: "CWnd::OnPaintClipboard"
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
  - CWnd::OnPaintClipboard
  - OnPaintClipboard
  - CWnd.OnPaintClipboard
  - WM_PAINTCLIPBOARD
dev_langs: 
  - C++
helpviewer_keywords: 
  - WM_PAINTCLIPBOARD
  - OnPaintClipboard method
ms.assetid: 6f9bcf0e-04e6-4a24-b0f6-baae4617998f
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CWnd::OnPaintClipboard
A Clipboard owner's `OnPaintClipboard` member function is called by a Clipboard viewer when the Clipboard owner has placed data on the Clipboard in the `CF_OWNERDISPLAY` format and the Clipboard viewer's client area needs repainting.  
  
## Syntax  
  
```  
  
      afx_msg void OnPaintClipboard(  
   CWnd* pClipAppWnd,  
   HGLOBAL hPaintStruct   
);  
```  
  
#### Parameters  
 `pClipAppWnd`  
 Specifies a pointer to the Clipboard-application window. The pointer may be temporary and should not be stored for later use.  
  
 *hPaintStruct*  
 Identifies a [PAINTSTRUCT](../vs140/paintstruct-structure.md) data structure that defines what part of the client area to paint.  
  
## Remarks  
 To determine whether the entire client area or just a portion of it needs repainting, the Clipboard owner must compare the dimensions of the drawing area given in the **rcpaint** member of the `PAINTSTRUCT` structure to the dimensions given in the most recent [OnSizeClipboard](../vs140/cwnd--onsizeclipboard.md) member function call.  
  
 `OnPaintClipboard` should use the [GlobalLock](http://msdn.microsoft.com/library/windows/desktop/aa366584) Windows function to lock the memory that contains the `PAINTSTRUCT` data structure and unlock that memory with the [GlobalUnlock](http://msdn.microsoft.com/library/windows/desktop/aa366595) Windows function before it exits.  
  
> [!NOTE]
>  This member function is called by the framework to allow your application to handle a Windows message. The parameters passed to your function reflect the parameters received by the framework when the message was received. If you call the base-class implementation of this function, that implementation will use the parameters originally passed with the message and not the parameters you supply to the function.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [GlobalLock](http://msdn.microsoft.com/library/windows/desktop/aa366584)   
 [GlobalUnlock](http://msdn.microsoft.com/library/windows/desktop/aa366595)   
 [CWnd::OnSizeClipboard](../vs140/cwnd--onsizeclipboard.md)   
 [CWnd::OnPaintClipboard](#_mfc_cwnd.3a3a.onpaintclipboard)