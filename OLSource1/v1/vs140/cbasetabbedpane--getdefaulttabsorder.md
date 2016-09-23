---
title: "CBaseTabbedPane::GetDefaultTabsOrder"
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
  - GetDefaultTabsOrder
  - CBaseTabbedPane.GetDefaultTabsOrder
  - CBaseTabbedPane::GetDefaultTabsOrder
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetDefaultTabsOrder method
ms.assetid: 094a4d17-5ae0-40dc-b685-7615bcd1aa39
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CBaseTabbedPane::GetDefaultTabsOrder
Returns the default order of tabs in the pane.  
  
## Syntax  
  
```  
const CArray<int,int>& GetDefaultTabsOrder();  
```  
  
## Return Value  
 A `CArray` object that specifies the default order of tabs in the pane.  
  
## Remarks  
 The framework calls this method when an Outlook bar is reset to an initial state.  
  
## Requirements  
 **Header:** afxbasetabbedpane.h  
  
## See Also  
 [CBaseTabbedPane Class](../vs140/cbasetabbedpane-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)