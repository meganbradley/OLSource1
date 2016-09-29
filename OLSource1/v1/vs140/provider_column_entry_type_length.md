---
title: "PROVIDER_COLUMN_ENTRY_TYPE_LENGTH"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "PROVIDER_COLUMN_ENTRY_TYPE_LENGTH"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "PROVIDER_COLUMN_ENTRY_TYPE_LENGTH macro"
ms.assetid: a60b1a8b-0903-4ff4-91ec-ed62126449fb
caps.latest.revision: 11
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# PROVIDER_COLUMN_ENTRY_TYPE_LENGTH
Represents a specific column supported by the provider.  
  
## Syntax  
  
```  
  
PROVIDER_COLUMN_ENTRY_TYPE_LENGTH(  
name  
, ordinal, dbtype, size, member )  
```  
  
#### Parameters  
 *name*  
  
 [in] The column name.  
  
 `ordinal`  
 [in] The column number. Unless the column is a Bookmark column, the column number must not be 0.  
  
 `dbtype`  
 [in] The data type in [DBTYPE](https://msdn.microsoft.com/en-us/library/ms711251.aspx).  
  
 `size`  
 [in] The column size in bytes.  
  
 `member`  
 [in] The member variable in the data class that stores the data.  
  
## Remarks  
 Similar to [PROVIDER_COLUMN_ENTRY_LENGTH](../vs140/provider_column_entry_length.md) but also allows you to specify the column's data type as well as size.  
  
## Requirements  
 **Header:** atldb.h  
  
## See Also  
 [Macros for OLE DB Provider Templates](../vs140/macros-for-ole-db-provider-templates.md)   
 [OLE DB Provider Templates](../vs140/ole-db-provider-templates--c---.md)   
 [OLE DB Provider Template Architecture](../vs140/ole-db-provider-template-architecture.md)   
 [Creating an OLE DB Provider](../vs140/creating-an-ole-db-provider.md)