---
title: "CUserToolsManager::MoveToolDown"
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
  - "CUserToolsManager::MoveToolDown"
  - "CUserToolsManager.MoveToolDown"
  - "MoveToolDown"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "MoveToolDown method"
ms.assetid: 6b222100-905e-45c1-959f-6e63e699d822
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CUserToolsManager::MoveToolDown
Moves the specified user tool down in the list of user tools.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the user tool to move.  
  
## Return Value  
 Nonzero if the user tool was moved down successfully; otherwise 0.  
  
## Remarks  
 The method fails if the tool that the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> specifies is not in the internal list or if the tool is last in the list.  
  
## Requirements  
 **Header:** afxusertoolsmanager.h  
  
## See Also  
 [CUserToolsManager Class](../vs140/cusertoolsmanager-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)