---
title: "CPane::SetExclusiveRowMode"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CPane::SetExclusiveRowMode
  - SetExclusiveRowMode
  - CPane.SetExclusiveRowMode
dev_langs: 
  - C++
helpviewer_keywords: 
  - SetExclusiveRowMode method
ms.assetid: 977cb6d1-70ab-4e3f-804a-131b5ad843da
caps.latest.revision: 11
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CPane::SetExclusiveRowMode
Enables or disables the exclusive row mode.  
  
## Syntax  
  
```  
virtual void SetExclusiveRowMode(  
    BOOL bExclusive = TRUE  
);  
```  
  
#### Parameters  
 [in] `bExclusive`  
 `TRUE` to enable exclusive row mode; otherwise, `FALSE`.  
  
## Remarks  
 Call this method to enable or disable exclusive row mode. When a pane is in exclusive row mode, it cannot share the same row with any other toolbars.  
  
 By default, all toolbars have exclusive row mode disabled and the menu bar has exclusive row mode enabled.  
  
## Requirements  
 **Header:** afxPane.h  
  
## See Also  
 [CPane Class](../vs140/cpane-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)