---
title: "CMFCTabCtrl::SetFlatFrame"
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
  - CMFCTabCtrl.SetFlatFrame
  - CMFCTabCtrl::SetFlatFrame
  - SetFlatFrame
dev_langs: 
  - C++
helpviewer_keywords: 
  - SetFlatFrame method
ms.assetid: 6ec5b1ce-0966-455e-8f83-37de6361fa0c
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCTabCtrl::SetFlatFrame
Specifies whether to draw a flat or a 3D frame around the tab area.  
  
## Syntax  
  
```  
void SetFlatFrame(  
   BOOL bFlat=TRUE,  
   BOOL bRepaint=TRUE   
);  
```  
  
#### Parameters  
 [in] `bFlat`  
 `TRUE` to draw a flat (2D) frame around the tab area; `FALSE` to draw a three-dimensional (3D) frame. The default value is `TRUE`.  
  
 [in] `bRepaint`  
 `TRUE` to redraw the window immediately; otherwise, `FALSE`. The default value is `TRUE`.  
  
## Remarks  
  
## Requirements  
 **Header:** afxtabctrl.h  
  
## See Also  
 [CMFCTabCtrl Class](../vs140/cmfctabctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)