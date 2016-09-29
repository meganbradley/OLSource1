---
title: "COLUMN_NAME"
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
  - "COLUMN_NAME"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COLUMN_NAME macro"
ms.assetid: a213b9a0-2148-4a08-9111-d9fa8fdec462
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COLUMN_NAME
Represents a binding on the rowset to the specific column in the rowset. Similar to [COLUMN_ENTRY](../VS_csharp/column_entry.md), except that this macro takes the column name instead of the column number.  
  
## Syntax  
  
```  
  
COLUMN_NAME(  
pszName  
,   
data  
 )  
  
```  
  
#### Parameters  
 `pszName`  
 [in] A pointer to the column name. The name must be a Unicode string. You can accomplish this by putting an 'L' in front of the name, for example: `L"MyColumn"`.  
  
 `data`  
 [in] The corresponding data member in the user record.  
  
## Remarks  
 The **COLUMN_NAME_\*** macros are used in the same places as [COLUMN_ENTRY](../VS_csharp/column_entry.md):  
  
-   Between the [BEGIN_COLUMN_MAP](../VS_csharp/begin_column_map.md) and [END_COLUMN_MAP](../VS_csharp/end_column_map.md) macros.  
  
-   Between the [BEGIN_ACCESSOR](../VS_csharp/begin_accessor.md) and [END_ACCESSOR](../VS_csharp/end_accessor.md) macros.  
  
-   Between the [BEGIN_PARAM_MAP](../VS_csharp/begin_param_map.md) and [END_PARAM_MAP](../VS_csharp/end_param_map.md) macros.  
  
## Requirements  
 **Header:** atldbcli.h  
  
## See Also  
 [Macros and Global Functions for OLE DB Consumer Templates](../VS_csharp/macros-and-global-functions-for-ole-db-consumer-templates.md)   
 [BEGIN_ACCESSOR](../VS_csharp/begin_accessor.md)   
 [BEGIN_ACCESSOR_MAP](../VS_csharp/begin_accessor_map.md)   
 [BEGIN_COLUMN_MAP](../VS_csharp/begin_column_map.md)   
 [COLUMN_NAME_EX](../VS_csharp/column_name_ex.md)   
 [COLUMN_NAME_LENGTH](../VS_csharp/column_name_length.md)   
 [COLUMN_NAME_LENGTH_STATUS](../VS_csharp/column_name_length_status.md)   
 [COLUMN_NAME_STATUS](../VS_csharp/column_name_status.md)   
 [COLUMN_NAME_PS](../VS_csharp/column_name_ps.md)   
 [COLUMN_NAME_PS_LENGTH](../VS_csharp/column_name_ps_length.md)   
 [COLUMN_NAME_PS_STATUS](../VS_csharp/column_name_ps_status.md)   
 [COLUMN_NAME_PS_LENGTH_STATUS](../VS_csharp/column_name_ps_length_status.md)   
 [COLUMN_NAME_TYPE](../VS_csharp/column_name_type.md)   
 [COLUMN_NAME_TYPE_PS](../VS_csharp/column_name_type_ps.md)   
 [COLUMN_NAME_TYPE_SIZE](../VS_csharp/column_name_type_size.md)   
 [COLUMN_NAME_TYPE_STATUS](../VS_csharp/column_name_type_status.md)