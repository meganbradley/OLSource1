---
title: "CDaoWorkspace::GetDatabaseCount"
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
  - "CDaoWorkspace.GetDatabaseCount"
  - "CDaoWorkspace::GetDatabaseCount"
  - "GetDatabaseCount"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetDatabaseCount method"
  - "DAO [C++], getting workspace information"
  - "Databases collection, counting"
  - "databases [C++], counting open"
  - "open databases [C++], counting"
  - "workspaces [C++], count of databases"
  - "DAO [C++], counting items"
ms.assetid: 622fdd73-42b7-4308-a039-61c38826a08c
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoWorkspace::GetDatabaseCount
Call this member function to retrieve the number of DAO database objects in the workspace's Databases collection — the number of open databases in the workspace.  
  
## Syntax  
  
```  
  
short GetDatabaseCount( );  
  
```  
  
## Return Value  
 The number of open databases in the workspace.  
  
## Remarks  
 `GetDatabaseCount` is useful if you need to loop through all defined databases in the workspace's Databases collection. To obtain information about a given database in the collection, see [GetDatabaseInfo](../vs140/cdaoworkspace--getdatabaseinfo.md). Typical usage is to call `GetDatabaseCount` for the number of open databases, then use that number as a loop index for repeated calls to `GetDatabaseInfo`.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoWorkspace Class](../vs140/cdaoworkspace-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)