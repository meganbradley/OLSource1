---
title: "CMouseManager::LoadState"
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
  - "CMouseManager::LoadState"
  - "CMouseManager.LoadState"
  - "LoadState"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "LoadState method"
ms.assetid: 2757906e-6507-4c35-a775-3fc796bcd891
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMouseManager::LoadState
Loads the state of the [CMouseManager Class](../vs140/cmousemanager-class.md) from the registry.  
  
## Syntax  
  
```  
BOOL LoadState(  
   LPCTSTR lpszProfileName = NULL  
);  
```  
  
#### Parameters  
 [in] `lpszProfileName`  
 A path of a registry key.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 The state information loaded from the registry includes the registered views, view identifiers, and the associated commands. If the parameter `lpszProfileName` is `NULL`, this function loads the `CMouseManager` data from the default registry location controlled by the [CWinAppEx Class](../vs140/cwinappex-class.md).  
  
 In most cases, you do not have to call this function directly. It is called as a part of the workspace initialization process. For more information about the workspace initialization process, see [CWinAppEx::LoadState](../vs140/cwinappex--loadstate.md).  
  
## Requirements  
 **Header:** afxmousemanager.h  
  
## See Also  
 [CMouseManager Class](../vs140/cmousemanager-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CWinAppEx Class](../vs140/cwinappex-class.md)   
 [CWinAppEx::LoadState](../vs140/cwinappex--loadstate.md)