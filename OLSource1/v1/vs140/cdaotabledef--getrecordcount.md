---
title: "CDaoTableDef::GetRecordCount"
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
  - "CDaoTableDef.GetRecordCount"
  - "CDaoTableDef::GetRecordCount"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDaoTableDef class, getting record counts"
  - "tabledefs, getting record count"
  - "GetRecordCount method"
ms.assetid: 41bcbb3c-f01f-4d39-8572-de072090b08e
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoTableDef::GetRecordCount
Call this member function to find out how many records are in a `CDaoTableDef` object.  
  
## Syntax  
  
```  
  
long GetRecordCount( );  
  
```  
  
## Return Value  
 The number of records accessed in a tabledef object.  
  
## Remarks  
 Calling `GetRecordCount` for a table-type `CDaoTableDef` object reflects the approximate number of records in the table and is affected immediately as table records are added and deleted. Rolled back transactions will appear as part of the record count until you call [CDaoWorkSpace::CompactDatabase](../vs140/cdaoworkspace--compactdatabase.md). A `CDaoTableDef` object with no records has a record count property setting of 0. When working with attached tables or ODBC databases, `GetRecordCount` always returns –1.  
  
 For related information, see the topic "RecordCount Property" in DAO Help.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoTableDef Class](../vs140/cdaotabledef-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoTableDef::GetSourceTableName](../vs140/cdaotabledef--getsourcetablename.md)   
 [CDaoTableDef::SetSourceTableName](../vs140/cdaotabledef--setsourcetablename.md)