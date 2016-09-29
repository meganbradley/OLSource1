---
title: "CPane::GetBorders"
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
  - "CPane::GetBorders"
  - "CPane.GetBorders"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetBorders method"
ms.assetid: 007ce3b7-92a1-4e66-83e4-e47df325de38
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPane::GetBorders
Returns the width of the borders of the pane.  
  
## Syntax  
  
```  
CRect GetBorders() const;  
```  
  
## Return Value  
 A [CRect](../vs140/crect-class.md) object that contains the current width, in pixels, of each side of the pane. For example, the value of the `left` member of the `CRect` object is the width of the left border.  
  
## Remarks  
 To set the size of the borders, call [CPane::SetBorders](../vs140/cpane--setborders.md).  
  
## Requirements  
 **Header:** afxPane.h  
  
## See Also  
 [CPane Class](../vs140/cpane-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)