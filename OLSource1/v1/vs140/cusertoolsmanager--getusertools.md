---
title: "CUserToolsManager::GetUserTools"
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
  - "GetUserTools"
  - "CUserToolsManager::GetUserTools"
  - "CUserToolsManager.GetUserTools"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetUserTools method"
ms.assetid: 7c607435-02e9-4562-a983-dd00e04b4081
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CUserToolsManager::GetUserTools
Returns a reference to the list of user tools.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A const reference to a [CObList](../vs140/coblist-class.md) object that contains a list of user tools.  
  
## Remarks  
 Call this method to retrieve a list of user tools that the [CUserToolsManager Class](../vs140/cusertoolsmanager-class.md) object maintains. Each user tool is represented by an object of type [CUserTool Class](../vs140/cusertool-class.md) or a type derived from <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>. The type is specified by the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> parameter when you call [CWinAppEx::EnableUserTools](../vs140/cwinappex--enableusertools.md) to enable user tools.  
  
## Requirements  
 **Header:** afxusertoolsmanager.h  
  
## See Also  
 [CUserToolsManager Class](../vs140/cusertoolsmanager-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)