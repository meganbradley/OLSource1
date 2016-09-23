---
title: "CStatusBarCtrl::GetBorders"
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
  - CStatusBarCtrl.GetBorders
  - GetBorders
  - CStatusBarCtrl::GetBorders
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetBorders method
  - borders, status bar control
  - CStatusBarCtrl class, attributes
  - status bar controls, borders
ms.assetid: 54d49c31-6989-4523-8590-61c060733c55
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CStatusBarCtrl::GetBorders
Retrieves the status bar control's current widths of the horizontal and vertical borders and of the space between rectangles.  
  
## Syntax  
  
```  
  
      BOOL GetBorders(  
   int* pBorders   
) const;  
BOOL GetBorders(  
   int& nHorz,  
   int& nVert,  
   int& nSpacing   
) const;  
```  
  
#### Parameters  
 *pBorders*  
 Address of an integer array having three elements. The first element receives the width of the horizontal border, the second receives the width of the vertical border, and the third receives the width of the border between rectangles.  
  
 *nHorz*  
 Reference to an integer that receives the width of the horizontal border.  
  
 *nVert*  
 Reference to an integer that receives the width of the vertical border.  
  
 *nSpacing*  
 Reference to an integer that receives the width of the border between rectangles.  
  
## Return Value  
 Nonzero if successful; otherwise zero.  
  
## Remarks  
 These borders determine the spacing between the outside edge of the control and the rectangles within the control that contain text.  
  
## Example  
 [!code[NVC_MFC_CStatusBarCtrl#2](../vs140/codesnippet/CPP/cstatusbarctrl--getborders_1.cpp)]
  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CStatusBarCtrl Class](../vs140/cstatusbarctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CStatusBarCtrl::GetParts](../vs140/cstatusbarctrl--getparts.md)   
 [CStatusBarCtrl::SetParts](../vs140/cstatusbarctrl--setparts.md)