---
title: "PROVIDER_COLUMN_ENTRY_STR"
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
  - "PROVIDER_COLUMN_ENTRY_STR"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "PROVIDER_COLUMN_ENTRY_STR macro"
ms.assetid: f1c27dd6-9ab8-4821-8685-d4dd15e76e88
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# PROVIDER_COLUMN_ENTRY_STR
Represents a specific column supported by the provider.  
  
## Syntax  
  
```  
  
PROVIDER_COLUMN_ENTRY_STR(  
name  
, ordinal, member )  
```  
  
#### Parameters  
 *name*  
 [in] The column name.  
  
 `ordinal`  
 [in] The column number. Unless the column is a Bookmark column, the column number must not be 0.  
  
 `member`  
 [in] The member variable in the data class that stores the data.  
  
## Remarks  
 Use this macro when the column data is assumed to be [DBTYPE_STR](https://msdn.microsoft.com/en-us/library/ms711251.aspx).  
  
## Example  
 See [BEGIN_PROVIDER_COLUMN_MAP](../VS_csharp/begin_provider_column_map.md).  
  
## Requirements  
 **Header:** atldb.h  
  
## See Also  
 [Macros for OLE DB Provider Templates](../VS_csharp/macros-for-ole-db-provider-templates.md)   
 [OLE DB Provider Templates](../VS_csharp/ole-db-provider-templates--c---.md)   
 [OLE DB Provider Template Architecture](../VS_csharp/ole-db-provider-template-architecture.md)   
 [Creating an OLE DB Provider](../VS_csharp/creating-an-ole-db-provider.md)