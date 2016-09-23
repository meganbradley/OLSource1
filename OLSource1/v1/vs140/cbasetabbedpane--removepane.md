---
title: "CBaseTabbedPane::RemovePane"
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
  - CBaseTabbedPane.RemovePane
  - RemovePane
  - CBaseTabbedPane::RemovePane
dev_langs: 
  - C++
helpviewer_keywords: 
  - RemovePane method
ms.assetid: 6ffcdeb1-bc13-45f7-b8cf-961af45f5958
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CBaseTabbedPane::RemovePane
Removes a pane from the tabbed pane.  
  
## Syntax  
  
```  
virtual BOOL RemovePane(  
    CWnd* pBar  
);  
```  
  
#### Parameters  
 [in] [out] `pBar`  
 A pointer to the pane to remove from the tabbed pane.  
  
## Return Value  
 `TRUE` if the pane was successfully removed from the tabbed pane and if the tabbed pane is still valid. `FALSE` if the last pane has been removed from the tabbed pane and the tabbed pane is about to be destroyed. If the return value is `FALSE`, do not use the tabbed pane any more.  
  
## Remarks  
 Call this method to remove the pane specified by the `pBar` parameter from the tabbed pane.  
  
## Requirements  
 **Header:** afxBaseTabbedPane.h  
  
## See Also  
 [CBaseTabbedPane Class](../vs140/cbasetabbedpane-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)