---
title: "CMFCTabCtrl::CalcRectEdit"
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
  - "CalcRectEdit"
  - "CMFCTabCtrl::CalcRectEdit"
  - "CMFCTabCtrl.CalcRectEdit"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCTabCtrl::CalcRectEdit"
  - "CalcRectEdit method"
ms.assetid: 9cd65e01-45b2-4f4c-bdcc-8de766694833
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCTabCtrl::CalcRectEdit
Deflates the size of the specified tab area.  
  
## Syntax  
  
```  
virtual void CalcRectEdit(  
   CRect& rectEdit  
);  
```  
  
#### Parameters  
 [in] `rectEdit`  
 A rectangle that specifies the area of a tab.  
  
## Remarks  
 This method is called when you change the label of a tab. This method deflates the left and right sides of the specified rectangle by one-half the current tab height, and deflates the top and bottom by one unit.  
  
## Requirements  
 **Header:** afxtabctrl.h  
  
## See Also  
 [CMFCTabCtrl Class](../vs140/cmfctabctrl-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CRect::DeflateRect](../vs140/crect--deflaterect.md)