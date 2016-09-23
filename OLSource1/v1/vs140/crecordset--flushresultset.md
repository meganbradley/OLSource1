---
title: "CRecordset::FlushResultSet"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CRecordset::FlushResultSet
  - CRecordset.FlushResultSet
  - FlushResultSet
  - SQLMoreResults
dev_langs: 
  - C++
helpviewer_keywords: 
  - result sets
  - FlushResultSet method
  - SQLMoreResults
  - result sets, retrieving
ms.assetid: 21502f57-e174-4937-b775-9cc07b70cb91
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CRecordset::FlushResultSet
Retrieves the next result set of a predefined query (stored procedure), if there are multiple result sets.  
  
## Syntax  
  
```  
  
BOOL FlushResultSet( );  
  
```  
  
## Return Value  
 Nonzero if there are more result sets to be retrieved; otherwise 0.  
  
## Remarks  
 You should call `FlushResultSet` only when you are completely finished with the cursor on the current result set. Note that when you retrieve the next result set by calling `FlushResultSet`, your cursor is not valid on that result set; you should call the [MoveNext](../vs140/crecordset--movenext.md) member function after calling `FlushResultSet`.  
  
 If a predefined query uses an output parameter or input/output parameters, you must call `FlushResultSet` until it returns `FALSE` (the value 0), in order to obtain these parameter values.  
  
 `FlushResultSet` calls the ODBC API function `SQLMoreResults`. If `SQLMoreResults` returns `SQL_ERROR` or `SQL_INVALID_HANDLE`, then `FlushResultSet` will throw an exception. For more information about `SQLMoreResults`, see the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 Your stored procedure needs to have bound fields if you want to call `FlushResultSet`.  
  
## Exceptions  
 This method can throw exceptions of type `CDBException*`.  
  
## Example  
 The following code assumes that `COutParamRecordset` is a `CRecordset`-derived object based on a predefined query with an input parameter and an output parameter, and having multiple result sets. Note the structure of the [DoFieldExchange](../vs140/crecordset--dofieldexchange.md) override.  
  
 [!code[NVC_MFCDatabase#21](../vs140/codesnippet/CPP/crecordset--flushresultset_1.cpp)]
  
  
 [!code[NVC_MFCDatabase#22](../vs140/codesnippet/CPP/crecordset--flushresultset_2.cpp)]
  
  
## Requirements  
 **Header:** afxdb.h  
  
## See Also  
 [CRecordset Class](../vs140/crecordset-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CFieldExchange::SetFieldType](../vs140/cfieldexchange--setfieldtype.md)