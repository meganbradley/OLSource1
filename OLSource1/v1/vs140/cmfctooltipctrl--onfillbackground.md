---
title: "CMFCToolTipCtrl::OnFillBackground"
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
  - "CMFCToolTipCtrl::OnFillBackground"
  - "CMFCToolTipCtrl.OnFillBackground"
  - "OnFillBackground"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnFillBackground method"
ms.assetid: 292dabac-d2c8-4f97-a443-c3aa6188d91e
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolTipCtrl::OnFillBackground
Fills the tooltip background.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the bounding rectangle of the area to fill.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Tooltip foreground color.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Color of borders and the delimiter line between label and description.  
  
## Remarks  
 The default implementation fills the rectangle that is specified by <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> with the color or pattern specified by the most recent call to [CMFCToolTipCtrl::SetParams](../vs140/cmfctooltipctrl--setparams.md).  
  
 Override this method in a derived class if you want to customize the appearance of the tooltip.  
  
## Requirements  
 **Header:** afxToolTipCtrl.h  
  
## See Also  
 [CMFCToolTipCtrl Class](../vs140/cmfctooltipctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)