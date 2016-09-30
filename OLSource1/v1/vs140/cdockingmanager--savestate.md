---
title: "CDockingManager::SaveState"
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
  - "CDockingManager::SaveState"
  - "CDockingManager.SaveState"
  - "SaveState"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SaveState method"
ms.assetid: 649fc971-1c9b-46ba-87e8-d243c09ab742
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDockingManager::SaveState
Saves the docking manager's state to the registry.  
  
## Syntax  
  
```  
virtual BOOL SaveState(  
   LPCTSTR lpszProfileName = NULL,  
   UINT uiID = (UINT) -1  
);  
```  
  
#### Parameters  
 [in] `lpszProfileName`  
 A path to a registry key.  
  
 [in] `uiID`  
 The docking manager ID.  
  
## Return Value  
 `TRUE` if the state was saved successfully; otherwise `FALSE`.  
  
## Remarks  
 Saving the docking manager's state to the registry involves saving the states of the control bars, the states of the autohide bars, and the states of the mini frames present in the docking manager.  
  
## Requirements  
 **Header:** afxdockingmanager.h  
  
## See Also  
 [CDockingManager Class](../vs140/cdockingmanager-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)