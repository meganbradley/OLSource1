---
title: "CDatabase::BeginTrans"
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
  - "CDatabase::BeginTrans"
  - "CDatabase.BeginTrans"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDatabase class, database operations"
  - "BeginTrans method"
ms.assetid: 3dfbe7d5-abd5-4ab7-a2a7-2e2a5c3fd3bd
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDatabase::BeginTrans
Call this member function to begin a transaction with the connected data source.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Nonzero if the call was successful and changes are committed only manually; otherwise 0.  
  
## Remarks  
 A transaction consists of one or more calls to the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, **Edit**, **Delete**, and **Update** member functions of a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object. Before beginning a transaction, the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object must already have been connected to the data source by calling its <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> or **Open** member function. To end the transaction, call [CommitTrans](../vs140/cdatabase--committrans.md) to accept all changes to the data source (and carry them out) or call [Rollback](../vs140/cdatabase--rollback.md) to abort the entire transaction. Call **BeginTrans** after you open any recordsets involved in the transaction and as close to the actual update operations as possible.  
  
> [!CAUTION]
>  Depending on your ODBC driver, opening a recordset before calling **BeginTrans** may cause problems when calling **Rollback**. You should check the specific driver you are using. For example, when using the Microsoft Access driver included in the Microsoft ODBC Desktop Driver Pack 3.0, you must account for the Jet database engine's requirement that you should not begin a transaction on any database that has an open cursor. In the MFC database classes, an open cursor means an open <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object. For more information, see [Technical Note 68](../vs140/tn068--performing-transactions-with-the-microsoft-access-7-odbc-driver.md).  
  
 **BeginTrans** may also lock data records on the server, depending on the requested concurrency and the capabilities of the data source. For information about locking data, see the article [Recordset: Locking Records (ODBC)](../vs140/recordset--locking-records--odbc-.md).  
  
 User-defined transactions are explained in the article [Transaction (ODBC)](../vs140/transaction--odbc-.md).  
  
 **BeginTrans** establishes the state to which the sequence of transactions can be rolled back (reversed). To establish a new state for rollbacks, commit any current transaction, then call **BeginTrans** again.  
  
> [!CAUTION]
>  Calling **BeginTrans** again without calling **CommitTrans** or **Rollback** is an error.  
  
 Call the [CanTransact](../vs140/cdatabase--cantransact.md) member function to determine whether your driver supports transactions for a given database. You should also call [GetCursorCommitBehavior](../vs140/cdatabase--getcursorcommitbehavior.md) and [GetCursorRollbackBehavior](../vs140/cdatabase--getcursorrollbackbehavior.md) to determine the support for cursor preservation.  
  
 For more information about transactions, see the article [Transaction (ODBC)](../vs140/transaction--odbc-.md).  
  
## Example  
 See the article [Transaction: Performing a Transaction in a Recordset (ODBC)](../vs140/transaction--performing-a-transaction-in-a-recordset--odbc-.md).  
  
## Requirements  
 **Header:** afxdb.h  
  
## See Also  
 [CDatabase Class](../vs140/cdatabase-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDatabase::CommitTrans](../vs140/cdatabase--committrans.md)   
 [CDatabase::Rollback](../vs140/cdatabase--rollback.md)   
 [CRecordset::CanTransact](../vs140/crecordset--cantransact.md)