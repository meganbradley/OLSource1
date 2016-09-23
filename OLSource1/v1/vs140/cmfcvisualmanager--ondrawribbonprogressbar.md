---
title: "CMFCVisualManager::OnDrawRibbonProgressBar"
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
  - OnDrawRibbonProgressBar
  - CMFCVisualManager.OnDrawRibbonProgressBar
  - CMFCVisualManager::OnDrawRibbonProgressBar
dev_langs: 
  - C++
helpviewer_keywords: 
  - OnDrawRibbonProgressBar method
ms.assetid: 7a81112d-d23f-497d-a201-f27511f02822
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCVisualManager::OnDrawRibbonProgressBar
The framework calls this method when it draws a [CMFCRibbonProgressBar Class](../vs140/cmfcribbonprogressbar-class.md).  
  
## Syntax  
  
```  
virtual void OnDrawRibbonProgressBar(  
   CDC* pDC,  
   CMFCRibbonProgressBar* pProgress,  
   CRect rectProgress,  
   CRect rectChunk,  
   BOOL bInfiniteMode  
);  
```  
  
#### Parameters  
 [in] `pDC`  
 A pointer to a device context.  
  
 [in] `pProgress`  
 A pointer to a `CMFCRibbonProgressBar` object. The framework draws this progress bar.  
  
 [in] `rectProgress`  
 A rectangle that specifies the boundaries of the progress bar.  
  
 [in] `rectChunk`  
 A rectangle that specifies the boundaries of the area surrounding the progress bar.  
  
 [in] `bInfiniteMode`  
 A Boolean parameter that indicates the mode of the progress bar. A value of `TRUE` means the bar is in infinite mode. The default implementation does not use this parameter.  
  
## Remarks  
 Override this method in a derived class to customize the appearance of a progress bar.  
  
## Requirements  
 **Header:** afxvisualmanager.h  
  
## See Also  
 [CMFCVisualManager Class](../vs140/cmfcvisualmanager-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCRibbonProgressBar Class](../vs140/cmfcribbonprogressbar-class.md)