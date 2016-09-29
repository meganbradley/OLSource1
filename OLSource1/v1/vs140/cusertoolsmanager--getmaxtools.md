---
title: "CUserToolsManager::GetMaxTools"
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
  - "GetMaxTools"
  - "CUserToolsManager.GetMaxTools"
  - "CUserToolsManager::GetMaxTools"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetMaxTools method"
ms.assetid: 6df72bde-6ce4-4c5d-a58f-91102596c0a7
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CUserToolsManager::GetMaxTools
Returns the maximum number of user tools that can be allocated in the application.  
  
## Syntax  
  
```  
int GetMaxTools() const;  
```  
  
## Return Value  
 The maximum number of user tools that can be allocated.  
  
## Remarks  
 Call this method to retrieve the maximum number of tools that can be allocated in the application. This number is the number of IDs in the range from the `uiCmdFirst` through the `uiCmdLast` parameters that you pass to [CWinAppEx::EnableUserTools](../vs140/cwinappex--enableusertools.md).  
  
## Requirements  
 **Header:** afxusertoolsmanager.h  
  
## See Also  
 [CUserToolsManager Class](../vs140/cusertoolsmanager-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)