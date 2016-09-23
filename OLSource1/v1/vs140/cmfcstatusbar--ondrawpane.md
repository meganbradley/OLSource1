---
title: "CMFCStatusBar::OnDrawPane"
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
  - CMFCStatusBar::OnDrawPane
  - OnDrawPane
  - CMFCStatusBar.OnDrawPane
dev_langs: 
  - C++
helpviewer_keywords: 
  - OnDrawPane method
ms.assetid: 4be22651-475c-4059-b02c-4a8c07c99419
caps.latest.revision: 20
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCStatusBar::OnDrawPane
Redraw the pane of the status bar.  
  
## Syntax  
  
```  
virtual void OnDrawPane(  
   CDC* pDC,  
   CMFCStatusBarPaneInfo* pPane   
);  
```  
  
#### Parameters  
 [in] `pDC`  
 A pointer to a device context for drawing.  
  
 [in] `pPane`  
 A pointer to a `CMFCStatusBarPaneInfo` structure that contains the information about the pane to be redrawn.  
  
## Remarks  
 By default, `OnDrawPane` redraws the pane by using the device context `pDC` according to the pane's style and content.  
  
 Override this method in a `CMFCStatusBar`-derived class to customize the appearance of a pane.  
  
## Requirements  
 **Header:** afxstatusbar.h  
  
## See Also  
 [CMFCStatusBar Class](../vs140/cmfcstatusbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)