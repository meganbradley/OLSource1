---
title: "CDockingManager::LoadState"
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
  - "CDockingManager::LoadState"
  - "CDockingManager.LoadState"
  - "LoadState"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "LoadState method"
ms.assetid: 170501a3-fb67-4667-b8c8-3b77bf97abdb
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDockingManager::LoadState
Loads the docking manager's state from the registry.  
  
## Syntax  
  
```  
virtual BOOL LoadState(  
   LPCTSTR lpszProfileName = NULL,  
   UINT uiID = (UINT) -1  
);  
```  
  
#### Parameters  
 [in] `lpszProfileName`  
 Profile name.  
  
 [in] `uiID`  
 The id of the docking manager.  
  
## Return Value  
 `TRUE` if the docking manager state was loaded successfully; otherwise `FALSE`.  
  
## Requirements  
 **Header:** afxdockingmanager.h  
  
## See Also  
 [CDockingManager Class](../vs140/cdockingmanager-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)