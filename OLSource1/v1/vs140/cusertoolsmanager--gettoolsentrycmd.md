---
title: "CUserToolsManager::GetToolsEntryCmd"
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
  - "GetToolsEntryCmd"
  - "CUserToolsManager.GetToolsEntryCmd"
  - "CUserToolsManager::GetToolsEntryCmd"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetToolsEntryCmd method"
ms.assetid: b8b6749c-2e6b-4ae8-89fe-6c59b704960b
caps.latest.revision: 17
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CUserToolsManager::GetToolsEntryCmd
Returns the command ID of the menu item placeholder for user tools.  
  
## Syntax  
  
```  
UINT GetToolsEntryCmd() const;  
```  
  
## Return Value  
 The command ID of the placeholder.  
  
## Remarks  
 To enable user tools, you call [CWinAppEx::EnableUserTools](../vs140/cwinappex--enableusertools.md). The `uiCmdToolsDummy` parameter specifies the command ID of the tools entry command. This method returns the tools entry command ID. Wherever that ID is used in a menu, it is replaced by the list of user tools when the menu appears.  
  
## Requirements  
 **Header:** afxusertoolsmanager.h  
  
## See Also  
 [CUserToolsManager Class](../vs140/cusertoolsmanager-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)