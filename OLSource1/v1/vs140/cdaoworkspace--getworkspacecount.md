---
title: "CDaoWorkspace::GetWorkspaceCount"
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
  - "CDaoWorkspace::GetWorkspaceCount"
  - "CDaoWorkspace.GetWorkspaceCount"
  - "GetWorkspaceCount"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DAO [C++], getting workspace information"
  - "GetWorkspaceCount method"
  - "DAO [C++], counting items"
  - "workspaces [C++], counting"
ms.assetid: b3b81088-d730-4a3e-837e-2d769f3a4363
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoWorkspace::GetWorkspaceCount
Call this member function to retrieve the number of DAO workspace objects in the database engine's Workspaces collection.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 The number of open workspaces in the Workspaces collection.  
  
## Remarks  
 This count does not include any open workspaces not appended to the collection. <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> is useful if you need to loop through all defined workspaces in the Workspaces collection. To obtain information about a given workspace in the collection, see [GetWorkspaceInfo](../vs140/cdaoworkspace--getworkspaceinfo.md). Typical usage is to call <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> for the number of open workspaces, then use that number as a loop index for repeated calls to <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoWorkspace Class](../vs140/cdaoworkspace-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)