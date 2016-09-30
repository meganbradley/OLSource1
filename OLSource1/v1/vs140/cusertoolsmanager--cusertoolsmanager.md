---
title: "CUserToolsManager::CUserToolsManager"
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
  - "CUserToolsManager.CUserToolsManager"
  - "CUserToolsManager"
  - "CUserToolsManager::CUserToolsManager"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CUserToolsManager class, constructor"
ms.assetid: 7254bb70-d3e0-4dbd-a62d-e34c2866415e
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CUserToolsManager::CUserToolsManager
Constructs a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>. Each application must have at most one user tools manager.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 An unsigned integer that the framework uses as a placeholder for the command ID of the user tools menu.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The command ID for the first user tool command.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The command ID for the last user tool command.  
  
 [in] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The class that [CUserToolsManager::CreateNewTool](../vs140/cusertoolsmanager--createnewtool.md) creates. By using this class, you can use a derived type of [CUserTool](../vs140/cusertool-class.md) instead of the default implementation.  
  
 [in] <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The menu resource ID of the arguments popup menu.  
  
 [in] <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The menu resource ID of the initial directory popup menu.  
  
## Remarks  
 Do not call this constructor. Instead, call [CWinAppEx::EnableUserTools](../vs140/cwinappex--enableusertools.md) to enable user tools, and call [CWinAppEx::GetUserToolsManager](../vs140/cwinappex--getusertoolsmanager.md) to obtain a pointer to the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. For more information, see [User Defined Tools](../vs140/user-defined-tools.md).  
  
## Requirements  
 **Header:** afxusertoolsmanager.h  
  
## See Also  
 [CUserToolsManager Class](../vs140/cusertoolsmanager-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)