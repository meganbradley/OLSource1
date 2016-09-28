---
title: "CWnd::GetWindowTextLength"
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
  - "CWnd::GetWindowTextLength"
  - "CWnd.GetWindowTextLength"
  - "GetWindowTextLength"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "window text, length"
  - "GetWindowTextLength method"
ms.assetid: 58bd832b-b1da-488b-9bd0-d9981970f2ca
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::GetWindowTextLength
Returns the length of the `CWnd` object caption title.  
  
## Syntax  
  
```  
  
int GetWindowTextLength( ) const;  
```  
  
## Return Value  
 Specifies the text length in characters, not including any null-termination character. The value is 0 if no such text exists.  
  
## Remarks  
 If `CWnd` is a control, the `GetWindowTextLength` member function returns the length of the text within the control instead of the caption.  
  
 This member function causes the [WM_GETTEXTLENGTH](http://msdn.microsoft.com/library/windows/desktop/ms632628) message to be sent to the `CWnd` object.  
  
## Example  
 See the example for [CWnd::SetWindowText](../vs140/cwnd--setwindowtext.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [GetWindowTextLength](http://msdn.microsoft.com/library/windows/desktop/ms633521)   
 [WM_GETTEXTLENGTH](http://msdn.microsoft.com/library/windows/desktop/ms632628)   
 [CWnd::GetWindowText](../vs140/cwnd--getwindowtext.md)