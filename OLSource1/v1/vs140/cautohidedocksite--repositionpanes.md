---
title: "CAutoHideDockSite::RepositionPanes"
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
  - "RepositionPanes"
  - "CAutoHideDockSite.RepositionPanes"
  - "CAutoHideDockSite::RepositionPanes"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "RepositionPanes method"
ms.assetid: 6e857caf-c24f-4df8-87f8-c7ae78e1aa99
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAutoHideDockSite::RepositionPanes
Redraws the panes on the [CAutoHideDockSite](../vs140/cautohidedocksite-class.md).  
  
## Syntax  
  
```  
virtual void RepositionPanes(  
   CRect& rectNewClientArea  
);  
```  
  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|[in] `rectNewClientArea`|A reserved value.|  
  
## Remarks  
 The default implementation does not use `rectNewClientArea`. It redraws the panes with the global toolbar margins and button spacing.  
  
## Requirements  
 **Header:** afxautohidedocksite.h  
  
## See Also  
 [CAutoHideDockSite Class](../vs140/cautohidedocksite-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)