---
title: "CDaoDatabase::CanUpdate"
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
  - "CDaoDatabase.CanUpdate"
  - "CDaoDatabase::CanUpdate"
  - "CanUpdate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "updatability [C++]"
  - "databases [C++], updating"
  - "CanUpdate method"
  - "CDaoDatabase class, update support"
  - "DAO [C++], update support"
ms.assetid: 612f0449-c795-4f0b-96e9-d61884543f2b
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoDatabase::CanUpdate
Call this member function to determine whether the `CDaoDatabase` object allows updates.  
  
## Syntax  
  
```  
  
BOOL CanUpdate( );  
  
```  
  
## Return Value  
 Nonzero if the `CDaoDatabase` object allows updates; otherwise 0, indicating either that you passed **TRUE** in `bReadOnly` when you opened the `CDaoDatabase` object or that the database itself is read-only. See the [Open](../vs140/cdaodatabase--open.md) member function.  
  
## Remarks  
 For information about database updatability, see the topic "Updatable Property" in DAO Help.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoDatabase Class](../vs140/cdaodatabase-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)