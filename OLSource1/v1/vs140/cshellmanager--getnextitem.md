---
title: "CShellManager::GetNextItem"
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
  - "CShellManager::GetNextItem"
  - "GetNextItem"
  - "CShellManager.GetNextItem"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetNextItem method"
ms.assetid: c929ab5f-ce3e-481b-9b62-63953695bce1
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CShellManager::GetNextItem
Retrieves the next item from a pointer to an item identifier list (PIDL).  
  
## Syntax  
  
```  
LPITEMIDLIST GetNextItem(  
   LPCITEMIDLIST pidl   
);  
```  
  
#### Parameters  
 [in] `pidl`  
 The list of items to iterate.  
  
## Return Value  
 A pointer to the next item in the list.  
  
## Remarks  
 If there are no more items in the list, this method returns `NULL`.  
  
## Requirements  
 **Header:** afxshellmanager.h  
  
## See Also  
 [CShellManager Class](../vs140/cshellmanager-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)