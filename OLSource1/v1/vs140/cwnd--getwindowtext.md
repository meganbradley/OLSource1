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
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::GetWindowText
Copies the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> caption title (if it has one) into the buffer pointed to by <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> or into the destination string <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Points to the buffer that is to receive the copied string of the window's title.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Specifies the maximum number of characters to be copied to the buffer, including the terminating null character. If the string is longer than the number of characters specified in <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, it is truncated.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 A [CString](../vs140/cstringt-class.md) object that is to receive the copied string of the window's title.  
  
## Return Value  
 Specifies the length, in characters, of the copied string, not including the terminating null character. It is 0 if <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> has no caption or if the caption is empty.  
  
## Remarks  
 If the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object is a control, the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> member function copies the text within the control instead of copying the caption.  
  
 This member function causes the [WM_GETTEXT](http://msdn.microsoft.com/library/windows/desktop/ms632627) message to be sent to the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> object.  
  
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