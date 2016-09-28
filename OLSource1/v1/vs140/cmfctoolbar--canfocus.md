---
title: "CMFCToolBar::CanFocus"
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
  - "CanFocus"
  - "CMFCToolBar.CanFocus"
  - "CMFCToolBar::CanFocus"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CanFocus method"
ms.assetid: f4bb22dd-d94d-409b-9da0-90493313f07e
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBar::CanFocus
Specifies whether the pane can receive focus.  
  
## Syntax  
  
```  
virtual BOOL CanFocus() const;  
```  
  
## Return Value  
 This method returns `FALSE`.  
  
## Remarks  
 This method overrides the base class implementation, [CBasePane::CanFocus](../vs140/cbasepane--canfocus.md), because toolbar objects cannot receive focus.  
  
## Requirements  
 **Header:** afxtoolbar.h  
  
## See Also  
 [CMFCToolBar Class](../vs140/cmfctoolbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CBasePane::CanFocus](../vs140/cbasepane--canfocus.md)