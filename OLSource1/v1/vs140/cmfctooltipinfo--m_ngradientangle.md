---
title: "CMFCToolTipInfo::m_nGradientAngle"
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
  - "m_nGradientAngle"
  - "CMFCToolTipInfo::m_nGradientAngle"
  - "CMFCToolTipInfo.m_nGradientAngle"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCToolTipInfo class, data members"
  - "m_nGradientAngle"
ms.assetid: c171b471-59ff-45c4-8018-f77076bb2a11
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolTipInfo::m_nGradientAngle
Specifies the angle at which a gradient is drawn on the background of tooltips.  
  
## Syntax  
  
```  
int m_nGradientAngle;  
```  
  
## Remarks  
 `m_nGradientAngle` specifies the angle, in degrees, that the gradient on the background of tooltips is offset from horizontal. If `m_nGradientAngle` is 0, the gradient is drawn from left to right. If `m_nGradientAngle` is between 1 and 360, the gradient is rotating clockwise by that number of degrees. If `m_nGradientAngle` is -1, which is the default value, the gradient is drawn from top to bottom. This is the same as setting `m_nGradientAngle` to 90.  
  
 [CMFCToolTipInfo::m_clrFill](../vs140/cmfctooltipinfo--m_clrfill.md)  `clrFill` specifies the color of the beginning of the gradient and [CMFCToolTipInfo::m_clrFillGradient](../vs140/cmfctooltipinfo--m_clrfillgradient.md) `clrFillGradient` specifies the color of the end of the gradient. If `m_clrFillGradient` is -1, there is no gradient.  
  
## Requirements  
 **Header:** afxToolTipCtrl.h  
  
## See Also  
 [CMFCToolTipInfo Class](../vs140/cmfctooltipinfo-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)