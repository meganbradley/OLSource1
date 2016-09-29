---
title: "CContextMenuManager::SaveState"
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
  - "CContextMenuManager::SaveState"
  - "SaveState"
  - "CContextMenuManager.SaveState"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SaveState method"
ms.assetid: 0e2c50b5-b633-413c-b803-42f21b179ce4
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CContextMenuManager::SaveState
Saves information associated with the [CContextMenuManager Class](../vs140/ccontextmenumanager-class.md) to the Windows registry.  
  
## Syntax  
  
```  
virtual BOOL SaveState(  
   LPCTSTR lpszProfileName = NULL  
);  
```  
  
#### Parameters  
 [in] `lpszProfileName`  
 A string that contains the relative path of a registry key.  
  
## Return Value  
 Nonzero if the method is successful; otherwise 0.  
  
## Remarks  
 The `lpszProfileName` parameter is not the absolute path for a registry entry. It is a relative path that is added to the end of the default registry key for your application. To get or set the default registry key, use the methods [CWinAppEx::GetRegistryBase](../vs140/cwinappex--getregistrybase.md) and [CWinAppEx::SetRegistryBase](../vs140/cwinappex--setregistrybase.md) respectively.  
  
 Use the method [CContextMenuManager::LoadState](../vs140/ccontextmenumanager--loadstate.md) to load the shortcut menus from the registry.  
  
## Requirements  
 **Header:** afxcontextmenumanager.h  
  
## See Also  
 [CContextMenuManager Class](../vs140/ccontextmenumanager-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CContextMenuManager::LoadState](../vs140/ccontextmenumanager--loadstate.md)