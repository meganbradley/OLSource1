---
title: "CWnd::UnsubclassWindow"
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
  - "UnsubclassWindow"
  - "CWnd::UnsubclassWindow"
  - "CWnd.UnsubclassWindow"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "unsubclassing windows"
  - "subclassing functions"
  - "Windows state [C++]"
  - "UnsubclassWindow method"
ms.assetid: efe988a1-40f0-4c1e-9145-b2e0fdf279fa
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::UnsubclassWindow
Call this member function to set **WndProc** back to its original value and detach the window identified by `HWND` from the **CWnd** object.  
  
## Syntax  
  
```  
  
HWND UnsubclassWindow( );  
```  
  
## Return Value  
 A handle to the unsubclassed window.  
  
## Example  
 See the example for [CWnd::SubclassWindow](../vs140/cwnd--subclasswindow.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::SubclassWindow](../vs140/cwnd--subclasswindow.md)   
 [CWnd::PreSubclassWindow](../vs140/cwnd--presubclasswindow.md)   
 [CWnd::DefWindowProc](../vs140/cwnd--defwindowproc.md)   
 [CWnd::SubclassDlgItem](../vs140/cwnd--subclassdlgitem.md)   
 [CWnd::Attach](../vs140/cwnd--attach.md)