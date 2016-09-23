---
title: "CSliderCtrl::SetRange"
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
  - CSliderCtrl.SetRange
  - CSliderCtrl::SetRange
dev_langs: 
  - C++
helpviewer_keywords: 
  - SetRange method
ms.assetid: 9c6432aa-1d21-43a3-8d0c-51827d5d18ca
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CSliderCtrl::SetRange
Sets the range (minimum and maximum positions) for the slider in a slider control.  
  
## Syntax  
  
```  
  
      void SetRange(  
   int nMin,  
   int nMax,  
   BOOL bRedraw = FALSE   
);  
```  
  
#### Parameters  
 `nMin`  
 Minimum position for the slider.  
  
 `nMax`  
 Maximum position for the slider.  
  
 `bRedraw`  
 The redraw flag. If this parameter is **TRUE**, the slider is redrawn after the range is set; otherwise the slider is not redrawn.  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CSliderCtrl Class](../vs140/csliderctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CSliderCtrl::GetRange](../vs140/csliderctrl--getrange.md)   
 [CSliderCtrl::SetRangeMax](../vs140/csliderctrl--setrangemax.md)   
 [CSliderCtrl::SetRangeMin](../vs140/csliderctrl--setrangemin.md)