---
title: "COLUMN_ENTRY_PS_LENGTH_STATUS"
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
  - "COLUMN_ENTRY_PS_LENGTH_STATUS"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COLUMN_ENTRY_PS_LENGTH_STATUS macro"
ms.assetid: 04291671-329d-4974-b04e-36ef3f037787
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COLUMN_ENTRY_PS_LENGTH_STATUS
Represents a binding on the rowset to the specific column in the database.  
  
## Syntax  
  
```  
  
COLUMN_ENTRY_PS_LENGTH_STATUS(  
nOrdinal  
,   
nPrecision  
,   
nScale  
,   
data  
,   
length  
,   
status  
 )  
  
```  
  
#### Parameters  
 See [DBBINDING](https://msdn.microsoft.com/en-us/library/ms716845.aspx) in the *OLE DB Programmer's Reference*.  
  
 `nOrdinal`  
 [in] The column number.  
  
 `nPrecision`  
 [in] The maximum precision of the column you want to bind.  
  
 `nScale`  
 [in] The scale of the column you want to bind.  
  
 `data`  
 [in] The corresponding data member in the user record.  
  
 *length*  
 [in] The variable to be bound to the column length.  
  
 *status*  
 [in] The variable to be bound to the column status.  
  
## Remarks  
 Allows you to specify the precision and scale of the column you want to bind. Use this macro when you want to support length and status variables. It is used in the following places:  
  
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
 [COLUMN_ENTRY](../VS_csharp/column_entry.md)   
 [COLUMN_ENTRY_EX](../VS_csharp/column_entry_ex.md)   
 [COLUMN_ENTRY_LENGTH](../VS_csharp/column_entry_length.md)   
 [COLUMN_ENTRY_PS](../VS_csharp/column_entry_ps.md)   
 [COLUMN_ENTRY_PS_LENGTH](../VS_csharp/column_entry_ps_length.md)   
 [COLUMN_ENTRY_LENGTH_STATUS](../VS_csharp/column_entry_length_status.md)   
 [COLUMN_ENTRY_STATUS](../VS_csharp/column_entry_status.md)   
 [COLUMN_ENTRY_PS_STATUS](../VS_csharp/column_entry_ps_status.md)   
 [END_ACCESSOR](../VS_csharp/end_accessor.md)   
 [END_ACCESSOR_MAP](../VS_csharp/end_accessor_map.md)   
 [END_COLUMN_MAP](../VS_csharp/end_column_map.md)