---
title: "BLOB_NAME_LENGTH_STATUS"
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
  - "BLOB_NAME_LENGTH_STATUS"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "BLOB_NAME_LENGTH_STATUS macro"
ms.assetid: 3cc3ec8d-80a5-4522-848a-123fcaee58cb
caps.latest.revision: 11
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# BLOB_NAME_LENGTH_STATUS
Used with `BEGIN_COLUMN_MAP` and `END_COLUMN_MAP` to bind a binary large object ([BLOB](https://msdn.microsoft.com/en-us/library/ms711511.aspx)). Similar to [BLOB_NAME](../vs140/blob_name.md), except that this macro also gets the length and status of the BLOB data column.  
  
## Syntax  
  
```  
  
BLOB_NAME_LENGTH_STATUS(  
pszName  
,   
IID  
,   
flags  
,   
data  
,   
length  
, status )  
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
  
 *length*  
 [out] The (actual) length in bytes of the BLOB column.  
  
 *status*  
 [out] The status of the BLOB field.  
  
## Requirements  
 **Header:** atldbcli.h  
  
## See Also  
 [Macros and Global Functions for OLE DB Consumer Templates](../vs140/macros-and-global-functions-for-ole-db-consumer-templates.md)   
 [BEGIN_COLUMN_MAP](../vs140/begin_column_map.md)   
 [END_COLUMN_MAP](../vs140/end_column_map.md)   
 [COLUMN_ENTRY](../vs140/column_entry.md)   
 [BLOB_NAME](../vs140/blob_name.md)   
 [BLOB_NAME_LENGTH](../vs140/blob_name_length.md)   
 [BLOB_NAME_STATUS](../vs140/blob_name_status.md)