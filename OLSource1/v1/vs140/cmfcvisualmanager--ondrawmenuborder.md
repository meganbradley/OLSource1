---
title: "CMFCVisualManager::OnDrawMenuBorder"
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
  - CMFCVisualManager::OnDrawMenuBorder
  - OnDrawMenuBorder
  - CMFCVisualManager.OnDrawMenuBorder
dev_langs: 
  - C++
helpviewer_keywords: 
  - OnDrawMenuBorder method
ms.assetid: 64719950-7c84-471d-a2ba-c4d4185c70bd
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCVisualManager::OnDrawMenuBorder
The framework calls this method when it draws the border of a [CMFCPopupMenu](../vs140/cmfcpopupmenu-class.md).  
  
## Syntax  
  
```  
virtual void OnDrawMenuBorder(  
   CDC* pDC,  
   CMFCPopupMenu* pMenu,  
   CRect rect  
);  
```  
  
#### Parameters  
 [in] `pDC`  
 A pointer to the device context for a `CMFCPopupMenu` object.  
  
 [in] `pMenu`  
 A pointer to a `CMFCPopupMenu` object. The framework draws a border around this popup menu.  
  
 [in] `rect`  
 A rectangle that specifies the boundaries of the popup menu.  
  
## Remarks  
 The default implementation of this method displays the standard menu border. Override this method in a derived visual manager to customize the appearance of the menu border.  
  
## Requirements  
 **Header:** afxvisualmanager.h  
  
## See Also  
 [CMFCVisualManager Class](../vs140/cmfcvisualmanager-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCPopupMenu Class](../vs140/cmfcpopupmenu-class.md)