---
title: "CBaseTabbedPane::AllowDestroyEmptyTabbedPane"
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
  - "CBaseTabbedPane::AllowDestroyEmptyTabbedPane"
  - "CBaseTabbedPane.AllowDestroyEmptyTabbedPane"
  - "AllowDestroyEmptyTabbedPane"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AllowDestroyEmptyTabbedPane method"
ms.assetid: feb244bb-4677-489e-98bc-c388a01269cc
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CBaseTabbedPane::AllowDestroyEmptyTabbedPane
Specifies whether an empty tabbed pane can be destroyed.  
  
## Syntax  
  
```  
virtual BOOL AllowDestroyEmptyTabbedPane() const;  
```  
  
## Return Value  
 `TRUE` if an empty tabbed pane can be destroyed; otherwise, `FALSE`. The default implementation always returns `TRUE`.  
  
## Remarks  
 If an empty tabbed pane is not allowed to be destroyed, the framework hides the pane instead.  
  
## Requirements  
 **Header:** afxbasetabbedpane.h  
  
## See Also  
 [CBaseTabbedPane Class](../vs140/cbasetabbedpane-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)