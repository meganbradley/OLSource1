---
title: "CBasePane::MoveWindow"
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
  - "MoveWindow"
  - "CBasePane.MoveWindow"
  - "CBasePane::MoveWindow"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "MoveWindow method"
ms.assetid: 3d207daa-0ce3-48ea-9867-2b640a64ba14
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CBasePane::MoveWindow
Moves the pane.  
  
## Syntax  
  
```  
virtual HDWP MoveWindow(  
   CRect& rect,  
   BOOL bRepaint = TRUE,  
   HDWP hdwp = NULL  
);  
```  
  
#### Parameters  
 [in] `rect`  
 A rectangle specifying the new location and size of the pane.  
  
 [in] `bRepaint`  
 If `TRUE`, the pane is repainted. If `FALSE`, the pane is not repainted.  
  
 [in] `hdwp`  
 Handle to a deferred window position structure.  
  
## Return Value  
 A handle to a deferred window position structure, or `NULL`.  
  
## Remarks  
 If you pass `NULL` as the `hdwp` parameter, this method moves the window normally. If you pass a handle, this method performs a deferred window move. You can obtain a handle by calling [BeginDeferWindowPos](http://msdn.microsoft.com/library/windows/desktop/ms632672) or by storing the return value of a previous call to this method.  
  
## Requirements  
 **Header:** afxbasepane.h  
  
## See Also  
 [CBasePane Class](../vs140/cbasepane-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)