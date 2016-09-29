---
title: "BEGIN_SCHEMA_MAP"
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
  - "BEGIN_SCHEMA_MAP"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "BEGIN_SCHEMA_MAP macro"
ms.assetid: 4e751023-35bc-4efd-9018-5448dd1ad751
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# BEGIN_SCHEMA_MAP
Denotes the beginning of a schema map.  
  
## Syntax  
  
```  
  
      BEGIN_SCHEMA_MAP(  
   SchemaClass   
);  
```  
  
#### Parameters  
 *SchemaClass*  
 The class that contains the MAP. Typically this will be the session class.  
  
## Remarks  
 See [IDBSchemaRowset](https://msdn.microsoft.com/en-us/library/ms713686.aspx) in the [!INCLUDE[winSDK](../VS_csharp/includes/winsdk_md.md)] for more information about schema rowsets.  
  
## Requirements  
 **Header:** atldb.h  
  
## See Also  
 [Macros for OLE DB Provider Templates](../VS_csharp/macros-for-ole-db-provider-templates.md)   
 [SCHEMA_ENTRY](../VS_csharp/schema_entry.md)   
 [END_SCHEMA_MAP](../VS_csharp/end_schema_map.md)   
 [IDBSchemaRowsetImpl Class](../VS_csharp/idbschemarowsetimpl-class.md)