---
title: "CDaoTableDef::GetFieldCount"
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
  - CDaoTableDef.GetFieldCount
  - GetFieldCount
  - CDaoTableDef::GetFieldCount
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetFieldCount method
  - tabledefs, getting field info
  - CDaoTableDef class, getting field counts
ms.assetid: 40e5e509-f282-4565-ab34-3043769b01dc
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CDaoTableDef::GetFieldCount
Call this member function to retrieve the number of fields defined in the table.  
  
## Syntax  
  
```  
  
short GetFieldCount( );  
  
```  
  
## Return Value  
 The number of fields in the table.  
  
## Remarks  
 If its value is 0, there are no objects in the collection.  
  
 For related information, see the topic "Count Property" in DAO Help.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoTableDef Class](../vs140/cdaotabledef-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoTableDef::GetFieldInfo](../vs140/cdaotabledef--getfieldinfo.md)   
 [CDaoTableDef::GetIndexInfo](../vs140/cdaotabledef--getindexinfo.md)   
 [CDaoTableDef::GetIndexCount](../vs140/cdaotabledef--getindexcount.md)