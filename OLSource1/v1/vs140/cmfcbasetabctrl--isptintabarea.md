---
title: "CMFCBaseTabCtrl::IsPtInTabArea"
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
  - "IsPtInTabArea"
  - "CMFCBaseTabCtrl::IsPtInTabArea"
  - "CMFCBaseTabCtrl.IsPtInTabArea"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsPtInTabArea method"
ms.assetid: 734625bf-88dc-4354-9d29-fb18929153f6
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCBaseTabCtrl::IsPtInTabArea
Determines if a point is inside the tab area.  
  
## Syntax  
  
```  
virtual BOOL IsPtInTabArea(  
   CPoint point  
) const = 0;  
```  
  
#### Parameters  
 [in] `point`  
 The point to test.  
  
## Return Value  
 Nonzero if the point is in the tab area; 0 otherwise.  
  
## Remarks  
 In the [CMFCBaseTabCtrl Class](../vs140/cmfcbasetabctrl-class.md), this method is a pure virtual function and has no implementation. If you derive a class from `CMFCBaseTabCtrl`, you have to implement this function.  
  
## Requirements  
 **Header:** afxbasetabctrl.h  
  
## See Also  
 [CMFCBaseTabCtrl Class](../vs140/cmfcbasetabctrl-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CMFCBaseTabCtrl::GetTabArea](../vs140/cmfcbasetabctrl--gettabarea.md)