---
title: "CDaoWorkspace::CDaoWorkspace"
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
  - "CDaoWorkspace::CDaoWorkspace"
  - "CDaoWorkspace.CDaoWorkspace"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "workspaces [C++], temporary"
  - "temporary workspaces"
  - "CDaoWorkspace class, constructor"
  - "DAO [C++], constructors"
  - "workspaces [C++], persistence"
  - "workspaces [C++], constructing"
  - "CDaoWorkspace constructor"
ms.assetid: a2496947-7cdb-47dc-bcd4-311d497a6352
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoWorkspace::CDaoWorkspace
Constructs a `CDaoWorkspace` object.  
  
## Syntax  
  
```  
  
CDaoWorkspace( );  
  
```  
  
## Remarks  
 After constructing the C++ object, you have two options:  
  
-   Call the object's [Open](../vs140/cdaoworkspace--open.md) member function to open the default workspace or to open an existing object in the Workspaces collection.  
  
-   Or call the object's [Create](../vs140/cdaoworkspace--create.md) member function to create a new DAO workspace object. This explicitly starts a new workspace session, which you can refer to via the `CDaoWorkspace` object. After calling **Create**, you can call [Append](../vs140/cdaoworkspace--append.md) if you want to add the workspace to the database engine's Workspaces collection.  
  
 See the class overview for [CDaoWorkspace](../vs140/cdaoworkspace-class.md) for information about when you need to explicitly create a `CDaoWorkspace` object. Usually, you use workspaces created implicitly when you open a [CDaoDatabase](../vs140/cdaodatabase-class.md) object without specifying a workspace or when you open a [CDaoRecordset](../vs140/cdaorecordset-class.md) object without specifying a database object. MFC DAO objects created in this way use DAO's default workspace, which is created once and reused.  
  
 To release a workspace and its contained objects, call the workspace object's [Close](../vs140/cdaoworkspace--close.md) member function.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoWorkspace Class](../vs140/cdaoworkspace-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)