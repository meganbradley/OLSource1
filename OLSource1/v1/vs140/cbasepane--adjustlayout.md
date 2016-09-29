---
title: "CBasePane::AdjustLayout"
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
  - "CBasePane::AdjustLayout"
  - "AdjustLayout"
  - "CBasePane.AdjustLayout"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AdjustLayout method"
ms.assetid: 0ad73ac8-2d7a-401e-9661-f8ebb5351d44
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CBasePane::AdjustLayout
Called by the framework to adjust the internal layout of a pane.  
  
## Syntax  
  
```  
virtual void AdjustLayout();  
```  
  
## Remarks  
 The framework calls this method when a pane has to adjust its internal layout. The base implementation does nothing.  
  
## Requirements  
 **Header:** afxbasepane.h  
  
## See Also  
 [CBasePane Class](../vs140/cbasepane-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)