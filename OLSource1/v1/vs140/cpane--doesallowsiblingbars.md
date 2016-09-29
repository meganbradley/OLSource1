---
title: "CPane::DoesAllowSiblingBars"
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
  - "CPane::DoesAllowSiblingBars"
  - "CPane.DoesAllowSiblingBars"
  - "DoesAllowSiblingBars"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DoesAllowSiblingBars method"
ms.assetid: ae48240a-3536-4338-9d98-2c73e3c9649d
caps.latest.revision: 11
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPane::DoesAllowSiblingBars
Indicates whether you can dock another pane at the same row where the current pane is docked.  
  
## Syntax  
  
```  
virtual BOOL DoesAllowSiblingBars() const;  
```  
  
## Return Value  
 `TRUE` if this pane can dock to another pane on the same row as itself; otherwise, `FALSE`.  
  
## Remarks  
 You can enable or disable this behavior by calling [CPane::SetExclusiveRowMode](../vs140/cpane--setexclusiverowmode.md).  
  
 By default, toolbars have exclusive row mode disabled and the menu bar has exclusive row mode enabled.  
  
## Requirements  
 **Header:** afxPane.h  
  
## See Also  
 [CPane Class](../vs140/cpane-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)