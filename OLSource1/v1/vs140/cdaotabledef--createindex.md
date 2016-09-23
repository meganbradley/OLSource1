---
title: "CDaoTableDef::CreateIndex"
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
  - CDaoTableDef::CreateIndex
  - CreateIndex
  - CDaoTableDef.CreateIndex
dev_langs: 
  - C++
helpviewer_keywords: 
  - tabledefs, creating indexes
  - CDaoTableDef class, creating indexes
  - CreateIndex method
ms.assetid: 6badd94b-038a-42be-bdde-7e30413d706d
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CDaoTableDef::CreateIndex
Call this function to add an index to a table.  
  
## Syntax  
  
```  
  
      void CreateIndex(   
   CDaoIndexInfo& indexinfo    
);  
```  
  
#### Parameters  
 `indexinfo`  
 A reference to a [CDaoIndexInfo](../vs140/cdaoindexinfo-structure.md) structure.  
  
## Remarks  
 Indexes specify the order of records accessed from database tables and whether or not duplicate records are accepted. Indexes also provide efficient access to data.  
  
 You do not have to create indexes for tables, but in large, unindexed tables, accessing a specific record or creating a recordset can take a long time. On the other hand, creating too many indexes slows down update, append, and delete operations as all indexes are automatically updated. Consider these factors as you decide which indexes to create.  
  
 The following members of the `CDaoIndexInfo` structure must be set:  
  
-   **m_strName** A name must be supplied.  
  
-   `m_pFieldInfos` Must point to an array of `CDaoIndexFieldInfo` structures.  
  
-   `m_nFields` Must specify the number of fields in the array of `CDaoFieldInfo` structures.  
  
 The remaining members will be ignored if set to **FALSE**. In addition, the **m_lDistinctCount** member is ignored during creation of the index.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoTableDef Class](../vs140/cdaotabledef-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoTableDef::DeleteIndex](../vs140/cdaotabledef--deleteindex.md)   
 [CDaoTableDef::CreateField](../vs140/cdaotabledef--createfield.md)   
 [CDaoTableDef::DeleteField](../vs140/cdaotabledef--deletefield.md)   
 [CDaoIndexInfo Structure](../vs140/cdaoindexinfo-structure.md)