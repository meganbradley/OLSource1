---
title: "CDatabase::Rollback"
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
  - "Rollback"
  - "CDatabase.Rollback"
  - "CDatabase::Rollback"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Rollback method, database"
  - "CDatabase class, database operations"
ms.assetid: 42d03721-5e73-44ab-a2e3-b2fd9f049e16
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDatabase::Rollback
Call this member function to reverse the changes made during a transaction.  
  
## Syntax  
  
```  
  
BOOL Rollback( );  
```  
  
## Return Value  
 Nonzero if the transaction was successfully reversed; otherwise 0. If a **Rollback** call fails, the data source and transaction states are undefined. If **Rollback** returns 0, you must check the data source to determine its state.  
  
## Remarks  
 All `CRecordset` `AddNew`, **Edit**, **Delete**, and **Update** calls executed since the last [BeginTrans](../vs140/cdatabase--begintrans.md) are rolled back to the state that existed at the time of that call.  
  
 After a call to **Rollback**, the transaction is over, and you must call **BeginTrans** again for another transaction. The record that was current before you called **BeginTrans** becomes the current record again after **Rollback**.  
  
 After a rollback, the record that was current before the rollback remains current. For details about the state of the recordset and the data source after a rollback, see the article [Transaction (ODBC)](../vs140/transaction--odbc-.md).  
  
## Example  
 See the article [Transaction: Performing a Transaction in a Recordset (ODBC)](../vs140/transaction--performing-a-transaction-in-a-recordset--odbc-.md).  
  
## Requirements  
 **Header:** afxdb.h  
  
## See Also  
 [CDatabase Class](../vs140/cdatabase-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDatabase::BeginTrans](../vs140/cdatabase--begintrans.md)   
 [CDatabase::CommitTrans](../vs140/cdatabase--committrans.md)