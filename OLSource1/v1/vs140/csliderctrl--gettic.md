---
title: "CSliderCtrl::GetTic"
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
  - "CSliderCtrl::GetTic"
  - "GetTic"
  - "CSliderCtrl.GetTic"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetTic method"
ms.assetid: 5bcfaccc-90c9-48fd-990d-a4e44b5eb25d
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSliderCtrl::GetTic
Retrieves the position of a tick mark in a slider control.  
  
## Syntax  
  
```  
  
      int GetTic(  
   int nTic   
) const;  
```  
  
#### Parameters  
 `nTic`  
 Zero-based index identifying a tick mark.  
  
## Return Value  
 The position of the specified tick mark or – 1 if `nTic` does not specify a valid index.  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CSliderCtrl Class](../vs140/csliderctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CSliderCtrl::SetTic](../vs140/csliderctrl--settic.md)   
 [CSliderCtrl::GetTicArray](../vs140/csliderctrl--getticarray.md)   
 [CSliderCtrl::GetTicPos](../vs140/csliderctrl--getticpos.md)   
 [CSliderCtrl::SetTicFreq](../vs140/csliderctrl--setticfreq.md)   
 [CSliderCtrl::ClearTics](../vs140/csliderctrl--cleartics.md)