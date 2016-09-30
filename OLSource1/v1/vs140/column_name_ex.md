---
title: "COLUMN_NAME_EX"
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
  - "COLUMN_NAME_EX"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COLUMN_NAME_EX macro"
ms.assetid: 4f916a85-f6ae-464a-9cbe-0a56dbb274a6
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COLUMN_NAME_EX
Represents a binding on the rowset to the specific column in the rowset. Similar to [COLUMN_NAME](../vs140/column_name.md), except that this macro also takes data type, size, precision, scale, column length, and column status.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [in] A pointer to the column name. The name must be a Unicode string. You can accomplish this by putting an 'L' in front of the name, for example: <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] The data type.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [in] The data size in bytes.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 [in] The maximum precision to use when getting data and <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. Otherwise, this parameter is ignored.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 [in] The scale to use when getting data and <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> or **DBTYPE_DECIMAL**.  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 [in] The corresponding data member in the user record.  
  
 *length*  
 [in] The variable to be bound to the column length.  
  
 *status*  
 [in] The variable to be bound to the column status.  
  
## Remarks  
 See [COLUMN_NAME](../vs140/column_name.md) for information on where the **COLUMN_NAME_\*** macros are used.  
  
## Requirements  
 **Header:** atldbcli.h  
  
## See Also  
 [Macros and Global Functions for OLE DB Consumer Templates](../vs140/macros-and-global-functions-for-ole-db-consumer-templates.md)   
 [BEGIN_ACCESSOR](../vs140/begin_accessor.md)   
 [BEGIN_ACCESSOR_MAP](../vs140/begin_accessor_map.md)   
 [BEGIN_COLUMN_MAP](../vs140/begin_column_map.md)   
 [COLUMN_NAME](../vs140/column_name.md)   
 [COLUMN_NAME_LENGTH](../vs140/column_name_length.md)   
 [COLUMN_NAME_LENGTH_STATUS](../vs140/column_name_length_status.md)   
 [COLUMN_NAME_STATUS](../vs140/column_name_status.md)   
 [COLUMN_NAME_PS](../vs140/column_name_ps.md)   
 [COLUMN_NAME_PS_LENGTH](../vs140/column_name_ps_length.md)   
 [COLUMN_NAME_PS_STATUS](../vs140/column_name_ps_status.md)   
 [COLUMN_NAME_PS_LENGTH_STATUS](../vs140/column_name_ps_length_status.md)   
 [COLUMN_NAME_TYPE](../vs140/column_name_type.md)   
 [COLUMN_NAME_TYPE_PS](../vs140/column_name_type_ps.md)   
 [COLUMN_NAME_TYPE_SIZE](../vs140/column_name_type_size.md)   
 [COLUMN_NAME_TYPE_STATUS](../vs140/column_name_type_status.md)