---
title: "CMFCTasksPane::EnableHistoryMenuButtons"
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
  - "EnableHistoryMenuButtons"
  - "CMFCTasksPane::EnableHistoryMenuButtons"
  - "CMFCTasksPane.EnableHistoryMenuButtons"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "EnableHistoryMenuButtons method"
ms.assetid: e3c432d7-68bd-4938-b9af-925e6a0405d1
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCTasksPane::EnableHistoryMenuButtons
Enables drop-down menus on the **Next** and **Previous** navigation buttons.  
  
## Syntax  
  
```  
void EnableHistoryMenuButtons(  
    BOOL bEnable = TRUE  
);  
```  
  
#### Parameters  
 [in] `bEnable`  
 `TRUE` to enable drop-down menus on the **Next** and **Previous** navigation buttons; otherwise, `FALSE`.  
  
## Remarks  
 By default, the drop-down menus on the **Next** and **Previous** buttons are disabled.  
  
 The menus contain the history of tasks pages that the user used.  
  
## Requirements  
 **Header:** afxTasksPane.h  
  
## See Also  
 [CMFCTasksPane Class](../vs140/cmfctaskspane-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)