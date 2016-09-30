---
title: "CBasePane::GetRecentVisibleState"
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
  - "CBasePane.GetRecentVisibleState"
  - "CBasePane::GetRecentVisibleState"
  - "GetRecentVisibleState"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetRecentVisibleState method"
ms.assetid: e6f81336-dd06-4352-aacf-d948b21a413d
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CBasePane::GetRecentVisibleState
The framework calls this method when a pane is restored from an archive.  
  
## Syntax  
  
```  
virtual BOOL GetRecentVisibleState() const;  
```  
  
## Return Value  
 A `BOOL` that specifies the recent visible state. If `TRUE`, the pane was visible when serialized and should be visible when restored. If `FALSE`, the pane was hidden when serialized and should be hidden when restored.  
  
## Requirements  
 **Header:** afxbasepane.h  
  
## See Also  
 [CBasePane Class](../vs140/cbasepane-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)