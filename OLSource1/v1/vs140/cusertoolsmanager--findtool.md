---
title: "CUserToolsManager::FindTool"
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
  - "CUserToolsManager::FindTool"
  - "FindTool"
  - "CUserToolsManager.FindTool"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "FindTool method"
ms.assetid: 885a2620-39e1-4166-952f-b69afb3f6d84
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CUserToolsManager::FindTool
Returns the pointer to the [CUserTool Class](../vs140/cusertool-class.md) object that is associated with a specified command ID.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A menu command identifier.  
  
## Return Value  
 A pointer to a [CUserTool Class](../vs140/cusertool-class.md) or <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>-derived object if success; otherwise <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Remarks  
 When <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is successful, the returned type is the same as the type of the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> parameter to [CWinAppEx::EnableUserTools](../vs140/cwinappex--enableusertools.md).  
  
## Requirements  
 **Header:** afxusertoolsmanager.h  
  
## See Also  
 [CUserToolsManager Class](../vs140/cusertoolsmanager-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)