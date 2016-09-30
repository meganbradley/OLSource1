---
title: "CRecordset::GetODBCFieldInfo"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "CRecordset::GetODBCFieldInfo"
  - "GetODBCFieldInfo"
  - "CRecordset.GetODBCFieldInfo"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetODBCFieldInfo method"
ms.assetid: 83193643-ef89-403e-86db-318b97822762
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRecordset::GetODBCFieldInfo
Obtains information about the fields in the recordset.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The name of a field.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A reference to a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> structure.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The zero-based index of the field.  
  
## Remarks  
 One version of the function lets you look up a field by name. The other version lets you look up a field by index.  
  
 For a description about the information returned, see the [CODBCFieldInfo](../vs140/codbcfieldinfo-structure.md) structure.  
  
 For more information about creating recordsets, see the article [Recordset: Creating and Closing Recordsets (ODBC)](../vs140/recordset--creating-and-closing-recordsets--odbc-.md).  
  
## Exceptions  
 This method can throw exceptions of type **CDBException\***.  
  
## Requirements  
 **Header:** afxdb.h  
  
## See Also  
 [CRecordset Class](../vs140/crecordset-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRecordset::GetFieldValue](../vs140/crecordset--getfieldvalue.md)   
 [CODBCFieldInfo Structure](../vs140/codbcfieldinfo-structure.md)