---
title: "CDaoWorkspace::Close"
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
  - "CDaoWorkspace::Close"
  - "CDaoWorkspace.Close"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Close method"
  - "workspaces [C++], closing"
ms.assetid: 5dde9776-0282-4615-b9ff-e3f548634a2c
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoWorkspace::Close
Call this member function to close the workspace object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 Closing an open workspace object releases the underlying DAO object and, if the workspace is a member of the Workspaces collection, removes it from the collection. Calling **Close** is good programming practice.  
  
> [!CAUTION]
>  Closing a workspace object closes any open databases in the workspace. This results in any recordsets open in the databases being closed as well, and any pending edits or updates are rolled back. For related information, see the [CDaoDatabase::Close](../vs140/cdaodatabase--close.md), [CDaoRecordset::Close](../vs140/cdaorecordset--close.md), [CDaoTableDef::Close](../vs140/cdaotabledef--close.md), and [CDaoQueryDef::Close](../vs140/cdaoquerydef--close.md) member functions.  
  
 Workspace objects are not permanent; they only exist while references to them exist. This means that when the database engine session ends, the workspace and its Databases collection do not persist. You must re-create them for the next session by opening your workspace and database(s) again.  
  
 For related information, see the topic "Close Method" in DAO Help.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoWorkspace Class](../vs140/cdaoworkspace-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoWorkspace::Open](../vs140/cdaoworkspace--open.md)