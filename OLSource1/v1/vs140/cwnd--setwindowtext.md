---
title: "CWnd::SetWindowText"
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
  - "CWnd::SetWindowText"
  - "CWnd.SetWindowText"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "window text, setting"
  - "title text setting"
  - "SetWindowText method"
  - "window text"
  - "text, window"
ms.assetid: d31d7a10-d215-4e62-80aa-fba2a51effb3
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::SetWindowText
Sets the window's title to the specified text.  
  
## Syntax  
  
```  
  
      void SetWindowText(  
   LPCTSTR lpszString   
);  
```  
  
#### Parameters  
 `lpszString`  
 Points to a [CString](../vs140/cstringt-class.md) object or null-terminated string to be used as the new title or control text.  
  
## Remarks  
 If the window is a control, the text within the control is set.  
  
 This function causes a [WM_SETTEXT](http://msdn.microsoft.com/library/windows/desktop/ms632644) message to be sent to this window.  
  
## Example  
 [!code[NVC_MFCWindowing#121](../vs140/codesnippet/CPP/cwnd--setwindowtext_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::GetWindowText](../vs140/cwnd--getwindowtext.md)   
 [SetWindowText](http://msdn.microsoft.com/library/windows/desktop/ms633546)