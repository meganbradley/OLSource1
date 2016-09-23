---
title: "CDaoDatabase::m_pWorkspace"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CDaoDatabase::m_pWorkspace
  - CDaoDatabase.m_pWorkspace
  - m_pWorkspace
dev_langs: 
  - C++
helpviewer_keywords: 
  - m_pWorkspace
  - databases [C++], pointers to workspaces
  - workspaces [C++], pointers to
  - pointers [C++], to workspace objects
  - DAO [C++], pointer to workspace objects
  - databases [C++], workspaces
ms.assetid: 5b2be089-be12-4369-90be-4aa9fdb3fdc7
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CDaoDatabase::m_pWorkspace
Contains a pointer to the [CDaoWorkspace](../vs140/cdaoworkspace-class.md) object that contains the database object.  
  
## Remarks  
 Use this pointer if you need to access the workspace directly — for example, to obtain pointers to other database objects in the workspace's Databases collection.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoDatabase Class](../vs140/cdaodatabase-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)