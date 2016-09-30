---
title: "CUserToolsManager::IsUserToolCmd"
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
  - "CUserToolsManager.IsUserToolCmd"
  - "CUserToolsManager::IsUserToolCmd"
  - "IsUserToolCmd"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsUserToolCmd method"
ms.assetid: 186ada16-f9e8-40bf-8942-c3013aa5c3ec
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CUserToolsManager::IsUserToolCmd
Determines whether a command ID is associated with a user tool.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A command ID of the menu item.  
  
## Return Value  
 Nonzero if a given command ID is associated with a user tool; otherwise 0.  
  
## Remarks  
 This method checks whether the given command ID is in the command ID range. You specify the range when you call [CWinAppEx::EnableUserTools](../vs140/cwinappex--enableusertools.md) to enable user tools.  
  
## Requirements  
 **Header:** afxusertoolsmanager.h  
  
## See Also  
 [CUserToolsManager Class](../vs140/cusertoolsmanager-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)