---
title: "CMFCTasksPane::AddMRUFilesList"
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
  - CMFCTasksPane.AddMRUFilesList
  - AddMRUFilesList
  - CMFCTasksPane::AddMRUFilesList
dev_langs: 
  - C++
helpviewer_keywords: 
  - AddMRUFilesList method
ms.assetid: 44c323b5-def1-47b0-8d84-6e88f4748bc2
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCTasksPane::AddMRUFilesList
Adds a task for each file stored in a Most Recently Used (MRU) files list into a group.  
  
## Syntax  
  
```  
int AddMRUFilesList(  
    int nGroup,  
    int nMaxFiles = 4  
);  
```  
  
#### Parameters  
 [in] `nGroup`  
 Specifies the index of a group. This method adds the MRU files list to the group specified by this parameter.  
  
 [in] `nMaxFiles`  
 Specifies the number of files to display in the MRU files list.  
  
## Return Value  
 The zero-based index of the group where the MRU files list was added, or -1 if the group specified by `nGroup` does not exist.  
  
## Requirements  
 **Header:** afxTasksPane.h  
  
## See Also  
 [CMFCTasksPane Class](../vs140/cmfctaskspane-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)