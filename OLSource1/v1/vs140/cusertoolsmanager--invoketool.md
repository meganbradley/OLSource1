---
title: "CUserToolsManager::InvokeTool"
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
  - "CUserToolsManager.InvokeTool"
  - "CUserToolsManager::InvokeTool"
  - "InvokeTool"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "InvokeTool method"
ms.assetid: bf478284-06b1-4c64-97e0-a2ba194b70aa
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CUserToolsManager::InvokeTool
Executes an application associated with the user tool that has a specified command ID.  
  
## Syntax  
  
```  
BOOL InvokeTool(  
   UINT uiCmdId   
);  
```  
  
#### Parameters  
 [in] `uiCmdId`  
 The menu command ID associated with the user tool.  
  
## Return Value  
 Nonzero if the command associated with user tool was executed successfully; otherwise 0.  
  
## Remarks  
 Call this method to execute an application associated with the user tool that has the command ID specified by `uiCmdId`.  
  
## Requirements  
 **Header:** afxusertoolsmanager.h  
  
## See Also  
 [CUserToolsManager Class](../vs140/cusertoolsmanager-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)