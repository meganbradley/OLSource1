---
title: "CUserToolsManager::RemoveTool"
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
  - RemoveTool
  - CUserToolsManager::RemoveTool
  - CUserToolsManager.RemoveTool
dev_langs: 
  - C++
helpviewer_keywords: 
  - RemoveTool method
ms.assetid: c57dcbe8-5a9e-4178-afde-fb5ae9cd6a23
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CUserToolsManager::RemoveTool
Removes the specified user tool from the application.  
  
## Syntax  
  
```  
BOOL RemoveTool(  
   CUserTool* pTool   
);  
```  
  
#### Parameters  
 [in, out] `pTool`  
 A pointer to a user tool to be removed.  
  
## Return Value  
 `TRUE` if the tool is successfully removed. Otherwise, `FALSE`.  
  
## Remarks  
 If the tool is successfully removed, this method deletes `pTool`.  
  
## Requirements  
 **Header:** afxusertoolsmanager.h  
  
## See Also  
 [CUserToolsManager Class](../vs140/cusertoolsmanager-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)