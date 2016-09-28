---
title: "CDaoDatabase::GetQueryDefCount"
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
  - "GetQueryDefCount"
  - "CDaoDatabase::GetQueryDefCount"
  - "CDaoDatabase.GetQueryDefCount"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "QueryDef objects, counting"
  - "databases [C++], getting query information"
  - "counting querydefs"
  - "queries [C++], counting in QueryDef collection"
  - "QueryDef objects, getting information about"
  - "GetQueryDefCount method"
ms.assetid: f0a8f998-7af6-41ff-b056-649d3a205f2d
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoDatabase::GetQueryDefCount
Call this member function to retrieve the number of queries defined in the database's QueryDefs collection.  
  
## Syntax  
  
```  
  
short GetQueryDefCount( );  
  
```  
  
## Return Value  
 The number of queries defined in the database.  
  
## Remarks  
 `GetQueryDefCount` is useful if you need to loop through all querydefs in the QueryDefs collection. To obtain information about a given query in the collection, see [GetQueryDefInfo](../vs140/cdaodatabase--getquerydefinfo.md).  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoDatabase Class](../vs140/cdaodatabase-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)