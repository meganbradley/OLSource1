---
title: "CBasePane::SetWindowPos"
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
  - "CBasePane::SetWindowPos"
  - "SetWindowPos"
  - "CBasePane.SetWindowPos"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetWindowPos"
  - "CBasePane.SetWindowPos"
  - "CBasePane::SetWindowPos"
ms.assetid: 28c23155-6660-4d70-8912-4c59d52a3390
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CBasePane::SetWindowPos
Changes the size, position, and Z-order of a pane.  
  
## Syntax  
  
```  
virtual HDWP SetWindowPos(  
   const CWnd* pWndInsertAfter,  
   int x,  
   int y,  
   int cx,  
   int cy,  
   UINT nFlags,  
   HDWP hdwp = NULL  
);  
```  
  
#### Parameters  
 [in] `pWndInsertAfter`  
 Identifies the `CWnd` object that comes before this `CWnd` object in the Z-order. For more information, see [CWnd::SetWindowPos](../vs140/cwnd--setwindowpos.md).  
  
 [in] `x`  
 Specifies the position of the left side of the window.  
  
 [in] `y`  
 Specifies the position of the top of the window.  
  
 [in] `cx`  
 Specifies the width of the window.  
  
 [in] `cy`  
 Specifies the height of the window.  
  
 [in] `nFlags`  
 Specifies size and position options. For more information, see [CWnd::SetWindowPos](../vs140/cwnd--setwindowpos.md).  
  
 [in] `hdwp`  
 Handle to a structure that contains size and position information for one or more windows.  
  
## Return Value  
 A handle to an updated deferred window position structure, or `NULL`.  
  
## Remarks  
 If `pWndInsertAfter` is `NULL`, this method calls [CWnd::SetWindowPos](../vs140/cwnd--setwindowpos.md). If `pWndInsertAfter` is non-`NULL`, this method calls `DeferWindowPos`.  
  
## Requirements  
 **Header:** afxbasepane.h  
  
## See Also  
 [CBasePane Class](../vs140/cbasepane-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)