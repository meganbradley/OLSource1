---
title: "BEGIN_ACCESSOR_MAP"
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
  - "BEGIN_ACCESSOR_MAP"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "BEGIN_ACCESSOR_MAP macro"
ms.assetid: e6d6e3a4-62fa-4e49-8c53-caf8c9d20091
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# BEGIN_ACCESSOR_MAP
Marks the beginning of the accessor map entries.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *x*  
 [in] The name of the user record class.  
  
 *num*  
 [in] The number of accessors in this accessor map.  
  
## Remarks  
 In the case of multiple accessors on a rowset, you need to specify <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> at the beginning and use the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> macro for each individual accessor. The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> macro is completed with the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> macro. The accessor map is completed with the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> macro.  
  
 If you have only one accessor in the user record, use the macro [BEGIN_COLUMN_MAP](../vs140/begin_column_map.md).  
  
## Example  
 [!CODE [NVC_OLEDB_Consumer#15](../CodeSnippet/VS_Snippets_Cpp/NVC_OLEDB_Consumer#15)]  
  
## Requirements  
 **Header:** atldbcli.h  
  
## See Also  
 [Macros and Global Functions for OLE DB Consumer Templates](../vs140/macros-and-global-functions-for-ole-db-consumer-templates.md)   
 [BEGIN_ACCESSOR](../vs140/begin_accessor.md)   
 [END_ACCESSOR](../vs140/end_accessor.md)   
 [END_ACCESSOR_MAP](../vs140/end_accessor_map.md)