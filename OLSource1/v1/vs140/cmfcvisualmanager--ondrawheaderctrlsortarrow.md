---
title: "CMFCVisualManager::OnDrawHeaderCtrlSortArrow"
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
  - CMFCVisualManager::OnDrawHeaderCtrlSortArrow
  - CMFCVisualManager.OnDrawHeaderCtrlSortArrow
  - OnDrawHeaderCtrlSortArrow
dev_langs: 
  - C++
helpviewer_keywords: 
  - OnDrawHeaderCtrlSortArrow method
ms.assetid: 3c8a4532-e92b-4bd0-98ba-4cf98bc9c6c6
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCVisualManager::OnDrawHeaderCtrlSortArrow
The framework calls this function when it draws the sort arrow of a header control.  
  
## Syntax  
  
```  
virtual void OnDrawHeaderCtrlSortArrow(  
   CMFCHeaderCtrl* pCtrl,  
   CDC* pDC,  
   CRect& rect,  
   BOOL bIsUp   
);  
```  
  
#### Parameters  
 [in] `pCtrl`  
 A pointer to a header control. The visual manager draws the sort arrow of this [CMFCHeaderCtrl Class](../vs140/cmfcheaderctrl-class.md) object.  
  
 [in] `pDC`  
 A pointer to a device context.  
  
 [in] `rect`  
 A rectangle that specifies the boundaries of the sort arrow.  
  
 [in] `bIsUp`  
 A Boolean that specifies the direction of the sort arrow.  
  
## Remarks  
 If `bIsUp` is `TRUE`, the visual manager draws an up sort arrow. If it is `FALSE`, the visual manager draws a down sort arrow. Override `OnDrawHeaderCtrlSortArrow` in a derived class to customize the appearance of the sort button.  
  
## Requirements  
 **Header:** afxvisualmanager.h  
  
## See Also  
 [CMFCVisualManager Class](../vs140/cmfcvisualmanager-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)