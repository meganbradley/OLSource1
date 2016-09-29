---
title: "CWnd::ShowCaret"
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
  - "CWnd::ShowCaret"
  - "CWnd.ShowCaret"
  - "ShowCaret"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ShowCaret method"
  - "carets"
  - "displaying carets"
  - "carets, showing"
ms.assetid: 0fa9ffdb-e941-496f-ad0b-6a253c951e9f
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::ShowCaret
Shows the caret on the screen at the caret's current position.  
  
## Syntax  
  
```  
  
void ShowCaret( );  
```  
  
## Remarks  
 Once shown, the caret begins flashing automatically.  
  
 The `ShowCaret` member function shows the caret only if it has a current shape and has not been hidden two or more times consecutively. If the caret is not owned by this window, the caret is not shown.  
  
 Hiding the caret is cumulative. If the [HideCaret](../vs140/cwnd--hidecaret.md) member function has been called five times consecutively, `ShowCaret` must be called five times to show the caret.  
  
 The caret is a shared resource. The window should show the caret only when it has the input focus or is active.  
  
## Example  
 See the example for [CWnd::CreateCaret](../vs140/cwnd--createcaret.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::HideCaret](../vs140/cwnd--hidecaret.md)   
 [ShowCaret](http://msdn.microsoft.com/library/windows/desktop/ms648406)