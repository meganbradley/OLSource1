---
title: "CWnd::GetClipboardViewer"
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
  - "CWnd.GetClipboardViewer"
  - "CWnd::GetClipboardViewer"
  - "GetClipboardViewer"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetClipboardViewer method"
ms.assetid: 56e84705-2961-4797-91a8-5b0f19c3d1db
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::GetClipboardViewer
Retrieves the first window in the Clipboard-viewer chain.  
  
## Syntax  
  
```  
  
static CWnd* PASCAL GetClipboardViewer( );  
```  
  
## Return Value  
 Identifies the window currently responsible for displaying the Clipboard if successful; otherwise **NULL** (for example, if there is no viewer).  
  
 The returned pointer may be temporary and should not be stored for later use.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::GetClipboardOwner](../vs140/cwnd--getclipboardowner.md)   
 [GetClipboardViewer](http://msdn.microsoft.com/library/windows/desktop/ms649043)