---
title: "CMFCToolTipCtrl::SetParams"
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
  - "CMFCToolTipCtrl::SetParams"
  - "SetParams"
  - "CMFCToolTipCtrl.SetParams"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetParams method"
ms.assetid: 767c3211-16df-4854-900e-a64ef85fd17c
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolTipCtrl::SetParams
Specifies the visual appearance of a tooltip by using a [CMFCToolTipInfo](../vs140/cmfctooltipinfo-class.md) object.  
  
## Syntax  
  
```  
void SetParams(  
   CMFCToolTipInfo* pParams   
);  
```  
  
#### Parameters  
 `[in] pParams`  
 Pointer to a [CMFCToolTipInfo](../vs140/cmfctooltipinfo-class.md) object that contains  the display parameters.  
  
## Remarks  
 Whenever the tooltip is displayed, it is drawn by using the colors and visual styles that `pParams` specifies. The value of `pParams` is stored in the protected member `m_Params`, which can be accessed by a derived class that overrides [CMFCToolTipCtrl::OnDrawBorder](../vs140/cmfctooltipctrl--ondrawborder.md), [CMFCToolTipCtrl::OnDrawIcon](../vs140/cmfctooltipctrl--ondrawicon.md), [CMFCToolTipCtrl::OnDrawLabel](../vs140/cmfctooltipctrl--ondrawlabel.md), [CMFCToolTipCtrl::OnDrawSeparator](../vs140/cmfctooltipctrl--ondrawseparator.md), or [CMFCToolTipCtrl::OnFillBackground](../vs140/cmfctooltipctrl--onfillbackground.md) to maintain the specified appearance.  
  
## Requirements  
 **Header:** afxToolTipCtrl.h  
  
## See Also  
 [CMFCToolTipCtrl Class](../vs140/cmfctooltipctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)