---
title: "CMFCVisualManager::OnDrawStatusBarSizeBox"
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
  - "CMFCVisualManager::OnDrawStatusBarSizeBox"
  - "CMFCVisualManager.OnDrawStatusBarSizeBox"
  - "OnDrawStatusBarSizeBox"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDrawStatusBarSizeBox method"
ms.assetid: fababf74-5757-4518-9c1d-266279653b85
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCVisualManager::OnDrawStatusBarSizeBox
The framework calls this method when it draws the size box for a [CMFCStatusBar](../vs140/cmfcstatusbar-class.md).  
  
## Syntax  
  
```  
virtual void OnDrawStatusBarSizeBox(  
   CDC* pDC,  
   CMFCStatusBar* pStatBar,  
   CRect rectSizeBox  
);  
```  
  
#### Parameters  
 [in] `pDC`  
 A pointer to a device context.  
  
 [in] `pStatBar`  
 A pointer to a status bar. The framework draws the size box for this status bar.  
  
 [in] `rectSizeBox`  
 A rectangle that specifies the boundaries of the size box.  
  
## Remarks  
 Override this method in a derived visual manager to customize the appearance of the size box on a `CMFCStatusBar`.  
  
## Requirements  
 **Header:** afxvisualmanager.h  
  
## See Also  
 [CMFCVisualManager Class](../vs140/cmfcvisualmanager-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCStatusBar Class](../vs140/cmfcstatusbar-class.md)