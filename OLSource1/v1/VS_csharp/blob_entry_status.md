---
title: "BLOB_ENTRY_STATUS"
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
  - "BLOB_ENTRY_STATUS"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "BLOB_ENTRY_STATUS macro"
ms.assetid: 191007f4-dfcc-4ae2-a7fc-6f7899accc9f
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# BLOB_ENTRY_STATUS
Used with `BEGIN_COLUMN_MAP` or `BEGIN_ACCESSOR_MAP` to bind a binary large object ([BLOB](https://msdn.microsoft.com/en-us/library/ms711511.aspx)). Similar to [BLOB_ENTRY](../VS_csharp/blob_entry.md), except that this macro also gets the status of the BLOB column.  
  
## Syntax  
  
```  
  
BLOB_ENTRY_STATUS(  
nOrdinal  
,   
IID  
,   
flags  
,   
data  
,   
status  
 )  
  
```  
  
#### Parameters  
 `nOrdinal`  
 [in] The column number.  
  
 *IID*  
 [in] Interface GUID, such as **IDD_ISequentialStream**, used to retrieve the BLOB.  
  
 `flags`  
 [in] Storage-mode flags as defined by the OLE Structured Storage model (for example, **STGM_READ**).  
  
 `data`  
 [in] The corresponding data member in the user record.  
  
 *status*  
 [out] The status of the BLOB field.  
  
## Example  
 See [How Can I Retrieve a BLOB?](../VS_csharp/retrieving-a-blob.md).  
  
## Requirements  
 **Header:** atldbcli.h  
  
## See Also  
 [Macros and Global Functions for OLE DB Consumer Templates](../VS_csharp/macros-and-global-functions-for-ole-db-consumer-templates.md)   
 [BEGIN_COLUMN_MAP](../VS_csharp/begin_column_map.md)   
 [END_COLUMN_MAP](../VS_csharp/end_column_map.md)   
 [COLUMN_ENTRY](../VS_csharp/column_entry.md)   
 [BLOB_ENTRY](../VS_csharp/blob_entry.md)   
 [BLOB_ENTRY_LENGTH](../VS_csharp/blob_entry_length.md)   
 [BLOB_ENTRY_LENGTH_STATUS](../VS_csharp/blob_entry_length_status.md)