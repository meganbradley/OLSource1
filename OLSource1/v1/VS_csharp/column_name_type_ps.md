---
title: "COLUMN_NAME_TYPE_PS"
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
  - "COLUMN_NAME_TYPE_PS"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COLUMN_NAME_TYPE_PS macro"
ms.assetid: 99df7e33-47fc-48ec-ad03-5fd03a190aa9
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COLUMN_NAME_TYPE_PS
Represents a binding on the rowset to the specific column in the rowset. Similar to [COLUMN_NAME](../VS_csharp/column_name.md), except that this macro also takes data type, precision, and scale.  
  
## Syntax  
  
```  
  
COLUMN_NAME_TYPE_PS(  
pszName  
,   
wType  
,   
nPrecision  
,   
nScale  
,   
data  
 )  
  
```  
  
#### Parameters  
 `pszName`  
 [in] A pointer to the column name. The name must be a Unicode string. You can accomplish this by putting an 'L' in front of the name, for example: `L"MyColumn"`.  
  
 `wType`  
 [in] The data type.  
  
 `nPrecision`  
 [in] The maximum precision to use when getting data and `wType` is `DBTYPE_NUMERIC`. Otherwise, this parameter is ignored.  
  
 `nScale`  
 [in] The scale to use when getting data and `wType` is `DBTYPE_NUMERIC` or **DBTYPE_DECIMAL**.  
  
 `data`  
 [in] The corresponding data member in the user record.  
  
## Remarks  
 See [COLUMN_NAME](../VS_csharp/column_name.md) for information on where the **COLUMN_NAME_\*** macros are used.  
  
## Requirements  
 **Header:** atldbcli.h  
  
## See Also  
 [Macros and Global Functions for OLE DB Consumer Templates](../VS_csharp/macros-and-global-functions-for-ole-db-consumer-templates.md)   
 [BEGIN_ACCESSOR](../VS_csharp/begin_accessor.md)   
 [BEGIN_ACCESSOR_MAP](../VS_csharp/begin_accessor_map.md)   
 [BEGIN_COLUMN_MAP](../VS_csharp/begin_column_map.md)   
 [COLUMN_NAME](../VS_csharp/column_name.md)   
 [COLUMN_NAME_EX](../VS_csharp/column_name_ex.md)   
 [COLUMN_NAME_LENGTH](../VS_csharp/column_name_length.md)   
 [COLUMN_NAME_LENGTH_STATUS](../VS_csharp/column_name_length_status.md)   
 [COLUMN_NAME_STATUS](../VS_csharp/column_name_status.md)   
 [COLUMN_NAME_PS](../VS_csharp/column_name_ps.md)   
 [COLUMN_NAME_PS_LENGTH](../VS_csharp/column_name_ps_length.md)   
 [COLUMN_NAME_PS_STATUS](../VS_csharp/column_name_ps_status.md)   
 [COLUMN_NAME_PS_LENGTH_STATUS](../VS_csharp/column_name_ps_length_status.md)   
 [COLUMN_NAME_TYPE](../VS_csharp/column_name_type.md)   
 [COLUMN_NAME_TYPE_SIZE](../VS_csharp/column_name_type_size.md)   
 [COLUMN_NAME_TYPE_STATUS](../VS_csharp/column_name_type_status.md)