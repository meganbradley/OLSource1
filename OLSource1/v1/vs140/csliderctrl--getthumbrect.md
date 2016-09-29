---
title: "CSliderCtrl::GetThumbRect"
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
  - "CSliderCtrl.GetThumbRect"
  - "GetThumbRect"
  - "CSliderCtrl::GetThumbRect"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetThumbRect method"
ms.assetid: 708f8cc3-8d95-4f29-8cbb-2f4d1f46439d
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSliderCtrl::GetThumbRect
Retrieves the size and position of the bounding rectangle for the slider (thumb) in a slider control.  
  
## Syntax  
  
```  
  
      void GetThumbRect(  
   LPRECT lprc   
) const;  
```  
  
#### Parameters  
 `lprc`  
 A pointer to a `CRect` object that contains the bounding rectangle for the slider when the function returns.  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CSliderCtrl Class](../vs140/csliderctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CSliderCtrl::GetChannelRect](../vs140/csliderctrl--getchannelrect.md)