---
title: "CDatabase::ExecuteSQL"
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
  - "CDatabase::ExecuteSQL"
  - "CDatabase.ExecuteSQL"
  - "ExecuteSQL"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDatabase class, operations"
  - "ExecuteSQL method"
ms.assetid: f019e896-136b-4e35-bb78-08f87dac2054
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDatabase::ExecuteSQL
Call this member function when you need to execute a SQL command directly.  
  
## Syntax  
  
```  
  
      void ExecuteSQL(   
   LPCTSTR lpszSQL    
);  
```  
  
#### Parameters  
 `lpszSQL`  
 Pointer to a null-terminated string containing a valid SQL command to execute. You can pass a [CString](../vs140/cstringt-class.md).  
  
## Remarks  
 Create the command as a null-terminated string. `ExecuteSQL` does not return data records. If you want to operate on records, use a recordset object instead.  
  
 Most of your commands for a data source are issued through recordset objects, which support commands for selecting data, inserting new records, deleting records, and editing records. However, not all ODBC functionality is directly supported by the database classes, so you may at times need to make a direct SQL call with `ExecuteSQL`.  
  
## Example  
 [!code[NVC_MFCDatabase#13](../vs140/codesnippet/CPP/cdatabase--executesql_1.cpp)]  
  
## Requirements  
 **Header:** afxdb.h  
  
## See Also  
 [CDatabase Class](../vs140/cdatabase-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDatabase::SetLoginTimeout](../vs140/cdatabase--setlogintimeout.md)   
 [CRecordset Class](../vs140/crecordset-class.md)