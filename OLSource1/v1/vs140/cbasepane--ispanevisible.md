---
title: "CBasePane::IsPaneVisible"
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
  - "CBasePane.IsPaneVisible"
  - "CBasePane::IsPaneVisible"
  - "IsPaneVisible"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsPaneVisible method"
ms.assetid: c8b56158-9dc6-4ad2-910f-3b5ab746d67f
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CBasePane::IsPaneVisible
Specifies whether the `WS_VISIBLE` flag is set for the pane.  
  
## Syntax  
  
```  
BOOL IsPaneVisible() const;  
```  
  
## Return Value  
 `TRUE` if `WS_VISIBLE` is set; otherwise, `FALSE`.  
  
## Remarks  
 Use [CBasePane::IsVisible](../vs140/cbasepane--isvisible.md) to determine pane visibility.  
  
## Requirements  
 **Header:** afxbasepane.h  
  
## See Also  
 [CBasePane Class](../vs140/cbasepane-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CBasePane::IsVisible](../vs140/cbasepane--isvisible.md)