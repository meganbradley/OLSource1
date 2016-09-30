---
title: "CUserToolsManager::SaveState"
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
  - "CUserToolsManager::SaveState"
  - "CUserToolsManager.SaveState"
  - "SaveState"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SaveState method"
ms.assetid: 12bea579-6799-4351-afdf-f036d16b1f91
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CUserToolsManager::SaveState
Stores information about user tools in the Windows registry.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A path to the Windows registry key.  
  
## Return Value  
 Nonzero if the state was saved successfully; otherwise 0.  
  
## Remarks  
 The method stores the current state of the [CUserToolsManager Class](../vs140/cusertoolsmanager-class.md) object in the Windows registry.  
  
 Usually, you do not need to call this method directly, [CWinAppEx::SaveState](../vs140/cwinappex--savestate.md) calls it automatically as a part of the workspace serialization process of the application.  
  
## Requirements  
 **Header:** afxusertoolsmanager.h  
  
## See Also  
 [CUserToolsManager Class](../vs140/cusertoolsmanager-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)