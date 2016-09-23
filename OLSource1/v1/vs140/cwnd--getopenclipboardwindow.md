---
title: "CWnd::GetOpenClipboardWindow"
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
  - GetOpenClipboardWindow
  - CWnd::GetOpenClipboardWindow
  - CWnd.GetOpenClipboardWindow
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetOpenClipboardWindow method
ms.assetid: ff74977b-dabc-4bd2-bb47-18fbf4ef170d
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CWnd::GetOpenClipboardWindow
Retrieves the handle of the window that currently has the Clipboard open.  
  
## Syntax  
  
```  
  
static CWnd* PASCAL GetOpenClipboardWindow( );  
```  
  
## Return Value  
 The handle of the window that currently has the Clipboard open if the function is successful; otherwise **NULL**.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::GetClipboardOwner](../vs140/cwnd--getclipboardowner.md)   
 [CWnd::GetClipboardViewer](../vs140/cwnd--getclipboardviewer.md)   
 [CWnd::OpenClipboard](../vs140/cwnd--openclipboard.md)   
 [GetOpenClipboardWindow](http://msdn.microsoft.com/library/windows/desktop/ms649044)