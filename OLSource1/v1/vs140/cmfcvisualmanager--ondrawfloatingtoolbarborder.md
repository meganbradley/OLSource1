---
title: "CMFCVisualManager::OnDrawFloatingToolbarBorder"
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
  - CMFCVisualManager.OnDrawFloatingToolbarBorder
  - CMFCVisualManager::OnDrawFloatingToolbarBorder
  - OnDrawFloatingToolbarBorder
dev_langs: 
  - C++
helpviewer_keywords: 
  - OnDrawFloatingToolbarBorder method
ms.assetid: e83ac727-52d8-4f0c-bb3d-a51aacaac6db
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCVisualManager::OnDrawFloatingToolbarBorder
The framework calls this method when it draws the border of a floating toolbar.  
  
## Syntax  
  
```  
virtual void OnDrawFloatingToolbarBorder(  
   CDC* pDC,  
   CMFCBaseToolBar* pToolBar,  
   CRect rectBorder,  
   CRect rectBorderSize   
);  
```  
  
#### Parameters  
 [in] `pDC`  
 A pointer to a device context.  
  
 [in] `pToolBar`  
 A pointer to the floating toolbar.  
  
 [in] `rectBorder`  
 A rectangle that specifies the boundaries of the floating toolbar.  
  
 [in] `rectBorderSize`  
 A rectangle that specifies the border size of the toolbar.  
  
## Remarks  
 A floating toolbar is a toolbar that appears as a mini-frame window. Usually, this occurs when a user drags a toolbar so that it is no longer docked.  
  
 The size of the border is specified by the corresponding parameter in `rectBorderSize`. For example, the width of the top border of the toolbar is specified by `rectBorderSize.top`.  
  
 Override this method in a derived visual manager to customize the appearance of the border of a floating toolbar.  
  
## Requirements  
 **Header:** afxvisualmanager.h  
  
## See Also  
 [CMFCVisualManager Class](../vs140/cmfcvisualmanager-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)