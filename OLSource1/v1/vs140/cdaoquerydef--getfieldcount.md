---
title: "CDaoQueryDef::GetFieldCount"
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
  - "CDaoQueryDef::GetFieldCount"
  - "CDaoQueryDef.GetFieldCount"
  - "GetFieldCount"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "QueryDef objects, counting fields"
  - "GetFieldCount method"
  - "fields [C++], counting in querydefs"
  - "DAO (Data Access Objects), counting items"
  - "CDaoQueryDef class, counting querydef fields"
  - "counting fields in querydefs"
ms.assetid: 1184b443-630a-438e-b2a4-d8efccb2a992
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoQueryDef::GetFieldCount
Call this member function to retrieve the number of fields in the query.  
  
## Syntax  
  
```  
  
short GetFieldCount( );  
  
```  
  
## Return Value  
 The number of fields defined in the query.  
  
## Remarks  
 `GetFieldCount` is useful for looping through all fields in the querydef. For that purpose, use `GetFieldCount` in conjunction with [GetFieldInfo](../vs140/cdaoquerydef--getfieldinfo.md).  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoQueryDef Class](../vs140/cdaoquerydef-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)