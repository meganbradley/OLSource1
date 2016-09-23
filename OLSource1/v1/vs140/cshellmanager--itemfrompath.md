---
title: "CShellManager::ItemFromPath"
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
  - CShellManager.ItemFromPath
  - ItemFromPath
  - CShellManager::ItemFromPath
dev_langs: 
  - C++
helpviewer_keywords: 
  - ItemFromPath method
ms.assetid: 174a5842-1355-455d-9f29-b67e93e64700
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CShellManager::ItemFromPath
Retrieves the pointer to an item identifier list (PIDL) from the item identified by a string path.  
  
## Syntax  
  
```  
HRESULT ItemFromPath(  
   LPCTSTR lpszPath,  
   LPITEMIDLIST& pidl   
);  
```  
  
#### Parameters  
 [in] `lpszPath`  
 A string that specifies the path for the item.  
  
 [out] `pidl`  
 A reference to a PIDL. The method uses this PIDL to store the pointer to its return value.  
  
## Return Value  
 Returns `NOERROR` if successful; an OLE-defined error value.  
  
## Requirements  
 **Header:** afxshellmanager.h  
  
## See Also  
 [CShellManager Class](../vs140/cshellmanager-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)