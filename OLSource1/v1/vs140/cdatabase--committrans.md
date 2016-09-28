---
title: "CDatabase::CommitTrans"
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
  - "CommitTrans"
  - "CDatabase::CommitTrans"
  - "CDatabase.CommitTrans"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDatabase class, database operations"
  - "CommitTrans method"
ms.assetid: be4012df-5fae-4fcf-ac2b-cfbe2a6ba96d
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDatabase::CommitTrans
Call this member function upon completing transactions.  
  
## Syntax  
  
```  
  
BOOL CommitTrans( );  
```  
  
## Return Value  
 Nonzero if the updates were successfully committed; otherwise 0. If **CommitTrans** fails, the state of the data source is undefined. You must check the data to determine its state.  
  
## Remarks  
 A transaction consists of a series of calls to the `AddNew`, **Edit**, **Delete**, and **Update** member functions of a `CRecordset` object that began with a call to the [BeginTrans](../vs140/cdatabase--begintrans.md) member function. **CommitTrans** commits the transaction. By default, updates are committed immediately; calling **BeginTrans** causes commitment of updates to be delayed until **CommitTrans** is called.  
  
 Until you call **CommitTrans** to end a transaction, you can call the [Rollback](../vs140/cdatabase--rollback.md) member function to abort the transaction and leave the data source in its original state. To begin a new transaction, call **BeginTrans** again.  
  
 For more information about transactions, see the article [Transaction (ODBC)](../vs140/transaction--odbc-.md).  
  
## Example  
 See the article [Transaction: Performing a Transaction in a Recordset (ODBC)](../vs140/transaction--performing-a-transaction-in-a-recordset--odbc-.md).  
  
## Requirements  
 **Header:** afxdb.h  
  
## See Also  
 [CDatabase Class](../vs140/cdatabase-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDatabase::BeginTrans](../vs140/cdatabase--begintrans.md)   
 [CDatabase::Rollback](../vs140/cdatabase--rollback.md)