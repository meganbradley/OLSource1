---
title: "CSliderCtrl::SetLineSize"
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
  - "CSliderCtrl.SetLineSize"
  - "CSliderCtrl::SetLineSize"
  - "SetLineSize"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetLineSize method"
ms.assetid: 0a2ab5f1-d8ec-433b-8880-ee75d02e1280
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSliderCtrl::SetLineSize
Sets the size of the line for a slider control.  
  
## Syntax  
  
```  
  
      int SetLineSize(  
   int nSize   
);  
```  
  
#### Parameters  
 `nSize`  
 The new line size of the slider control.  
  
## Return Value  
 The previous line size.  
  
## Remarks  
 The line size affects how much the slider moves for the **TB_LINEUP** and **TB_LINEDOWN** notifications.  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CSliderCtrl Class](../vs140/csliderctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CSliderCtrl::GetLineSize](../vs140/csliderctrl--getlinesize.md)   
 [CSliderCtrl::SetPageSize](../vs140/csliderctrl--setpagesize.md)