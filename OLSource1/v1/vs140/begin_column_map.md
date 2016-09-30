---
title: "BEGIN_COLUMN_MAP"
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
  - "BEGIN_COLUMN_MAP"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "BEGIN_COLUMN_MAP macro"
ms.assetid: d6ffe633-e0da-4e33-8faa-f7f259d05420
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# BEGIN_COLUMN_MAP
Marks the beginning of a column map entry.  
  
## Syntax  
  
```  
  
BEGIN_COLUMN_MAP(  
x  
 )  
  
```  
  
#### Parameters  
 *x*  
 [in] The name of the user record class derived from `CAccessor`.  
  
## Remarks  
 This macro is used in the case of a single accessor on a rowset. If you have multiple accessors on a rowset, use [BEGIN_ACCESSOR_MAP](../vs140/begin_accessor_map.md).  
  
 The `BEGIN_COLUMN_MAP` macro is completed with the `END_COLUMN_MAP` macro. This macro is used when there is only one accessor required in the user record.  
  
 Columns correspond to fields in the rowset you want to bind.  
  
## Example  
 Here is a sample column and parameter map:  
  
 [!CODE [NVC_OLEDB_Consumer#16](../CodeSnippet/VS_Snippets_Cpp/NVC_OLEDB_Consumer#16)]  
  
## Requirements  
 **Header:** atldbcli.h  
  
## See Also  
 [Macros and Global Functions for OLE DB Consumer Templates](../vs140/macros-and-global-functions-for-ole-db-consumer-templates.md)   
 [END_COLUMN_MAP](../vs140/end_column_map.md)   
 [COLUMN_ENTRY](../vs140/column_entry.md)   
 [COLUMN_ENTRY_EX](../vs140/column_entry_ex.md)