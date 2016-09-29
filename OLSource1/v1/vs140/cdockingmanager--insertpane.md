---
title: "CDockingManager::InsertPane"
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
  - "CDockingManager::InsertPane"
  - "CDockingManager.InsertPane"
  - "InsertPane"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "InsertPane method"
ms.assetid: fbaf9c21-8758-44c2-8a2d-35551dfda1b7
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDockingManager::InsertPane
Inserts a control pane into the list of control bars.  
  
## Syntax  
  
```  
BOOL InsertPane(  
   CBasePane* pControlBar,  
   CBasePane* pTarget,  
   BOOL bAfter = TRUE  
);  
```  
  
#### Parameters  
 [in] `pControlBar`  
 A pointer to a control pane.  
  
 [in] `pTarget`  
 A pointer to a target pane.  
  
 [in] `bAfter`  
 `TRUE` to insert the pane after the position of the target pane; `FALSE` otherwise.  
  
## Return Value  
 `TRUE` if the control pane is successfully added to the list of control bars; `FALSE` otherwise.  
  
## Remarks  
 This method returns false if the control pane is already in the list of control bars or if the target pane does not exist in the list of control bars.  
  
## Requirements  
 **Header:** afxdockingmanager.h  
  
## See Also  
 [CDockingManager Class](../vs140/cdockingmanager-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)