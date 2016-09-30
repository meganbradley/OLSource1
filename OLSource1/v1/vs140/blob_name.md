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
Used with <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> to bind a binary large object ([BLOB](https://msdn.microsoft.com/en-us/library/ms711511.aspx)). Similar to [BLOB_ENTRY](../vs140/blob_entry.md), except that this macro takes a column name instead of a column number.  
  
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
  
## Example  
 See [How Can I Retrieve a BLOB?](../vs140/retrieving-a-blob.md).  
  
## Requirements  
 **Header:** atldbcli.h  
  
## See Also  
 [Macros and Global Functions for OLE DB Consumer Templates](../vs140/macros-and-global-functions-for-ole-db-consumer-templates.md)   
 [BEGIN_COLUMN_MAP](../vs140/begin_column_map.md)   
 [END_COLUMN_MAP](../vs140/end_column_map.md)   
 [COLUMN_ENTRY](../vs140/column_entry.md)   
 [BLOB_NAME_LENGTH](../vs140/blob_name_length.md)   
 [BLOB_NAME_LENGTH_STATUS](../vs140/blob_name_length_status.md)   
 [BLOB_NAME_STATUS](../vs140/blob_name_status.md)