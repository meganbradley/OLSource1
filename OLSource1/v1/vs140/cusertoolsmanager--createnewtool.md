---
title: "CUserToolsManager::CreateNewTool"
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
  - "CUserToolsManager::CreateNewTool"
  - "CreateNewTool"
  - "CUserToolsManager.CreateNewTool"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CreateNewTool method"
ms.assetid: 2f724fe3-632d-40c4-a3ed-4ad15218d6f3
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CUserToolsManager::CreateNewTool
Creates a new user tool.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A pointer to the newly created user tool, or <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> if the number of user tools has exceeded the maximum. The returned type is the same as the type that is passed to <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> as the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> parameter.  
  
## Remarks  
 This method finds the first available menu command ID in the range that is supplied in the call to [CWinAppEx::EnableUserTools](../vs140/cwinappex--enableusertools.md) and assigns the user tool this ID.  
  
 The method fails if the number of tools has reached the maximum. This occurs when all command IDs within the range are assigned to user tools. You can retrieve the maximum number of tools by calling [CUserToolsManager::GetMaxTools](../vs140/cusertoolsmanager--getmaxtools.md). You can get access to the tools list by calling the [CUserToolsManager::GetUserTools](../vs140/cusertoolsmanager--getusertools.md) method.  
  
## Requirements  
 **Header:** afxusertoolsmanager.h  
  
## See Also  
 [CUserToolsManager Class](../vs140/cusertoolsmanager-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)