---
title: "CDaoTableDef::GetIndexCount"
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
  - "GetIndexCount"
  - "CDaoTableDef::GetIndexCount"
  - "CDaoTableDef.GetIndexCount"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "tabledefs, getting index info"
  - "CDaoTableDef class, getting index information"
  - "GetIndexCount method"
ms.assetid: db12476a-5f00-4eda-94e5-ddfd75d0341a
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoTableDef::GetIndexCount
Call this member function to obtain the number of indexes for a table.  
  
## Syntax  
  
```  
  
short GetIndexCount( );  
  
```  
  
## Return Value  
 The number of indexes for the table.  
  
## Remarks  
 If its value is 0, there are no indexes in the collection.  
  
 For related information, see the topic "Count Property" in DAO Help.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoTableDef Class](../vs140/cdaotabledef-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoTableDef::GetIndexInfo](../vs140/cdaotabledef--getindexinfo.md)   
 [CDaoTableDef::GetFieldInfo](../vs140/cdaotabledef--getfieldinfo.md)   
 [CDaoTableDef::GetFieldCount](../vs140/cdaotabledef--getfieldcount.md)