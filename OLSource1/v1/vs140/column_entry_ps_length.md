---
title: "COLUMN_ENTRY_PS_LENGTH"
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
  - "COLUMN_ENTRY_PS_LENGTH"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COLUMN_ENTRY_PS_LENGTH macro"
ms.assetid: d63ab895-a4df-4183-ac09-cf2311222408
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COLUMN_ENTRY_PS_LENGTH
Represents a binding on the rowset to the specific column in the database.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 See [DBBINDING](https://msdn.microsoft.com/en-us/library/ms716845.aspx) in the *OLE DB Programmer's Reference*.  
  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [in] The column number, starting with one. Bookmark corresponds to column zero.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] The maximum precision of the column you want to bind.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] The scale of the column you want to bind.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [in] The corresponding data member in the user record.  
  
 *length*  
 [in] The variable to be bound to the column length.  
  
## Remarks  
 Allows you to specify the precision and scale of the column you want to bind. This macro supports the *length* variable. It is used in the following places:  
  
-   Between the [BEGIN_COLUMN_MAP](../vs140/begin_column_map.md) and [END_COLUMN_MAP](../vs140/end_column_map.md) macros.  
  
-   Between the [BEGIN_ACCESSOR](../vs140/begin_accessor.md) and [END_ACCESSOR](../vs140/end_accessor.md) macros.  
  
-   Between the [BEGIN_PARAM_MAP](../vs140/begin_param_map.md) and [END_PARAM_MAP](../vs140/end_param_map.md) macros.  
  
## Requirements  
 **Header:** atldbcli.h  
  
## See Also  
 [Macros and Global Functions for OLE DB Consumer Templates](../vs140/macros-and-global-functions-for-ole-db-consumer-templates.md)   
 [BEGIN_ACCESSOR](../vs140/begin_accessor.md)   
 [BEGIN_ACCESSOR_MAP](../vs140/begin_accessor_map.md)   
 [BEGIN_COLUMN_MAP](../vs140/begin_column_map.md)   
 [COLUMN_ENTRY](../vs140/column_entry.md)   
 [COLUMN_ENTRY_EX](../vs140/column_entry_ex.md)   
 [COLUMN_ENTRY_LENGTH](../vs140/column_entry_length.md)   
 [COLUMN_ENTRY_PS](../vs140/column_entry_ps.md)   
 [COLUMN_ENTRY_LENGTH_STATUS](../vs140/column_entry_length_status.md)   
 [COLUMN_ENTRY_PS_LENGTH_STATUS](../vs140/column_entry_ps_length_status.md)   
 [COLUMN_ENTRY_STATUS](../vs140/column_entry_status.md)   
 [COLUMN_ENTRY_PS_STATUS](../vs140/column_entry_ps_status.md)   
 [END_ACCESSOR](../vs140/end_accessor.md)   
 [END_ACCESSOR_MAP](../vs140/end_accessor_map.md)   
 [END_COLUMN_MAP](../vs140/end_column_map.md)