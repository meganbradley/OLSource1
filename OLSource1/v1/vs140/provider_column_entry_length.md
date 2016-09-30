---
title: "PROVIDER_COLUMN_ENTRY_LENGTH"
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
  - "PROVIDER_COLUMN_ENTRY_LENGTH"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "PROVIDER_COLUMN_ENTRY_LENGTH macro"
ms.assetid: b4a67246-c049-4622-bb65-242cc8cae4be
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# PROVIDER_COLUMN_ENTRY_LENGTH
Represents a specific column supported by the provider.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *name*  
 [in] The column name.  
  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [in] The column number. Unless the column is a Bookmark column, the column number must not be 0.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] The column size in bytes.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] The member variable in <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> that stores the column data.  
  
## Remarks  
 Allows you to specify the column size.  
  
## Example  
 See [BEGIN_PROVIDER_COLUMN_MAP](../vs140/begin_provider_column_map.md).  
  
## Requirements  
 **Header:** atldb.h  
  
## See Also  
 [Macros for OLE DB Provider Templates](../vs140/macros-for-ole-db-provider-templates.md)   
 [OLE DB Provider Templates](../vs140/ole-db-provider-templates--c---.md)   
 [OLE DB Provider Template Architecture](../vs140/ole-db-provider-template-architecture.md)   
 [Creating an OLE DB Provider](../vs140/creating-an-ole-db-provider.md)