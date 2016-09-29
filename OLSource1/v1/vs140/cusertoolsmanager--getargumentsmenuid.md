---
title: "CUserToolsManager::GetArgumentsMenuID"
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
  - "CUserToolsManager::GetArgumentsMenuID"
  - "CUserToolsManager.GetArgumentsMenuID"
  - "GetArgumentsMenuID"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetArgumentsMenuID method"
ms.assetid: ecdb3daf-f5ed-4451-a2a7-22e0e17800d7
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CUserToolsManager::GetArgumentsMenuID
Returns the resource ID that is associated with the **Arguments** menu on the **Tools** tab of the **Customize** dialog box.  
  
## Syntax  
  
```  
UINT GetArgumentsMenuID() const;  
```  
  
## Return Value  
 The identifier of a menu resource.  
  
## Remarks  
 The `uArgMenuID` parameter of [CWinAppEx::EnableUserTools](../vs140/cwinappex--enableusertools.md) specifies the ID of the resource.  
  
## Requirements  
 **Header:** afxusertoolsmanager.h  
  
## See Also  
 [CUserToolsManager Class](../vs140/cusertoolsmanager-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)