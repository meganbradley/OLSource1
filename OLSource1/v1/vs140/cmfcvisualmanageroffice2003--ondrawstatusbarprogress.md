---
title: "CMFCVisualManagerOffice2003::OnDrawStatusBarProgress"
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
  - "CMFCVisualManagerOffice2003::OnDrawStatusBarProgress"
  - "CMFCVisualManagerOffice2003.OnDrawStatusBarProgress"
  - "OnDrawStatusBarProgress"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDrawStatusBarProgress method"
ms.assetid: 3c33d82e-4483-47aa-8156-a54fdd16de00
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCVisualManagerOffice2003::OnDrawStatusBarProgress
The framework calls this method when it draws the progress indicator on the [CMFCStatusBar](../vs140/cmfcstatusbar-class.md) object  
  
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
 A pointer to the device context for the status bar  
  
 [in] `pStatusBar`  
 The [CMFCStatusBar](../vs140/cmfcstatusbar-class.md) object that contains the progress bar.  
  
 [in] `rectProgress`  
 A rectangle that specifies the boundaries of the progress bar.  
  
 [in] `nProgressTotal`  
 The total number for the progress bar.  
  
 [in] `nProgressCurr`  
 The current progress for the progress bar.  
  
 [in] `clrBar`  
 The initial color for the progress bar. The value is either the start of a color gradient or the complete color of the progress bar.  
  
 [in] `clrProgressBarDest`  
  [in] `clrProgressText`  
  [in] `bProgressText`  
  
## Remarks  
 Override this method in a derived visual manager to customize the appearance of the progress bar on a status bar.  
  
## Requirements  
 **Header:** afxvisualmanageroffice2003.h  
  
## See Also  
 [CMFCVisualManagerOffice2003 Class](../vs140/cmfcvisualmanageroffice2003-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)