---
title: "CControlBar::GetBorders"
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
  - "GetBorders"
  - "CControlBar.GetBorders"
  - "CControlBar::GetBorders"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CControlBar class, attributes"
  - "GetBorders method"
ms.assetid: 7772a1f9-d7aa-4bd4-908c-da0087921f21
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CControlBar::GetBorders
Returns the current border values for the control bar.  
  
## Syntax  
  
```  
  
CRect GetBorders( ) const;  
```  
  
## Return Value  
 A `CRect` object that contains the current width (in pixels) of each side of the control bar object. For example, the value of the `left` member, of [CRect](../vs140/crect-class.md) object, is the width of the left hand border.  
  
## Requirements  
 **Header:** afxext.h  
  
## See Also  
 [CControlBar Class](../vs140/ccontrolbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CControlBar::SetBorders](../vs140/ccontrolbar--setborders.md)