---
title: "CUserToolsManager::LoadState"
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
  - "CUserToolsManager.LoadState"
  - "CUserToolsManager::LoadState"
  - "LoadState"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "LoadState method"
ms.assetid: 5f7ebcd3-48a8-4f1b-9935-c7b95f8a717c
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CUserToolsManager::LoadState
Loads information about user tools from the Windows registry.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The path of the Windows registry key.  
  
## Return Value  
 Nonzero if the state was loaded successfully; otherwise 0.  
  
## Remarks  
 This method loads the state of the [CUserToolsManager Class](../vs140/cusertoolsmanager-class.md) object from the Windows registry.  
  
 Usually, you do not call this method directly. [CWinAppEx::LoadState](../vs140/cwinappex--loadstate.md) calls it as part of workspace initialization process.  
  
## Requirements  
 **Header:** afxusertoolsmanager.h  
  
## See Also  
 [CUserToolsManager Class](../vs140/cusertoolsmanager-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)