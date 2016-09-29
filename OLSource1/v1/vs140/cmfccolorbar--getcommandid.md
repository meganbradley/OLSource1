---
title: "CMFCColorBar::GetCommandID"
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
  - "CMFCColorBar::GetCommandID"
  - "GetCommandID"
  - "CMFCColorBar.GetCommandID"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetCommandID method"
ms.assetid: f2fc928d-c4d7-40af-8560-2f28468c0238
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCColorBar::GetCommandID
Retrieves the command ID of the current color bar control.  
  
## Syntax  
  
```  
UINT GetCommandID() const;  
```  
  
## Return Value  
 A command ID.  
  
## Remarks  
 When the user selects a new color, the framework sends the command ID in a `WM_COMMAND` message to notify the parent of the `CMFCColorBar` object.  
  
## Requirements  
 **Header:** afxcolorbar.h  
  
## See Also  
 [CMFCColorBar Class](../vs140/cmfccolorbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)