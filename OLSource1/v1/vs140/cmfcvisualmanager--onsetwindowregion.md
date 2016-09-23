---
title: "CMFCVisualManager::OnSetWindowRegion"
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
  - OnSetWindowRegion
  - CMFCVisualManager::OnSetWindowRegion
  - CMFCVisualManager.OnSetWindowRegion
dev_langs: 
  - C++
helpviewer_keywords: 
  - OnSetWindowRegion method
ms.assetid: f219e031-3710-4c04-a4e8-155ad60475a4
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCVisualManager::OnSetWindowRegion
The framework calls this method after it sets a region that contains frames and pop-up menus.  
  
## Syntax  
  
```  
virtual BOOL OnSetWindowRegion(  
   CWnd* pWnd,  
   CSize sizeWindow  
);  
```  
  
#### Parameters  
 [in] `pWnd`  
 A pointer to the window with the region that changed.  
  
 [in] `sizeWindow`  
 The size of the window.  
  
## Return Value  
 `TRUE` if the method is successful; `FALSE` otherwise.  
  
## Remarks  
 The framework calls this method to notify the visual manager that a region has been set for frames and pop-up menus. For more information, see [CWindow::SetWindowRgn](../vs140/cwindow--setwindowrgn.md).  
  
## Requirements  
 **Header:** afxvisualmanager.h  
  
## See Also  
 [CMFCVisualManager Class](../vs140/cmfcvisualmanager-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWindow::SetWindowRgn](../vs140/cwindow--setwindowrgn.md)