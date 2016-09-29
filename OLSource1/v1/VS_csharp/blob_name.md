---
title: "BLOB_NAME"
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
  - "BLOB_NAME"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "BLOB_NAME macro"
ms.assetid: 757acd0d-946d-447d-937e-94ecd700ba38
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# BLOB_NAME
Used with `BEGIN_COLUMN_MAP` and `END_COLUMN_MAP` to bind a binary large object ([BLOB](https://msdn.microsoft.com/en-us/library/ms711511.aspx)). Similar to [BLOB_ENTRY](../VS_csharp/blob_entry.md), except that this macro takes a column name instead of a column number.  
  
## Syntax  
  
```  
  
BLOB_NAME(  
pszName  
,   
IID  
,   
flags  
,   
data )  
```  
  
#### Parameters  
 `pszName`  
 [in] A pointer to the column name. The name must be a Unicode string. You can accomplish this by putting an 'L' in front of the name, for example: `L"MyColumn"`.  
  
 *IID*  
 [in] Interface GUID, such as **IDD_ISequentialStream**, used to retrieve the BLOB.  
  
 `flags`  
 [in] Storage-mode flags as defined by the OLE Structured Storage model (for example, **STGM_READ**).  
  
 `data`  
 [in] The corresponding data member in the user record.  
  
## Example  
 See [How Can I Retrieve a BLOB?](../VS_csharp/retrieving-a-blob.md).  
  
## Requirements  
 **Header:** atldbcli.h  
  
## See Also  
 [Macros and Global Functions for OLE DB Consumer Templates](../VS_csharp/macros-and-global-functions-for-ole-db-consumer-templates.md)   
 [BEGIN_COLUMN_MAP](../VS_csharp/begin_column_map.md)   
 [END_COLUMN_MAP](../VS_csharp/end_column_map.md)   
 [COLUMN_ENTRY](../VS_csharp/column_entry.md)   
 [BLOB_NAME_LENGTH](../VS_csharp/blob_name_length.md)   
 [BLOB_NAME_LENGTH_STATUS](../VS_csharp/blob_name_length_status.md)   
 [BLOB_NAME_STATUS](../VS_csharp/blob_name_status.md)