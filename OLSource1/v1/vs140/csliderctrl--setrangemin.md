---
title: "CSliderCtrl::SetRangeMin"
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
  - "SetRangeMin"
  - "CSliderCtrl.SetRangeMin"
  - "CSliderCtrl::SetRangeMin"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetRangeMin method"
ms.assetid: 4fb82b02-d236-43a4-bb3e-b9854dae49d5
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSliderCtrl::SetRangeMin
Sets the minimum range for the slider in a slider control.  
  
## Syntax  
  
```  
  
      void SetRangeMin(  
   int nMin,  
   BOOL bRedraw = FALSE   
);  
```  
  
#### Parameters  
 `nMin`  
 Minimum position for the slider.  
  
 `bRedraw`  
 The redraw flag. If this parameter is **TRUE**, the slider is redrawn after the range is set; otherwise the slider is not redrawn.  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CSliderCtrl Class](../vs140/csliderctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CSliderCtrl::SetRange](../vs140/csliderctrl--setrange.md)   
 [CSliderCtrl::GetRangeMin](../vs140/csliderctrl--getrangemin.md)   
 [CSliderCtrl::SetRangeMax](../vs140/csliderctrl--setrangemax.md)