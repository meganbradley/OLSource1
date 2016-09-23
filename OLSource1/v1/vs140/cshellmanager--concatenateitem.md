---
title: "CShellManager::ConcatenateItem"
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
  - ConcatenateItem
  - CShellManager.ConcatenateItem
  - CShellManager::ConcatenateItem
dev_langs: 
  - C++
helpviewer_keywords: 
  - ConcatenateItem method
ms.assetid: 2e8f1c24-addd-4864-b60b-cd4245363126
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CShellManager::ConcatenateItem
Creates a new list containing two PIDLs.  
  
## Syntax  
  
```  
LPITEMIDLIST ConcatenateItem(  
   LPCITEMIDLIST pidl1,  
   LPCITEMIDLIST pidl2   
);  
```  
  
#### Parameters  
 [in] `pidl1`  
 The first item.  
  
 [in] `pidl2`  
 The second item.  
  
## Return Value  
 A pointer to the new item list if the function succeeds, otherwise `NULL`.  
  
## Remarks  
 This method creates a new [ITEMIDLIST](http://msdn.microsoft.com/library/windows/desktop/bb773321) large enough to contain both `pidl1` and `pidl2`. It then copies `pidl1` and `pidl2` to the new list.  
  
## Requirements  
 **Header:** afxshellmanager.h  
  
## See Also  
 [CShellManager Class](../vs140/cshellmanager-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)