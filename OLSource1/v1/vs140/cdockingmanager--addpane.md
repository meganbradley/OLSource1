---
title: "CDockingManager::AddPane"
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
  - "CDockingManager.AddPane"
  - "CDockingManager::AddPane"
  - "AddPane"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AddPane method"
ms.assetid: ebb342bc-0dad-4db8-a8b4-4dc4bfa022cc
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDockingManager::AddPane
Registers a pane with the docking manager.  
  
## Syntax  
  
```  
BOOL AddPane(  
    CBasePane* pWnd,  
    BOOL bTail = TRUE,  
    BOOL bAutoHide = FALSE,  
    BOOL bInsertForOuterEdge = FALSE  
);  
```  
  
#### Parameters  
 [in, out] `pWnd`  
 Specifies the pane to add to the docking manager.  
  
 [in] `bTail`  
 `TRUE` to add the pane to the end of the list of panes for the docking manager; otherwise, `FALSE`.  
  
 [in] `bAutoHide`  
 For internal use only. Always use the default value `FALSE`.  
  
 [in] `bInsertForOuterEdge`  
 For internal use only. Always use the default value `FALSE`.  
  
## Return Value  
 `TRUE` if the pane was successfully registered with the docking manager; otherwise, `FALSE`.  
  
## Remarks  
 Call this method to register non-floating, non-resizable panes with the docking manager. If you do not register the panes, they will not appear correctly when the docking manager is laid out.  
  
## Requirements  
 **Header:** afxDockingManager.h  
  
## See Also  
 [CDockingManager Class](../vs140/cdockingmanager-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)