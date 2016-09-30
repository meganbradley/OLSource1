---
title: "CMFCTabCtrl::StopResize"
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
  - "CMFCTabCtrl.StopResize"
  - "StopResize"
  - "CMFCTabCtrl::StopResize"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "StopResize method"
ms.assetid: e6df6de2-6117-4bdf-9e49-a0c97edf62a4
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCTabCtrl::StopResize
Terminates the current resize operation on the tab control.  
  
## Syntax  
  
```  
void StopResize(  
   BOOL bCancel  
);  
```  
  
#### Parameters  
 [in] `bCancel`  
 `TRUE` to abandon the current resize operation; `FALSE` to complete the current resize operation. In either case, the framework stops drawing the resize rectangle.  
  
## Requirements  
 **Header:** afxtabctrl.h  
  
## See Also  
 [CMFCTabCtrl Class](../vs140/cmfctabctrl-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)