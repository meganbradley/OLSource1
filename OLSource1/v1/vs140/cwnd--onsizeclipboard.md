---
title: "CWnd::OnSizeClipboard"
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
  - "CWnd::OnSizeClipboard"
  - "OnSizeClipboard"
  - "WM_SIZECLIPBOARD"
  - "CWnd.OnSizeClipboard"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "WM_SIZECLIPBOARD"
  - "OnSizeClipboard method"
ms.assetid: c816a33c-f7fa-48c5-948d-700c0db3a425
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::OnSizeClipboard
The Clipboard owner's `OnSizeClipboard` member function is called by the Clipboard viewer when the Clipboard contains data with the `CF_OWNERDISPLAY` attribute and the size of the client area of the Clipboard-viewer window has changed.  
  
## Syntax  
  
```  
  
      afx_msg void OnSizeClipboard(  
   CWnd* pClipAppWnd,  
   HGLOBAL hRect   
);  
```  
  
#### Parameters  
 `pClipAppWnd`  
 Identifies the Clipboard-application window. The pointer may be temporary and should not be stored.  
  
 *hRect*  
 Identifies a global memory object. The memory object contains a [RECT](../vs140/rect-structure.md) data structure that specifies the area for the Clipboard owner to paint.  
  
## Remarks  
 The `OnSizeClipboard` member function is called with a null rectangle (0,0,0,0) as the new size when the Clipboard application is about to be destroyed or minimized. This permits the Clipboard owner to free its display resources.  
  
 Within `OnSizeClipboard`, an application must use the [GlobalLock](http://msdn.microsoft.com/library/windows/desktop/aa366584) Windows function to lock the memory that contains the [RECT](../vs140/rect-structure.md) data structure. Have the application unlock that memory with the [GlobalUnlock](http://msdn.microsoft.com/library/windows/desktop/aa366595) Windows function before it yields or returns control.  
  
> [!NOTE]
>  This member function is called by the framework to allow your application to handle a Windows message. The parameters passed to your function reflect the parameters received by the framework when the message was received. If you call the base-class implementation of this function, that implementation will use the parameters originally passed with the message and not the parameters you supply to the function.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [GlobalLock](http://msdn.microsoft.com/library/windows/desktop/aa366584)   
 [GlobalUnlock](http://msdn.microsoft.com/library/windows/desktop/aa366595)   
 [SetClipboardData](http://msdn.microsoft.com/library/windows/desktop/ms649051)   
 [CWnd::SetClipboardViewer](../vs140/cwnd--setclipboardviewer.md)   
 [WM_SIZECLIPBOARD](http://msdn.microsoft.com/library/windows/desktop/ms649031)