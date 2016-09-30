---
title: "BLOB_NAME_LENGTH"
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
  - "BLOB_NAME_LENGTH"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "BLOB_NAME_LENGTH macro"
ms.assetid: 38150260-a127-486d-a7ab-0d01b731b6fd
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# BLOB_NAME_LENGTH
Used with <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> to bind a binary large object ([BLOB](https://msdn.microsoft.com/en-us/library/ms711511.aspx)). Similar to [BLOB_NAME](../vs140/blob_name.md), except that this macro also gets the length in bytes of the BLOB data column.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] A pointer to the column name. The name must be a Unicode string. You can accomplish this by putting an 'L' in front of the name, for example: <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
 *IID*  
 [in] Interface GUID, such as **IDD_ISequentialStream**, used to retrieve the BLOB.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 [in] Storage-mode flags as defined by the OLE Structured Storage model (for example, **STGM_READ**).  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 [in] The corresponding data member in the user record.  
  
 *length*  
 [out] The (actual) length in bytes of the BLOB column.  
  
## Requirements  
 **Header:** atldbcli.h  
  
## See Also  
 [Macros and Global Functions for OLE DB Consumer Templates](../vs140/macros-and-global-functions-for-ole-db-consumer-templates.md)   
 [BEGIN_COLUMN_MAP](../vs140/begin_column_map.md)   
 [END_COLUMN_MAP](../vs140/end_column_map.md)   
 [COLUMN_ENTRY](../vs140/column_entry.md)   
 [BLOB_NAME](../vs140/blob_name.md)   
 [BLOB_NAME_LENGTH_STATUS](../vs140/blob_name_length_status.md)   
 [BLOB_NAME_STATUS](../vs140/blob_name_status.md)