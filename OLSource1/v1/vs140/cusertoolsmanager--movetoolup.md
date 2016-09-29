---
title: "CUserToolsManager::MoveToolUp"
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
  - "CUserToolsManager::MoveToolUp"
  - "CUserToolsManager.MoveToolUp"
  - "MoveToolUp"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "MoveToolUp method"
ms.assetid: cada214e-bceb-4231-924b-154f50e6ddb3
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CUserToolsManager::MoveToolUp
Moves the specified user tool up in the list of user tools.  
  
## Syntax  
  
```  
BOOL MoveToolUp(  
   CUserTool* pTool   
);  
```  
  
#### Parameters  
 [in] `pTool`  
 Specifies the user tool to move.  
  
## Return Value  
 Nonzero if the user tool was moved up successfully; otherwise 0.  
  
## Remarks  
 The method fails if the tool that the `pTool` parameter specifies is not in the internal list or if the tool is the first tool item in the list.  
  
## Requirements  
 **Header:** afxusertoolsmanager.h  
  
## See Also  
 [CUserToolsManager Class](../vs140/cusertoolsmanager-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)