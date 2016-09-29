---
title: "CMFCToolTipCtrl::OnDrawSeparator"
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
  - "OnDrawSeparator"
  - "CMFCToolTipCtrl.OnDrawSeparator"
  - "CMFCToolTipCtrl::OnDrawSeparator"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDrawSeparator method"
ms.assetid: faeed117-9b6e-44de-9c41-0f95369879d4
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolTipCtrl::OnDrawSeparator
Draws the separator between the label and the description in a tooltip.  
  
## Syntax  
  
```  
virtual void OnDrawSeparator(  
   CDC* pDC,  
   int x1,  
   int x2,  
   int y   
);  
```  
  
#### Parameters  
 [in] `pDC`  
 A pointer to a device context.  
  
 [in] `x1`  
 Horizontal coordinate of the left end of the separator.  
  
 [in] `x2`  
 Horizontal coordinate of the right end of the separator.  
  
 [in] `Y`  
 Vertical coordinate of the separator.  
  
## Remarks  
 The default implementation draws a line from the point (x1, y) to the point (x2, y).  
  
 Override this method in a derived class to customize the appearance of the separator.  
  
## Requirements  
 **Header:** afxToolTipCtrl.h  
  
## See Also  
 [CMFCToolTipCtrl Class](../vs140/cmfctooltipctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)