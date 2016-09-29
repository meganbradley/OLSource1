---
title: "CMFCHeaderCtrl::OnDrawItem"
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
  - "OnDrawItem"
  - "CMFCHeaderCtrl::OnDrawItem"
  - "CMFCHeaderCtrl.OnDrawItem"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDrawItem method"
ms.assetid: f46d80f0-f5dd-4f2e-aa2a-42dc7f6771b7
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCHeaderCtrl::OnDrawItem
Called by the framework to draw a header control column.  
  
## Syntax  
  
```  
virtual void OnDrawItem(  
   CDC* pDC,  
   int iItem,  
   CRect rect,  
   BOOL bIsPressed,  
   BOOL bIsHighlighted   
);  
```  
  
#### Parameters  
 [in] `pDC`  
 A pointer to a device context.  
  
 [in] `iItem`  
 The zero-based index of the item to draw.  
  
 [in] `rect`  
 The bounding rectangle of the item to draw.  
  
 [in] `bIsPressed`  
 `TRUE` to draw the item in pressed state; otherwise, `FALSE`.  
  
 [in] `bIsHighlighted`  
 `TRUE` to draw the item in highlighted state; otherwise, `FALSE`.  
  
## Requirements  
 **Header:** afxheaderctrl.h  
  
## See Also  
 [CMFCHeaderCtrl Class](../vs140/cmfcheaderctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)