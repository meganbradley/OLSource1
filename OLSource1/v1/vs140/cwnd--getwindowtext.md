---
title: "CWnd::GetWindowText"
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
  - "CWnd.GetWindowText"
  - "CWnd::GetWindowText"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "window text, getting"
  - "GetWindowText method"
ms.assetid: 22106e9d-9925-4a96-b2f9-e7d95c5cd2a3
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::GetWindowText
Copies the `CWnd` caption title (if it has one) into the buffer pointed to by `lpszStringBuf` or into the destination string `rString`.  
  
## Syntax  
  
```  
  
      int GetWindowText(  
   LPTSTR lpszStringBuf,  
   int nMaxCount   
) const;  
void GetWindowText(  
   CString& rString   
) const;  
```  
  
#### Parameters  
 `lpszStringBuf`  
 Points to the buffer that is to receive the copied string of the window's title.  
  
 `nMaxCount`  
 Specifies the maximum number of characters to be copied to the buffer, including the terminating null character. If the string is longer than the number of characters specified in `nMaxCount`, it is truncated.  
  
 `rString`  
 A [CString](../vs140/cstringt-class.md) object that is to receive the copied string of the window's title.  
  
## Return Value  
 Specifies the length, in characters, of the copied string, not including the terminating null character. It is 0 if `CWnd` has no caption or if the caption is empty.  
  
## Remarks  
 If the `CWnd` object is a control, the `GetWindowText` member function copies the text within the control instead of copying the caption.  
  
 This member function causes the [WM_GETTEXT](http://msdn.microsoft.com/library/windows/desktop/ms632627) message to be sent to the `CWnd` object.  
  
## Example  
 See the example for [CWnd::SetWindowText](../vs140/cwnd--setwindowtext.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::SetWindowText](../vs140/cwnd--setwindowtext.md)   
 [WM_GETTEXT](http://msdn.microsoft.com/library/windows/desktop/ms632627)   
 [CWnd::GetWindowTextLength](../vs140/cwnd--getwindowtextlength.md)