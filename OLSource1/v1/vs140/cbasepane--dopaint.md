---
title: "CBasePane::DoPaint"
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
  - "CBasePane::DoPaint"
  - "DoPaint"
  - "CBasePane.DoPaint"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DoPaint method"
ms.assetid: 4ea547d5-be4b-4825-b47b-12842f90dbd8
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CBasePane::DoPaint
Fills the background of the pane.  
  
## Syntax  
  
```  
virtual void DoPaint(  
   CDC* pDC   
);  
```  
  
#### Parameters  
 [in] `pDC`  
 A pointer to a device context.  
  
## Remarks  
 The default implementation calls the current visual manager to fill the background ([CMFCVisualManager::OnFillBarBackground](../vs140/cmfcvisualmanager--onfillbarbackground.md)).  
  
## Requirements  
 **Header:** afxbasepane.h  
  
## See Also  
 [CBasePane Class](../vs140/cbasepane-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)