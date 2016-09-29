---
title: "CMFCBaseVisualManager::DrawStatusBarProgress"
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
  - "CMFCBaseVisualManager.DrawStatusBarProgress"
  - "DrawStatusBarProgress"
  - "CMFCBaseVisualManager::DrawStatusBarProgress"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DrawStatusBarProgress method"
ms.assetid: 208d0705-4a6e-4a9c-a833-c5c8e8e06287
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCBaseVisualManager::DrawStatusBarProgress
Draws progress bar on status bar control ([CMFCStatusBar Class](../vs140/cmfcstatusbar-class.md)) using the current Windows theme.  
  
## Syntax  
  
```  
virtual BOOL DrawStatusBarProgress(  
   CDC* pDC,   
   CMFCStatusBar* pStatusBar,   
   CRect rectProgress,   
   int nProgressTotal,   
   int nProgressCurr,  
   COLORREF clrBar,   
   COLORREF clrProgressBarDest,   
   COLORREF clrProgressText,   
   BOOL bProgressText    
);  
```  
  
#### Parameters  
 [in] `pDC`  
 A pointer to a device context.  
  
 [in] `pStatusBar`  
 A pointer to status bar. This value is ignored.  
  
 [in] `rectProgress`  
 The bounding rectangle of the progress bar in `pDC` coordinates.  
  
 [in] `nProgressTotal`  
 The total progress value.  
  
 [in] `nProgressCurr`  
 The current progress value.  
  
 [in] `clrBar`  
 The start color. `CMFCBaseVisualManager` ignores this. Derived classes can use it for color gradients.  
  
 [in] `clrProgressBarDest`  
 The end color. `CMFCBaseVisualManager` ignores this. Derived classes can use it for color gradients.  
  
 [in] `clrProgressText`  
 Progress text color. `CMFCBaseVisualManager` ignores this. The text color is defined by `afxGlobalData.clrBtnText`.  
  
 [in] `bProgressText`  
 Specifies whether to display progress text.  
  
## Return Value  
 `TRUE` if Theme API is enabled; otherwise `FALSE`.  
  
## Requirements  
 **Header:** afxvisualmanager.h  
  
## See Also  
 [CMFCBaseVisualManager Class](../vs140/cmfcbasevisualmanager-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)