---
title: "CBaseTabbedPane::GetFirstVisibleTab"
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
  - GetFirstVisibleTab
  - CBaseTabbedPane.GetFirstVisibleTab
  - CBaseTabbedPane::GetFirstVisibleTab
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetFirstVisibleTab method
ms.assetid: 5811d72d-b283-43f5-bae3-637f68c16aff
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CBaseTabbedPane::GetFirstVisibleTab
Retrieves a pointer to the first displayed tab.  
  
## Syntax  
  
```  
virtual CWnd* GetFirstVisibleTab(  
   int& iTabNum  
);  
```  
  
#### Parameters  
 [in] `iTabNum`  
 A reference to an integer. This method writes the zero-based index of the first displayed tab to this parameter, or -1 if no displayed tab is found.  
  
## Return Value  
 If successful, a pointer to the first displayed tab; otherwise, `NULL`.  
  
## Requirements  
 **Header:** afxbasetabbedpane.h  
  
## See Also  
 [CBaseTabbedPane Class](../vs140/cbasetabbedpane-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)