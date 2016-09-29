---
title: "CPaneFrameWnd::RemovePane"
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
  - "RemovePane"
  - "CPaneFrameWnd::RemovePane"
  - "CPaneFrameWnd.RemovePane"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "RemovePane method"
ms.assetid: a83fbdb7-1d29-4618-9887-d946d752aab6
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPaneFrameWnd::RemovePane
Removes a pane from the mini-frame window.  
  
## Syntax  
  
```  
virtual void RemovePane(  
   CBasePane* pWnd,  
   BOOL bDestroy = FALSE,  
   BOOL bNoDelayedDestroy = FALSE  
);  
```  
  
#### Parameters  
 [in] `pWnd`  
 A pointer to the pane to remove.  
  
 [in] `bDestroy`  
 Specifies what happens to the mini-frame window. If `bDestroy` is `TRUE`, this method destroys the mini-frame window immediately. If it is `FALSE`, this method destroys the mini-frame window after a certain delay.  
  
 [in] `bNoDelayedDestroy`  
 If `TRUE`, delayed destruction is disabled. If `FALSE`, delayed destruction is enabled.  
  
## Remarks  
 The framework can destroy mini-frame windows immediately or after a certain delay. If you want to delay destruction of mini-frame windows, pass `FALSE` in the `bNoDelayedDestroy` parameter. Delayed destruction occurs when the framework processes the `AFX_WM_CHECKEMPTYMINIFRAME` message.  
  
## Requirements  
 **Header:** afxpaneframewnd.h  
  
## See Also  
 [CPaneFrameWnd Class](../vs140/cpaneframewnd-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)