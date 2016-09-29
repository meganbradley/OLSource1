---
title: "CSliderCtrl::SetTic"
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
  - "SetTic"
  - "CSliderCtrl.SetTic"
  - "CSliderCtrl::SetTic"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetTic method"
ms.assetid: 2f9bb612-d364-4591-b3e6-f1b4fa9cd4f5
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSliderCtrl::SetTic
Sets the position of a tick mark in a slider control.  
  
## Syntax  
  
```  
  
      BOOL SetTic(  
   int nTic   
);  
```  
  
#### Parameters  
 `nTic`  
 Position of the tick mark. This parameter must specify a positive value.  
  
## Return Value  
 Nonzero if the tick mark is set; otherwise 0.  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CSliderCtrl Class](../vs140/csliderctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CSliderCtrl::GetTic](../vs140/csliderctrl--gettic.md)   
 [CSliderCtrl::GetTicArray](../vs140/csliderctrl--getticarray.md)   
 [CSliderCtrl::GetTicPos](../vs140/csliderctrl--getticpos.md)   
 [CSliderCtrl::SetTicFreq](../vs140/csliderctrl--setticfreq.md)   
 [CSliderCtrl::ClearTics](../vs140/csliderctrl--cleartics.md)