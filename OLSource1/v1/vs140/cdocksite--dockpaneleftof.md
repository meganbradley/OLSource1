---
title: "CDockSite::DockPaneLeftOf"
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
  - "CDockSite.DockPaneLeftOf"
  - "DockPaneLeftOf"
  - "CDockSite::DockPaneLeftOf"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DockPaneLeftOf method"
ms.assetid: 35fa7b66-8307-4d72-8ba2-30709754aa62
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDockSite::DockPaneLeftOf
Docks a pane to the left of another pane.  
  
## Syntax  
  
```  
virtual BOOL DockPaneLeftOf(  
    CPane* pBarToDock,  
    CPane* pTargetBar   
);  
```  
  
#### Parameters  
 [in] [out] `pBarToDock`  
 A pointer to the pane to be docked to the left of `pTargetBar`.  
  
 [in] [out] `pTargetBar`  
 A pointer to the target pane.  
  
## Return Value  
 `TRUE` if the pane is docked successfully; otherwise, `FALSE`.  
  
## Remarks  
  
## Requirements  
 **Header:** afxDockSite.h  
  
## See Also  
 [CDockSite Class](../vs140/cdocksite-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)