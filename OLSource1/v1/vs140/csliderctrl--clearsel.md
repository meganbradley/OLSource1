---
title: "CSliderCtrl::ClearSel"
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
  - "CSliderCtrl::ClearSel"
  - "CSliderCtrl.ClearSel"
  - "ClearSel"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ClearSel method"
ms.assetid: de8ac3ed-ab19-469d-92f2-4c4bddac40ca
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSliderCtrl::ClearSel
Clears the current selection in a slider control.  
  
## Syntax  
  
```  
  
      void ClearSel(  
   BOOL bRedraw = FALSE   
);  
```  
  
#### Parameters  
 `bRedraw`  
 Redraw flag. If this parameter is **TRUE**, the slider is redrawn after the selection is cleared; otherwise the slider is not redrawn.  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CSliderCtrl Class](../vs140/csliderctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CSliderCtrl::GetSelection](../vs140/csliderctrl--getselection.md)   
 [CSliderCtrl::SetSelection](../vs140/csliderctrl--setselection.md)