---
title: "CMFCToolTipInfo::m_clrFill"
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
  - "CMFCToolTipInfo.m_clrFill"
  - "m_clrFill"
  - "CMFCToolTipInfo::m_clrFill"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCToolTipInfo class, data members"
  - "m_clrFill"
ms.assetid: 44ff36f1-5e3c-4705-9de4-d6c5e4cb2149
caps.latest.revision: 19
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolTipInfo::m_clrFill
Specifies the color of tooltip backgrounds.  
  
## Syntax  
  
```  
COLORREF m_clrFill;  
```  
  
## Remarks  
 If [CMFCToolTipInfo::m_clrFillGradient](../vs140/cmfctooltipinfo--m_clrfillgradient.md) is -1, the tooltip background color is `m_clrFill`. Otherwise, `m_clrFill` specifies the color of the beginning of the gradient and `m_clrFillGradient` specifies the color of the end of the gradient. [CMFCToolTipInfo::m_nGradientAngle](../vs140/cmfctooltipinfo--m_ngradientangle.md) determines the direction of the gradient.  
  
## Requirements  
 **Header:** afxToolTipCtrl.h  
  
## See Also  
 [CMFCToolTipInfo Class](../vs140/cmfctooltipinfo-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)