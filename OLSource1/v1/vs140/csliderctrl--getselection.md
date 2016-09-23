---
title: "CSliderCtrl::GetSelection"
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
  - GetSelection
  - CSliderCtrl.GetSelection
  - CSliderCtrl::GetSelection
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetSelection method
ms.assetid: a3713032-0d90-4330-b73d-baad58562eed
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CSliderCtrl::GetSelection
Retrieves the starting and ending positions of the current selection in a slider control.  
  
## Syntax  
  
```  
  
      void GetSelection(  
   int& nMin,  
   int& nMax   
) const;  
```  
  
#### Parameters  
 `nMin`  
 Reference to an integer that receives the starting position of the current selection.  
  
 `nMax`  
 Reference to an integer that receives the ending position of the current selection.  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CSliderCtrl Class](../vs140/csliderctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CSliderCtrl::SetSelection](../vs140/csliderctrl--setselection.md)   
 [CSliderCtrl::ClearSel](../vs140/csliderctrl--clearsel.md)