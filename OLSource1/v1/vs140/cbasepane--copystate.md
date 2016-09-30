---
title: "CBasePane::CopyState"
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
  - "CopyState"
  - "CBasePane.CopyState"
  - "CBasePane::CopyState"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CopyState method"
ms.assetid: 26da2b2e-b44e-4744-93f6-f631864c9508
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CBasePane::CopyState
Copies the state of a given pane.  
  
## Syntax  
  
```  
virtual void CopyState(  
   CBasePane* pOrgBar  
);  
```  
  
#### Parameters  
 [in] `pOrgBar`  
 A pointer to another pane.  
  
## Remarks  
 This method copies the state from `pOrgBar` to this pane.  
  
## Requirements  
 **Header:** afxbasepane.h  
  
## See Also  
 [CBasePane Class](../vs140/cbasepane-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)