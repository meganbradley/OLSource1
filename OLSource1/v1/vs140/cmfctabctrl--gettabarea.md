---
title: "CMFCTabCtrl::GetTabArea"
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
  - GetTabArea
  - CMFCTabCtrl::GetTabArea
  - CMFCTabCtrl.GetTabArea
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetTabArea method
ms.assetid: 3a433771-3c34-4fbe-9022-6f879e30d811
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCTabCtrl::GetTabArea
Retrieves the bounding rectangle of the tab label area at the top or bottom of the tab control.  
  
## Syntax  
  
```  
void GetTabArea(  
   CRect& rectTabAreaTop,  
   CRect& rectTabAreaBottom   
) const;  
```  
  
#### Parameters  
 [out] `rectTabAreaTop`  
 When this method returns, this reference contains a rectangle that bounds the top tab label area. The rectangle is in client coordinates. This reference is empty if no tab label area exists at the top of the tab control.  
  
 [out] `rectTabAreaBottom`  
 When this method returns, this reference contains a rectangle that bounds the bottom tab label area. The rectangle is in client coordinates. This reference is empty if no tab label area exists at the bottom of the tab control.  
  
## Remarks  
 Use this method to determine the size and position of the tab area in the tabbed window.  
  
## Requirements  
 **Header:** afxtabctrl.h  
  
## See Also  
 [CMFCTabCtrl Class](../vs140/cmfctabctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)