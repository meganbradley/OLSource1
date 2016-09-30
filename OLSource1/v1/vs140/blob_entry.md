---
title: "BLOB_ENTRY"
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
  - "BLOB_ENTRY"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "BLOB_ENTRY macro"
ms.assetid: 89e40678-0869-49ed-b502-0fa2630a9081
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# BLOB_ENTRY
Used with <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> to bind a binary large object ([BLOB](https://msdn.microsoft.com/en-us/library/ms711511.aspx)).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] The column number.  
  
 *IID*  
 [in] Interface GUID, such as **IDD_ISequentialStream**, used to retrieve the BLOB.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [in] Storage-mode flags as defined by the OLE Structured Storage model (for example, **STGM_READ**).  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
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
 [BLOB_ENTRY_LENGTH](../vs140/blob_entry_length.md)   
 [BLOB_ENTRY_LENGTH_STATUS](../vs140/blob_entry_length_status.md)   
 [BLOB_ENTRY_STATUS](../vs140/blob_entry_status.md)