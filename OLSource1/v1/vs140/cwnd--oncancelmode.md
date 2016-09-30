---
title: "CWnd::OnCancelMode"
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
  - "CWnd.OnCancelMode"
  - "OnCancelMode"
  - "WM_CANCELMODE"
  - "CWnd::OnCancelMode"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnCancelMode method"
  - "WM_CANCELMODE"
ms.assetid: c2686960-7fa5-4ebc-af39-e76e8253a1fe
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::OnCancelMode
The framework calls this member function to inform <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> to cancel any internal mode.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 If the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object has the focus, its <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> member function is called when a dialog box or message box is displayed. This gives the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> the opportunity to cancel modes such as mouse capture.  
  
 The default implementation responds by calling the [ReleaseCapture](http://msdn.microsoft.com/library/windows/desktop/ms646261) Windows function. Override this member function in your derived class to handle other modes.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::Default](../vs140/cwnd--default.md)   
 [ReleaseCapture](http://msdn.microsoft.com/library/windows/desktop/ms646261)   
 [WM_CANCELMODE](http://msdn.microsoft.com/library/windows/desktop/ms632615)