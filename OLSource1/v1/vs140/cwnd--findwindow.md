---
title: "CWnd::FindWindow"
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
  - "CWnd::FindWindow"
  - "FindWindow"
  - "CWnd.FindWindow"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "FindWindow method"
ms.assetid: 72361c9f-3c21-4a15-b3df-fa91f07d274c
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::FindWindow
Returns the top-level <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> whose window class is given by <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> and whose window name, or title, is given by <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Points to a null-terminated string that specifies the window's class name (a **WNDCLASS** structure). If <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is **NULL**, all class names match.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Points to a null-terminated string that specifies the window name (the window's title). If <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is **NULL**, all window names match.  
  
## Return Value  
 Identifies the window that has the specified class name and window name. It is **NULL** if no such window is found.  
  
 The <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>* may be temporary and should not be stored for later use.  
  
## Remarks  
 This function does not search child windows.  
  
## Example  
 [!code[NVC_MFCWindowing#94](../vs140/codesnippet/CPP/cwnd--findwindow_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [FindWindow](http://msdn.microsoft.com/library/windows/desktop/ms633499)