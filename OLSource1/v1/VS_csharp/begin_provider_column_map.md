---
title: "BEGIN_PROVIDER_COLUMN_MAP"
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
  - "BEGIN_PROVIDER_COLUMN_MAP"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "BEGIN_PROVIDER_COLUMN_MAP macro"
ms.assetid: 506b8c0f-6be9-4c97-ba81-c4b7f7d428fa
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# BEGIN_PROVIDER_COLUMN_MAP
Marks the beginning of the provider column map entries.  
  
## Syntax  
  
```  
  
BEGIN_PROVIDER_COLUMN_MAP(  
theClass   
)  
  
```  
  
#### Parameters  
 `theClass`  
 [in] The name of the class this map belongs to.  
  
## Example  
 Here is a sample provider column map:  
  
 [!code[NVC_OLEDB_Provider#4](../VS_csharp/codesnippet/CPP/begin_provider_column_map_1.h)]  
  
## Requirements  
 **Header:** atldb.h  
  
## See Also  
 [Macros for OLE DB Provider Templates](../VS_csharp/macros-for-ole-db-provider-templates.md)   
 [OLE DB Provider Templates](../VS_csharp/ole-db-provider-templates--c---.md)   
 [OLE DB Provider Template Architecture](../VS_csharp/ole-db-provider-template-architecture.md)   
 [Creating an OLE DB Provider](../VS_csharp/creating-an-ole-db-provider.md)