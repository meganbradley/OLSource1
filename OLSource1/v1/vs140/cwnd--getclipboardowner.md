---
title: "CWnd::GetClipboardOwner"
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
  - CWnd::GetClipboardOwner
  - GetClipboardOwner
  - CWnd.GetClipboardOwner
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetClipboardOwner method
ms.assetid: 58687b5e-0ec9-4491-8bb4-3ee324879205
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CWnd::GetClipboardOwner
Retrieves the current owner of the Clipboard.  
  
## Syntax  
  
```  
  
static CWnd* PASCAL GetClipboardOwner( );  
```  
  
## Return Value  
 Identifies the window that owns the Clipboard if the function is successful. Otherwise, it is **NULL**.  
  
 The returned pointer may be temporary and should not be stored for later use.  
  
## Remarks  
 The Clipboard can still contain data even if it is not currently owned.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::GetClipboardViewer](../vs140/cwnd--getclipboardviewer.md)   
 [GetClipboardOwner](http://msdn.microsoft.com/library/windows/desktop/ms649041)