---
title: "CWnd::OnShowWindow"
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
  - "CWnd.OnShowWindow"
  - "CWnd::OnShowWindow"
  - "OnShowWindow"
  - "WM_SHOWWINDOW"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnShowWindow method"
  - "WM_SHOWWINDOW"
ms.assetid: 21896315-1b23-455c-8e79-8eb9240ec9b5
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::OnShowWindow
The framework calls this member function when the `CWnd` object is about to be hidden or shown.  
  
## Syntax  
  
```  
  
      afx_msg void OnShowWindow(  
   BOOL bShow,  
   UINT nStatus   
);  
```  
  
#### Parameters  
 `bShow`  
 Specifies whether a window is being shown. It is **TRUE** if the window is being shown; it is **FALSE** if the window is being hidden.  
  
 `nStatus`  
 Specifies the status of the window being shown. It is 0 if the message is sent because of a `ShowWindow` member function call; otherwise `nStatus` is one of the following:  
  
-   **SW_PARENTCLOSING** Parent window is closing (being made iconic) or a pop-up window is being hidden.  
  
-   **SW_PARENTOPENING** Parent window is opening (being displayed) or a pop-up window is being shown.  
  
## Remarks  
 A window is hidden or shown when the `ShowWindow` member function is called, when an overlapped window is maximized or restored, or when an overlapped or pop-up window is closed (made iconic) or opened (displayed on the screen). When an overlapped window is closed, all pop-up windows associated with that window are hidden.  
  
> [!NOTE]
>  This member function is called by the framework to allow your application to handle a Windows message. The parameters passed to your function reflect the parameters received by the framework when the message was received. If you call the base-class implementation of this function, that implementation will use the parameters originally passed with the message and not the parameters you supply to the function.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [WM_SHOWWINDOW](http://msdn.microsoft.com/library/windows/desktop/ms632645)