---
title: "PROVIDER_COLUMN_ENTRY_GN"
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
  - "PROVIDER_COLUMN_ENTRY_GN"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "PROVIDER_COLUMN_ENTRY_GN macro"
ms.assetid: be77ba85-634c-4e28-832f-d2fa40413254
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# PROVIDER_COLUMN_ENTRY_GN
Represents a specific column supported by the provider.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *name*  
 [in] The column name.  
  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [in] The column number. Unless the column is a Bookmark column, the column number must not be 0.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] Specifies how data is returned. See the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> description in [DBBINDING Structures](https://msdn.microsoft.com/en-us/library/ms716845.aspx).  
  
 *colSize*  
 [in] The column size.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [in] Indicates the data type of the value. See the **wType** description in [DBBINDING Structures](https://msdn.microsoft.com/en-us/library/ms716845.aspx).  
  
 *precision*  
 [in] Indicates the precision to use when getting data if *dbType* is <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> or **DBTYPE_DECIMAL**. See the **bPrecision** description in [DBBINDING Structures](https://msdn.microsoft.com/en-us/library/ms716845.aspx).  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 [in] Indicates the scale to use when getting data if dbType is <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> or **DBTYPE_DECIMAL**. See the **bScale** description in [DBBINDING Structures](https://msdn.microsoft.com/en-us/library/ms716845.aspx).  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 A schema rowset GUID. See [IDBSchemaRowset](https://msdn.microsoft.com/en-us/library/ms713686.aspx) in the *OLE DB Programmer's Reference* for a list of schema rowsets and their GUIDs.  
  
## Remarks  
 Allows you to specify the column's size, data type, precision, scale, and schema rowset GUID.  
  
## Requirements  
 **Header:** atldb.h  
  
## See Also  
 [Macros for OLE DB Provider Templates](../vs140/macros-for-ole-db-provider-templates.md)   
 [OLE DB Provider Templates](../vs140/ole-db-provider-templates--c---.md)   
 [OLE DB Provider Template Architecture](../vs140/ole-db-provider-template-architecture.md)   
 [Creating an OLE DB Provider](../vs140/creating-an-ole-db-provider.md)