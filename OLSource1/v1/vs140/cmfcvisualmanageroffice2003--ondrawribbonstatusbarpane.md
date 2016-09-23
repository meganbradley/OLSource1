---
title: "CMFCVisualManagerOffice2003::OnDrawRibbonStatusBarPane"
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
  - CMFCVisualManagerOffice2003.OnDrawRibbonStatusBarPane
  - CMFCVisualManagerOffice2003::OnDrawRibbonStatusBarPane
  - OnDrawRibbonStatusBarPane
dev_langs: 
  - C++
helpviewer_keywords: 
  - OnDrawRibbonStatusBarPane method
ms.assetid: c3be5623-6d37-4586-b235-559e4e375cb0
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCVisualManagerOffice2003::OnDrawRibbonStatusBarPane
The framework calls this method when it draws a pane on the status bar.  
  
## Syntax  
  
```  
virtual COLORREF OnDrawRibbonStatusBarPane(  
   CDC* pDC,  
   CMFCRibbonStatusBar* pBar,  
   CMFCRibbonStatusBarPane* pPane  
);  
```  
  
#### Parameters  
 [in] `pDC`  
 A pointer to a device context.  
  
 [in] `pBar`  
 A pointer to the status bar that contains the pane.  
  
 [in] `pPane`  
 A pointer to a status bar pane. The framework draws this [CMFCRibbonStatusBarPane](../vs140/cmfcribbonstatusbarpane-class.md) object.  
  
## Return Value  
 A reserved value. The default implementation returns -1.  
  
## Remarks  
 Override this method in a derived visual manager to customize the appearance of a pane on the status bar.  
  
## Requirements  
 **Header:** afxvisualmanageroffice2003.h  
  
## See Also  
 [CMFCVisualManagerOffice2003 Class](../vs140/cmfcvisualmanageroffice2003-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)