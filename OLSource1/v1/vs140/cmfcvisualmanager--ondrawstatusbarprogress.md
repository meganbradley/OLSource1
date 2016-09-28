---
title: "CMFCVisualManager::OnDrawStatusBarProgress"
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
  - "CMFCVisualManager::OnDrawStatusBarProgress"
  - "CMFCVisualManager.OnDrawStatusBarProgress"
  - "OnDrawStatusBarProgress"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDrawStatusBarProgress method"
ms.assetid: 22a99c83-e6da-4826-961b-c19cb5255358
caps.latest.revision: 17
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCVisualManager::OnDrawStatusBarProgress
The framework calls this method when it draws the progress indicator on the [CMFCStatusBar](../vs140/cmfcstatusbar-class.md) object.  
  
## Syntax  
  
```  
virtual void OnDrawStatusBarProgress(  
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
 A pointer to the device context for the status bar.  
  
 [in] `pStatusBar`  
 The `CMFCStatusBar` object that contains the progress bar.  
  
 [in] `rectProgress`  
 A rectangle that specifies the boundaries of the progress bar.  
  
 [in] `nProgressTotal`  
 The total number for the progress bar.  
  
 [in] `nProgressCurr`  
 The current progress for the progress bar.  
  
 [in] `clrBar`  
 A [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449) parameter that indicates the initial color for the progress bar. The value is either the start of a color gradient or the complete color of the progress bar.  
  
 [in] `clrProgressBarDest`  
 A `COLORREF` parameter that indicates the end of a color gradient for the progress bar. If `clrProgressBarDest` is -1, the framework does not draw the progress bar as a color gradient. Instead, it fills the whole progress bar with the color specified by `clrBar`.  
  
 [in] `clrProgressText`  
 A `COLORREF` parameter that indicates the text color for the textual representation of the current progress. This parameter is ignored if `bProgressText` is set to `FALSE`.  
  
 [in] `bProgressText`  
 A Boolean parameter that indicates whether to display the textual representation of the current progress.  
  
## Remarks  
 Override this method in a derived visual manager to customize the appearance of the `CMFCStatusBar` object.  
  
## Requirements  
 **Header:** afxvisualmanager.h  
  
## See Also  
 [CMFCVisualManager Class](../vs140/cmfcvisualmanager-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCStatusBar Class](../vs140/cmfcstatusbar-class.md)